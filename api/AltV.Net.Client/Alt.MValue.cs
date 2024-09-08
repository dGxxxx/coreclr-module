using AltV.Net.Elements.Args;

namespace AltV.Net.Client
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
    }
}