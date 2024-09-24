using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Elements.Pools;
using AltV.Net.Shared;
using AltV.Net.Shared.Elements.Data;

[assembly: InternalsVisibleTo("AltV.Net")]
[assembly: InternalsVisibleTo("AltV.Net.Mock")]
[assembly: InternalsVisibleTo("AltV.Net.Mock2")]
[assembly: InternalsVisibleTo("AltV.Net.Async")]

namespace AltV.Net
{
    public static partial class Alt
    {
        internal static ICore CoreImpl;

        public static bool CacheEntities { get => AltShared.CacheEntities; set => AltShared.CacheEntities = value; }
        public static bool ThrowIfEntityDoesNotExist = false;

        public static bool IsDebug => CoreImpl.IsDebug;

        public static void Emit(string eventName, params object[] args) => CoreImpl.TriggerLocalEvent(eventName, args);

        public static void EmitAllClients(string eventName, params object[] args) =>
            CoreImpl.TriggerClientEventForAll(eventName, args);

        public static void EmitClients(IPlayer[] clients, string eventName, params object[] args) =>
            CoreImpl.TriggerClientEventForSome(clients, eventName, args);

        public static void EmitEventUnreliableAllClients(string eventName, params object[] args) =>
            CoreImpl.TriggerClientEventUnreliableForAll(eventName, args);

        public static void EmitUnreliableClients(IPlayer[] clients, string eventName, params object[] args) =>
            CoreImpl.TriggerClientEventUnreliableForSome(clients, eventName, args);

        public static IEnumerable<string> GetRegisteredClientEvents() => CoreImpl.GetRegisteredClientEvents();
        public static IEnumerable<string> GetRegisteredServerEvents() => CoreImpl.GetRegisteredServerEvents();

        /// <summary>
        /// Logging a message
        /// </summary>
        /// <param name="message">a message</param>
        public static void Log(string message) => CoreImpl.LogInfo(message);

        public static VehicleModelInfo GetVehicleModelInfo(uint hash) => CoreImpl.GetVehicleModelInfo(hash);
        public static VehicleModelInfo GetVehicleModelInfo(string name) => CoreImpl.GetVehicleModelInfo(Hash(name));
        public static PedModelInfo? GetPedModelInfo(uint hash) => CoreImpl.GetPedModelInfo(hash);
        public static PedModelInfo? GetPedModelInfo(string name) => CoreImpl.GetPedModelInfo(Hash(name));

        public static uint Hash(string stringToHash) => CoreImpl.Hash(stringToHash);
        public static ulong HashPassword(string password) => CoreImpl.HashPassword(password);

        public static bool FileExists(string path) => CoreImpl.FileExists(path);
        public static string ReadFile(string path) => CoreImpl.FileRead(path);
        public static byte[] ReadFileBinary(string path) => CoreImpl.FileReadBinary(path);

        public static IConfig GetServerConfig() => CoreImpl.GetServerConfig();
        public static IBaseObject GetBaseObjectById(BaseObjectType type, uint id) => CoreImpl.GetBaseObjectById(type, id);

        public static IMetric RegisterMetric(string name, MetricType type = MetricType.MetricTypeGauge, Dictionary<string, string> dataDict = default) => CoreImpl.RegisterMetric(name, type, dataDict);
        public static void UnregisterMetric(IMetric metric) => CoreImpl.UnregisterMetric(metric);
        public static IReadOnlyCollection<IMetric> GetAllMetrics() => CoreImpl.GetAllMetrics();
        public static VoiceConnectionState GetVoiceConnectionState() => CoreImpl.GetVoiceConnectionState();

        public static void SetWorldProfiler(bool state) => CoreImpl.SetWorldProfiler(state);

        public static IBaseObject[] GetClosestEntities(Position position, int range, int dimension, int limit, EntityType allowedTypes, Order order = Order.Default) =>
            CoreImpl.GetClosestEntities(position, range, dimension, limit, allowedTypes, order);

        public static IBaseObject[] GetEntitiesInDimension(int dimension, EntityType allowedTypes) =>  CoreImpl.GetEntitiesInDimension(dimension, allowedTypes);

        public static IBaseObject[] GetEntitiesInRange(Position position, int range, int dimension, EntityType allowedTypes) => CoreImpl.GetEntitiesInRange(position, range, dimension, allowedTypes);

        public static int NetTime => CoreImpl.NetTime;

        public static void AddClientConfigKey(string key) => CoreImpl.AddClientConfigKey(key);

        public static ushort MaxStreamingPeds
        {
            get => CoreImpl.MaxStreamingPeds;
            set => CoreImpl.MaxStreamingPeds = value;
        }

        public static ushort MaxStreamingObjects
        {
            get => CoreImpl.MaxStreamingObjects;
            set => CoreImpl.MaxStreamingObjects = value;
        }
        public static ushort MaxStreamingVehicles
        {
            get => CoreImpl.MaxStreamingVehicles;
            set => CoreImpl.MaxStreamingVehicles = value;
        }
        public static byte StreamerThreadCount
        {
            get => CoreImpl.StreamerThreadCount;
            set => CoreImpl.StreamerThreadCount = value;
        }
        public static uint StreamingTickRate
        {
            get => CoreImpl.StreamingTickRate;
            set => CoreImpl.StreamingTickRate = value;
        }
        public static uint StreamingDistance
        {
            get => CoreImpl.StreamingDistance;
            set => CoreImpl.StreamingDistance = value;
        }
        public static uint ColShapeTickRate
        {
            get => CoreImpl.ColShapeTickRate;
            set => CoreImpl.ColShapeTickRate = value;
        }
        public static uint MigrationDistance
        {
            get => CoreImpl.MigrationDistance;
            set => CoreImpl.MigrationDistance = value;
        }
        public static byte MigrationThreadCount
        {
            get => CoreImpl.MigrationThreadCount;
            set => CoreImpl.MigrationThreadCount = value;
        }
        public static uint MigrationTickRate
        {
            get => CoreImpl.MigrationTickRate;
            set => CoreImpl.MigrationTickRate = value;
        }
        public static byte SyncReceiveThreadCount
        {
            get => CoreImpl.SyncReceiveThreadCount;
            set => CoreImpl.SyncReceiveThreadCount = value;
        }
        public static byte SyncSendThreadCount
        {
            get => CoreImpl.SyncSendThreadCount;
            set => CoreImpl.SyncSendThreadCount = value;
        }

        public static bool HasBenefit(Benefit benefit) => CoreImpl.HasBenefit(benefit);

        public static void StopServer() => CoreImpl.StopServer();
        public static WeaponModelInfo? GetWeaponModelInfo(uint hash) => CoreImpl.GetWeaponModelInfo(hash);

        public static void SetPassword(string password) => CoreImpl.SetPassword(password);
        public static void SetVoiceExternal(string host, ushort port) => CoreImpl.SetVoiceExternal(host, port);
        public static void SetVoiceExternalPublic(string host, ushort port) => CoreImpl.SetVoiceExternalPublic(host, port);

        public static string Branch => CoreImpl.Branch;
        public static string Version => CoreImpl.Version;
        public static bool IsMainThread => CoreImpl.IsMainThread();
    }
}