using AltV.Net.Elements.Args;
using AltV.Net.Shared.Utils;

namespace AltV.Net.Client
{
    public partial class Alt
    {
        public static void SetMetaData(string key, object value) => CoreImpl.SetMetaData(key, value);

        public static bool HasMetaData(string key) => CoreImpl.HasMetaData(key);

        public static void DeleteMetaData(string key) => CoreImpl.DeleteMetaData(key);

        public static bool HasLocalMetaData(string key) => CoreImpl.HasLocalMetaData(key);

        public static bool GetMetaData(string key, out int result)
        {
            CoreImpl.GetMetaData(key, out var mValue);
            using (mValue)
            {
                if (mValue.type != MValueConst.Type.Int)
                {
                    result = default;
                    return false;
                }

                result = (int) mValue.GetInt();
            }

            return true;
        }

        public static bool GetMetaData(string key, out uint result)
        {
            CoreImpl.GetMetaData(key, out var mValue);
            using (mValue)
            {
                if (mValue.type != MValueConst.Type.Uint)
                {
                    result = default;
                    return false;
                }

                result = (uint) mValue.GetUint();
            }

            return true;
        }

        public static bool GetMetaData(string key, out float result)
        {
            CoreImpl.GetMetaData(key, out var mValue);
            using (mValue)
            {
                if (mValue.type != MValueConst.Type.Double)
                {
                    result = default;
                    return false;
                }

                result = (float) mValue.GetDouble();
            }

            return true;
        }

        public static bool GetMetaData<T>(string key, out T result)
        {
            CoreImpl.GetMetaData(key, out var mValue);
            using (mValue)
            {

                try
                {
                    result = Utils.GetCastedMValue<T>(mValue);
                    return true;
                }
                catch
                {
                    result = default;
                    return false;
                }
            }
        }

        public static bool GetSyncedMetaData<T>(string key, out T result)
        {
            CoreImpl.GetSyncedMetaData(key, out var mValue);
            using (mValue)
            {

                try
                {
                    result = Utils.GetCastedMValue<T>(mValue);
                    return true;
                }
                catch
                {
                    result = default;
                    return false;
                }
            }
        }

        public static bool GetLocalMetaData<T>(string key, out T result)
        {
            CoreImpl.GetLocalMetaData<T>(key, out var mValue);
            using (mValue)
            {

                try
                {
                    result = Utils.GetCastedMValue<T>(mValue);
                    return true;
                }
                catch
                {
                    result = default;
                    return false;
                }
            }
        }
    }
}