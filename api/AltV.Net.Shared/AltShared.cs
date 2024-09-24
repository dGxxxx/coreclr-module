using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AltV.Net")]
[assembly: InternalsVisibleTo("AltV.Net.Mock")]
[assembly: InternalsVisibleTo("AltV.Net.Async")]
[assembly: InternalsVisibleTo("AltV.Net.Client")]

namespace AltV.Net.Shared
{
    public static class AltShared
    {
        internal static ISharedCore CoreImpl { get; set; }
        public static uint Hash(string key) => CoreImpl.Hash(key);
        public static bool CacheEntities = true;
        public static void EmitLocal(string eventName, params object[] args) => CoreImpl.TriggerLocalEvent(eventName, args);
    }
}