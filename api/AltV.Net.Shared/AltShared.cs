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
        
        public static void RegisterMValueAdapter<T>(IMValueAdapter<T> adapter) => CoreImpl.RegisterMValueAdapter(adapter);
        
        public static string SdkVersion  => CoreImpl.SdkVersion;

        public static string CApiVersion => CoreImpl.CApiVersion;

        public static string Version  => CoreImpl.Version;

        public static string Branch  => CoreImpl.Branch;

        public static bool IsDebug => CoreImpl.IsDebug;

        public static void LogInfo(string message) => CoreImpl.LogInfo(message);
        
        public static void LogDebug(string message) => CoreImpl.LogDebug(message);
        
        public static void LogWarning(string message) => CoreImpl.LogWarning(message);
        
        public static void LogError(string message) => CoreImpl.LogError(message);
        
        public static void LogColored(string message) => CoreImpl.LogColored(message);
        
        public static bool IsMainThread() => CoreImpl.IsMainThread();
        
        public static int NetTime => CoreImpl.NetTime;
    }
}