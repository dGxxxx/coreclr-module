using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AltV.Net.Elements.Entities;
using AltV.Net.Elements.Pools;

namespace AltV.Net;

public partial class Alt
{
    public static void AddToPool(IBaseObject baseObject) => CoreImpl.PoolManager.Add(baseObject);

    public static IReadOnlyCollection<IPlayer> GetAllPlayers() => CoreImpl.PoolManager.Player.GetAllEntities();

    public static IReadOnlyCollection<IVehicle> GetAllVehicles() => CoreImpl.PoolManager.Vehicle.GetAllEntities();

    public static IReadOnlyCollection<IPed> GetAllPeds() => CoreImpl.PoolManager.Ped.GetAllEntities();

    public static IReadOnlyCollection<IBlip> GetAllBlips() => CoreImpl.PoolManager.Blip.GetAllObjects();

    public static IReadOnlyCollection<IObject> GetAllNetworkObjects() => CoreImpl.PoolManager.Object.GetAllEntities();

    public static IReadOnlyCollection<ICheckpoint> GetAllCheckpoints() =>
        CoreImpl.PoolManager.Checkpoint.GetAllObjects();

    public static IReadOnlyCollection<IVoiceChannel> GetAllVoiceChannels() =>
        CoreImpl.PoolManager.VoiceChannel.GetAllObjects();

    public static IReadOnlyCollection<IColShape> GetAllColShapes() => CoreImpl.PoolManager.ColShape.GetAllObjects();

    public static IReadOnlyCollection<IMarker> GetAllMarkers() => CoreImpl.PoolManager.Marker.GetAllObjects();

    public static IReadOnlyCollection<IConnectionInfo> GetAllConnectionInfos() =>
        CoreImpl.PoolManager.ConnectionInfo.GetAllObjects();

    public static IReadOnlyCollection<IVirtualEntity> GetAllVirtualEntities() =>
        CoreImpl.PoolManager.VirtualEntity.GetAllObjects();

    public static IReadOnlyCollection<IVirtualEntityGroup> GetAllVirtualEntityGroups() =>
        CoreImpl.PoolManager.VirtualEntityGroup.GetAllObjects();

    public static KeyValuePair<IntPtr, IPlayer>[] GetPlayersArray() => CoreImpl.PoolManager.Player.GetEntitiesArray();

    public static KeyValuePair<IntPtr, IVehicle>[] GetVehiclesArray() =>
        CoreImpl.PoolManager.Vehicle.GetEntitiesArray();

    public static KeyValuePair<IntPtr, IPed>[] GetPedsArray() => CoreImpl.PoolManager.Ped.GetEntitiesArray();

    public static KeyValuePair<IntPtr, IBlip>[] GetBlipsArray() => CoreImpl.PoolManager.Blip.GetObjectsArray();

    public static KeyValuePair<IntPtr, ICheckpoint>[] GetCheckpointsArray() =>
        CoreImpl.PoolManager.Checkpoint.GetObjectsArray();

    public static KeyValuePair<IntPtr, IVoiceChannel>[] GetVoiceChannelsArray() =>
        CoreImpl.PoolManager.VoiceChannel.GetObjectsArray();

    public static KeyValuePair<IntPtr, IColShape>[] GetColShapesArray() =>
        CoreImpl.PoolManager.ColShape.GetObjectsArray();

    public static KeyValuePair<IntPtr, IConnectionInfo>[] GetConnectionInfoArray() =>
        CoreImpl.PoolManager.ConnectionInfo.GetObjectsArray();

    public static void ForEachPlayers(IBaseObjectCallback<IPlayer> baseObjectCallback) =>
        CoreImpl.PoolManager.Player.ForEach(baseObjectCallback);

    public static Task ForEachPlayers(IAsyncBaseObjectCallback<IPlayer> baseObjectCallback) =>
        CoreImpl.PoolManager.Player.ForEach(baseObjectCallback);

    public static void ForEachVehicles(IBaseObjectCallback<IVehicle> baseObjectCallback) =>
        CoreImpl.PoolManager.Vehicle.ForEach(baseObjectCallback);

    public static Task ForEachVehicles(IAsyncBaseObjectCallback<IVehicle> baseObjectCallback) =>
        CoreImpl.PoolManager.Vehicle.ForEach(baseObjectCallback);

    public static void ForEachPeds(IBaseObjectCallback<IPed> baseObjectCallback) =>
        CoreImpl.PoolManager.Ped.ForEach(baseObjectCallback);

    public static Task ForEachPeds(IAsyncBaseObjectCallback<IPed> baseObjectCallback) =>
        CoreImpl.PoolManager.Ped.ForEach(baseObjectCallback);

    public static void ForEachBlips(IBaseObjectCallback<IBlip> baseObjectCallback) =>
        CoreImpl.PoolManager.Blip.ForEach(baseObjectCallback);

    public static Task ForEachBlips(IAsyncBaseObjectCallback<IBlip> baseObjectCallback) =>
        CoreImpl.PoolManager.Blip.ForEach(baseObjectCallback);

    public static void ForEachCheckpoints(IBaseObjectCallback<ICheckpoint> baseObjectCallback) =>
        CoreImpl.PoolManager.Checkpoint.ForEach(baseObjectCallback);

    public static Task ForEachCheckpoints(IAsyncBaseObjectCallback<ICheckpoint> baseObjectCallback) =>
        CoreImpl.PoolManager.Checkpoint.ForEach(baseObjectCallback);

    public static void ForEachVoiceChannels(IBaseObjectCallback<IVoiceChannel> baseObjectCallback) =>
        CoreImpl.PoolManager.VoiceChannel.ForEach(baseObjectCallback);

    public static Task ForEachVoiceChannels(IAsyncBaseObjectCallback<IVoiceChannel> baseObjectCallback) =>
        CoreImpl.PoolManager.VoiceChannel.ForEach(baseObjectCallback);

    public static void ForEachColShapes(IBaseObjectCallback<IColShape> baseObjectCallback) =>
        CoreImpl.PoolManager.ColShape.ForEach(baseObjectCallback);

    public static Task ForEachColShapes(IAsyncBaseObjectCallback<IColShape> baseObjectCallback) =>
        CoreImpl.PoolManager.ColShape.ForEach(baseObjectCallback);
}