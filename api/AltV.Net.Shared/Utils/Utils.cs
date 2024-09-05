using System.Text;
using AltV.Net.Elements.Args;

namespace AltV.Net.Shared.Utils
{
    public static class Utils
    {
        public static uint Hash(string stringToHash)
        {
            if (string.IsNullOrEmpty(stringToHash)) return 0;

            var characters = Encoding.UTF8.GetBytes(stringToHash.ToLower());

            uint hash = 0;

            foreach (var c in characters)
            {
                hash += c;
                hash += hash << 10;
                hash ^= hash >> 6;
            }

            hash += hash << 3;
            hash ^= hash >> 11;
            hash += hash << 15;

            return hash;
        }

        public static T GetCastedMValue<T>(MValueConst mValue)
        {
            object @object;

            if (mValue.type == MValueConst.Type.List)
            {
                if (mValue.ToObject() is IEnumerable<object> sourceEnumerable)
                {

                    if (typeof(T).IsArray)
                    {
                        var resultList = new List<object>();
                        var elementType = typeof(T).IsArray ? typeof(T).GetElementType() : typeof(T).GetGenericArguments()[0];

                        foreach (var item in sourceEnumerable)
                        {
                            if (item == null)
                            {
                                resultList.Add(null);
                            }
                            else
                            {
                                resultList.Add(Convert.ChangeType(item, elementType));
                            }
                        }

                        var resultArray = Array.CreateInstance(elementType, resultList.Count);
                        for (int i = 0; i < resultList.Count; i++)
                        {
                            resultArray.SetValue(resultList[i], i);
                        }
                        return (T)(object)resultArray;
                    }
                    else
                    {
                        T resultList = default(T)!;
                        if (typeof(T).IsGenericType && (typeof(T).GetGenericTypeDefinition() == typeof(List<>)))
                        {
                            resultList = Activator.CreateInstance<T>();

                            var type = typeof(T).GetGenericArguments()[0];
                            foreach (var item in (object[])mValue.ToObject())
                            {
                                if (item == null)
                                {
                                    resultList.GetType().GetMethod("Add").Invoke(resultList, [null]);
                                }
                                else
                                {
                                    var val = item;
                                    if (type != typeof(object))
                                    {
                                        val = Convert.ChangeType(val, type);
                                    }

                                    resultList.GetType().GetMethod("Add").Invoke(resultList, [val]);
                                }
                            }
                        }
                        return resultList;
                    }
                }
                else
                {
                    throw new ArgumentException("Quellobjekt muss eine IEnumerable<object> sein.");
                }

                /*
                T resultList = default(T)!;
                if (typeof(T).IsGenericType && (typeof(T).GetGenericTypeDefinition() == typeof(List<>)))
                {
                    resultList = Activator.CreateInstance<T>();

                    var type = typeof(T).GetGenericArguments()[0];
                    foreach (var item in (object[])mValue.ToObject())
                    {
                        if (item == null)
                        {
                            resultList.GetType().GetMethod("Add").Invoke(resultList, [null]);
                        }
                        else
                        {
                            resultList.GetType().GetMethod("Add").Invoke(resultList, [Convert.ChangeType(item, type)]);
                        }
                    }
                }

                return resultList;*/
            }

            if (mValue.type == MValueConst.Type.Dict)
            {
                T resultDictionary = default(T);
                if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(Dictionary<,>))
                {
                    var dictionaryType = typeof(T);
                    var valueType = dictionaryType.GetGenericArguments()[1];

                    if (mValue.ToObject() is Dictionary<string, object> sourceDictionary)
                    {
                        resultDictionary = Activator.CreateInstance<T>();

                        foreach (var kvp in sourceDictionary)
                        {
                            var val = kvp.Value;
                            if (valueType != typeof(object))
                            {
                                val = Convert.ChangeType(val, valueType);
                            }
                            resultDictionary.GetType().GetMethod("Add").Invoke(resultDictionary, new object[] { kvp.Key, val });
                        }

                        return resultDictionary;
                    }
                    else
                    {
                        throw new ArgumentException("Quellobjekt muss ein Dictionary<object, object> sein.");
                    }
                }
                return resultDictionary;
            }

            @object = mValue.ToObject();

            return (T)Convert.ChangeType(@object, typeof(T));
        }
    }
}