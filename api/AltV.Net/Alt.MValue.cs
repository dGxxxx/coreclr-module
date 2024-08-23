using System;
using System.Numerics;
using AltV.Net.Data;
using AltV.Net.Elements.Args;
using AltV.Net.Elements.Entities;
using AltV.Net.ObjectMethodExecutors;

namespace AltV.Net
{
    public static partial class Alt
    {
        public static void RegisterMValueAdapter<T>(IMValueAdapter<T> adapter)
        {
            CoreImpl.RegisterMValueAdapter(adapter);
        }

        public static bool ToMValue(object obj, Type type, out MValueConst mValue)
        {
            return CoreImpl.ToMValue(obj, type, out mValue);
        }

        public static bool FromMValue(in MValueConst mValue, Type type, out object obj)
        {
            return CoreImpl.FromMValue(mValue, type, out obj);
        }

        public static bool MValueFromObject(object obj, Type type, out object result)
        {
            return CoreImpl.MValueFromObject(obj, type, out result);
        }

        public static bool IsMValueConvertible(Type type)
        {
            return CoreImpl.IsMValueConvertible(type);
        }

        public static MValueWriter2 CreateMValueWriter()
        {
            return new MValueWriter2(CoreImpl);
        }

        public static MValueBuffer2 CreateMValueBuffer(MValueConst[] values)
        {
            return new MValueBuffer2(CoreImpl, values);
        }

        public static void CreateMValueNil(out MValueConst mValue)
        {
            CoreImpl.CreateMValueNil(out mValue);
        }

        public static void CreateMValueBool(out MValueConst mValue, bool value)
        {
            CoreImpl.CreateMValueBool(out mValue, value);
        }

        public static void CreateMValueInt(out MValueConst mValue, long value)
        {
            CoreImpl.CreateMValueInt(out mValue, value);
        }

        public static void CreateMValueUInt(out MValueConst mValue, ulong value)
        {
            CoreImpl.CreateMValueUInt(out mValue, value);
        }

        public static void CreateMValueDouble(out MValueConst mValue, double value)
        {
            CoreImpl.CreateMValueDouble(out mValue, value);
        }

        public static void CreateMValueString(out MValueConst mValue, string value)
        {
            CoreImpl.CreateMValueString(out mValue, value);
        }

        public static void CreateMValueList(out MValueConst mValue, MValueConst[] val, ulong size)
        {
            CoreImpl.CreateMValueList(out mValue, val, size);
        }

        public static void CreateMValueDict(out MValueConst mValue, string[] keys, MValueConst[] val,
                                            ulong size)
        {
            CoreImpl.CreateMValueDict(out mValue, keys, val, size);
        }

        public static void CreateMValueBaseObject(out MValueConst mValue, IBaseObject value)
        {
            CoreImpl.CreateMValueBaseObject(out mValue, value);
        }

        public static void CreateMValueFunction(out MValueConst mValue, IntPtr value)
        {
            CoreImpl.CreateMValueFunction(out mValue, value);
        }

        public static void CreateMValueVector3(out MValueConst mValue, Position value)
        {
            CoreImpl.CreateMValueVector3(out mValue, value);
        }

        public static void CreateMValueVector2(out MValueConst mValue, Vector2 value)
        {
            CoreImpl.CreateMValueVector2(out mValue, value);
        }

        public static void CreateMValueRgba(out MValueConst mValue, Rgba value)
        {
            CoreImpl.CreateMValueRgba(out mValue, value);
        }

        public static void CreateMValueByteArray(out MValueConst mValue, byte[] value)
        {
            CoreImpl.CreateMValueByteArray(out mValue, value);
        }

        public static void CreateMValue(out MValueConst mValue, object obj)
        {
            CoreImpl.CreateMValue(out mValue, obj);
        }

        public static void CreateMValues(MValueConst[] mValues, object[] objects)
        {
            CoreImpl.CreateMValues(mValues, objects);
        }
    }
}