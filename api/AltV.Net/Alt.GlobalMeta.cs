using System;
using System.Collections.Generic;
using AltV.Net.Elements.Args;
using AltV.Net.Shared.Utils;

namespace AltV.Net
{
    public static partial class Alt
    {
        public static void SetMetaData(string key, object value) => Core.SetMetaData(key, value);

        public static bool HasMetaData(string key) => Core.HasMetaData(key);

        public static void DeleteMetaData(string key) => Core.DeleteMetaData(key);

        public static bool GetMetaData<T>(string key, out T result)
        {
            Core.GetMetaData(key, out var mValue);

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

        public static void SetSyncedMetaData(string key, object value) => Core.SetSyncedMetaData(key, value);

        public static bool HasSyncedMetaData(string key) => Core.HasSyncedMetaData(key);

        public static void DeleteSyncedMetaData(string key) => Core.DeleteSyncedMetaData(key);

        public static bool GetSyncedMetaData<T>(string key, out T result)
        {
            Core.GetSyncedMetaData(key, out var mValue);
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