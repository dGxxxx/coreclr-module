using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using AltV.Net.Client.Elements;
using AltV.Net.Client.Elements.Data;
using AltV.Net.Client.Elements.Interfaces;
using AltV.Net.Elements.Entities;
using AltV.Net.Shared;

[assembly: InternalsVisibleTo("AltV.Net.Client.Async")]
namespace AltV.Net.Client
{
    public static partial class Alt
    {
        internal static ICore CoreImpl { get; set; } = null!;
        public static INativeResource Resource => CoreImpl.Resource;
        public static ILogger Logger { get; internal set; } = null!;
        public static bool CacheEntities { get => AltShared.CacheEntities; set => AltShared.CacheEntities = value; }

        public static IEnumerable<string> GetRegisteredClientEvents() => CoreImpl.GetRegisteredClientEvents();
        public static IEnumerable<string> GetRegisteredServerEvents() => CoreImpl.GetRegisteredServerEvents();

        public static bool GetBaseObjectById(BaseObjectType type, uint id, [MaybeNullWhen(false)] out IBaseObject baseObject)
        {
            baseObject = default;
            var ent = CoreImpl.GetBaseObjectById(type, id);
            if (ent is null) return false;
            baseObject = ent;
            return true;
        }

        public static INatives Natives => CoreImpl.Natives;
        public static ILocalPlayer LocalPlayer => CoreImpl.PoolManager.Player.LocalPlayer;
        public static Discord Discord => CoreImpl.Discord;
        public static DiscordUser? GetDiscordUser() => CoreImpl.GetDiscordUser();
        public static LocalStorage LocalStorage => CoreImpl.LocalStorage;
        public static Voice Voice => CoreImpl.Voice;
        public static FocusData FocusData => CoreImpl.FocusData;

        public static HandlingData? GetHandlingByModelHash(uint modelHash) => CoreImpl.GetHandlingByModelHash(modelHash);
        public static WeaponData? GetWeaponDataByWeaponHash(uint weaponHash) => CoreImpl.GetWeaponDataByWeaponHash(weaponHash);
        public static uint Hash(string key) => CoreImpl.Hash(key);

        public static void Log(string message) => Logger.LogInfo(message);
        public static void LogInfo(string message) => Logger.LogInfo(message);
        public static void LogWarning(string message) => Logger.LogWarning(message);
        public static void LogError(string message) => Logger.LogError(message);
        public static void LogDebug(string message) => Logger.LogDebug(message);

        public static string Branch => CoreImpl.Branch;
        public static string Version => CoreImpl.Version;
        public static string SdkVersion => CoreImpl.SdkVersion;
        public static string CApiVersion => CoreImpl.CApiVersion;
        public static bool IsDebug => CoreImpl.IsDebug;

        public static IReadOnlyCollection<IPlayer> GetAllPlayers() => CoreImpl.GetAllPlayers();
        public static IReadOnlyCollection<IVehicle> GetAllVehicles() => CoreImpl.GetAllVehicles();
        public static IReadOnlyCollection<IPed> GetAllPeds() => CoreImpl.GetAllPeds();
        public static IReadOnlyCollection<IObject> GetAllNetworkObjects() => CoreImpl.GetAllNetworkObjects();
        public static IReadOnlyCollection<IColShape> GetAllColShapes() => CoreImpl.GetAllColShapes();
        public static IReadOnlyCollection<IMarker> GetAllMarkers() => CoreImpl.GetAllMarkers();
        public static IReadOnlyCollection<ITextLabel> GetAllTextLabels() => CoreImpl.GetAllTextLabels();
        public static IReadOnlyCollection<ILocalObject> GetAllLocalObjects() => CoreImpl.GetAllLocalObjects();
        public static IReadOnlyCollection<ILocalVehicle> GetAllLocalVehicles() => CoreImpl.GetAllLocalVehicles();
        public static IReadOnlyCollection<ILocalPed> GetAllLocalPeds() => CoreImpl.GetAllLocalPeds();
        public static IReadOnlyCollection<ILocalObject> GetAllWorldObjects() => CoreImpl.GetAllWorldObjects();
        public static IReadOnlyCollection<IVirtualEntity> GetAllVirtualEntities() => CoreImpl.GetAllVirtualEntities();
        public static IReadOnlyCollection<IVirtualEntityGroup> GetAllVirtualEntityGroups() => CoreImpl.GetAllVirtualEntityGroups();
        public static IReadOnlyCollection<IEntity> GetAllEntities() => GetAllPlayers().Concat<IEntity>(GetAllVehicles()).Concat(GetAllLocalObjects()).Concat(GetAllWorldObjects()).ToList();

        public static void EmitServer(string eventName, params object[] args) => CoreImpl.TriggerServerEvent(eventName, args);
        public static void EmitServerUnreliable(string eventName, params object[] args) => CoreImpl.TriggerServerEventUnreliable(eventName, args);
        public static void EmitClient(string eventName, params object[] args) => CoreImpl.TriggerLocalEvent(eventName, args);

        public static ushort EmitRPC(string name, params object[] args) => CoreImpl.TriggerServerRPCEvent(name, args);
        public static void EmitRPCAnswer(ushort answerId, object answer, string error) => CoreImpl.TriggerServerRPCAnswer(answerId, answer, error);

        public static bool HasResource(string name) => CoreImpl.HasResource(name);
        public static INativeResource GetResource(string name) => CoreImpl.GetResource(name);
        public static INativeResource[] GetAllResources() => CoreImpl.GetAllResources();

        public static uint SetTimeout(Action action, uint duration, [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0) => CoreImpl.SetTimeout(action, duration, filePath, lineNumber);
        public static uint SetInterval(Action action, uint duration, [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0) => CoreImpl.SetInterval(action, duration, filePath, lineNumber);
        public static uint NextTick(Action action, [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0) => CoreImpl.NextTick(action, filePath, lineNumber);
        public static uint EveryTick(Action action, [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0) => CoreImpl.EveryTick(action, filePath, lineNumber);

        public static void ClearTimer(uint id) => CoreImpl.ClearTimer(id);
        public static void ClearTimeout(uint id) => ClearTimer(id);
        public static void ClearInterval(uint id) => ClearTimer(id);
        public static void ClearNextTick(uint id) => ClearTimer(id);
        public static void ClearEveryTick(uint id) => ClearTimer(id);

        public static bool FileExists(string path) => CoreImpl.FileExists(path);
        public static string ReadFile(string path) => CoreImpl.FileRead(path);
        public static byte[] ReadFileBinary(string path) => CoreImpl.FileReadBinary(path);
        public static Vector3 PedBonesPosition(int scriptId, ushort boneId) => CoreImpl.PedBonesPosition(scriptId, boneId);
        public static IBlip GetBlipByGameId(uint gameId) => CoreImpl.GetBlipByGameId(gameId);
        public static ICheckpoint GetCheckpointByGameID(uint gameId) => CoreImpl.GetCheckpointByGameID(gameId);
        public static bool IsWebViewGpuAccelerationActive => CoreImpl.IsWebViewGpuAccelerationActive;
        public static IWorldObject GetWorldObjectByScriptID(BaseObjectType type, uint scriptId) => CoreImpl.GetWorldObjectByScriptID(type, scriptId);
        public static VoiceConnectionState GetVoiceConnectionState() => CoreImpl.GetVoiceConnectionState();

        public static int NetTime => CoreImpl.NetTime;
    }
}