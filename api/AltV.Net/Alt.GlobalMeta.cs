using System;
using System.Collections.Generic;
using AltV.Net.Elements.Args;
using AltV.Net.Shared.Utils;

namespace AltV.Net
{
    public static partial class Alt
    {
        public static void SetMetaData(string key, object value) => CoreImpl.SetMetaData(key, value);

        public static bool HasMetaData(string key) => CoreImpl.HasMetaData(key);

        public static void DeleteMetaData(string key) => CoreImpl.DeleteMetaData(key);

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

        public static void SetSyncedMetaData(string key, object value) => CoreImpl.SetSyncedMetaData(key, value);

        public static bool HasSyncedMetaData(string key) => CoreImpl.HasSyncedMetaData(key);

        public static void DeleteSyncedMetaData(string key) => CoreImpl.DeleteSyncedMetaData(key);

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
    }
}