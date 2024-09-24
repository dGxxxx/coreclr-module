using System.Numerics;
using AltV.Net.Client.Elements.Entities;
using AltV.Net.Client.Elements.Interfaces;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Shared.Enums;

namespace AltV.Net.Client
{
    public partial class Alt
    {
        public static IBlip CreatePointBlip(Position position) => CoreImpl.CreatePointBlip(position);
        public static IBlip CreateRadiusBlip(Position position, float radius) => CoreImpl.CreateRadiusBlip(position, radius);
        public static IBlip CreateAreaBlip(Position position, int width, int height) => CoreImpl.CreateAreaBlip(position, width, height);
        public static IWebView CreateWebView(string url, bool isOverlay = false, Vector2? pos = null, Vector2? size = null) => CoreImpl.CreateWebView(url, isOverlay, pos, size);
        public static IWebView CreateWebView(string url, uint propHash, string targetTexture) => CoreImpl.CreateWebView(url, propHash, targetTexture);
        public static IRmlDocument CreateRmlDocument(string url) => CoreImpl.CreateRmlDocument(url);
        public static IAudio CreateAudio(string source, float volume, bool isRadio = false, bool clearCache = true, string basePath = "") => CoreImpl.CreateAudio(source, volume, isRadio, clearCache, basePath);
        public static IAudioFilter CreateAudioFilter(uint hash) => CoreImpl.CreateAudioFilter(hash);
        public static IAudioOutputFrontend CreateAudioOutputFrontend(uint categoryHash) => CoreImpl.CreateAudioOutputFrontend(categoryHash);
        public static IAudioOutputWorld CreateAudioOutputWorld(uint categoryHash, Position pos) => CoreImpl.CreateAudioOutputWorld(categoryHash, pos);
        public static IAudioOutputAttached CreateAudioOutputAttached(uint categoryHash, IWorldObject worldObject) => CoreImpl.CreateAudioOutputAttached(categoryHash, worldObject);
        public static ILocalObject CreateLocalObject(uint modelHash, Position position, Rotation rotation, bool noOffset = false, bool dynamic = false, bool useStreaming = false, uint streamingDistance = 0) => CoreImpl.CreateLocalObject(modelHash, position, rotation, noOffset, dynamic, useStreaming, streamingDistance);
        public static IHttpClient CreateHttpClient() => CoreImpl.CreateHttpClient();
        public static IWebSocketClient CreateWebSocketClient(string url) => CoreImpl.CreateWebSocketClient(url);
        public static ICheckpoint CreateCheckpoint(CheckpointType type, Vector3 pos, Vector3 nextPos, float radius,
            float height, Rgba color, Rgba iconColor, uint streamingDistance) => CoreImpl.CreateCheckpoint(type, pos, nextPos, radius, height, color, iconColor, streamingDistance);

        public static IVirtualEntityGroup CreateVirtualEntityGroup(uint streamingDistance) => CoreImpl.CreateVirtualEntityGroup(streamingDistance);

        public static IVirtualEntity CreateVirtualEntity(IVirtualEntityGroup group, Position position,
            uint streamingDistance, Dictionary<string, object> dataDict) => CoreImpl.CreateVirtualEntity(group, position, streamingDistance, dataDict);

        public static ILocalPed CreateLocalPed(uint modelHash, int dimension, Position position, Rotation rotation,
            bool useStreaming, uint streamingDistance) =>
            CoreImpl.CreateLocalPed(modelHash, dimension, position, rotation, useStreaming, streamingDistance);

        public static ILocalPed CreateLocalPed(PedModel modelHash, int dimension, Position position, Rotation rotation,
            bool useStreaming, uint streamingDistance) =>
            CoreImpl.CreateLocalPed((uint)modelHash, dimension, position, rotation, useStreaming, streamingDistance);

        public static ILocalVehicle CreateLocalVehicle(uint modelHash, int dimension, Position position, Rotation rotation, bool useStreaming, uint streamingDistance) =>
            CoreImpl.CreateLocalVehicle(modelHash, dimension, position, rotation, useStreaming, streamingDistance);

        public static ILocalVehicle CreateLocalVehicle(VehicleModel modelHash, int dimension, Position position, Rotation rotation, bool useStreaming, uint streamingDistance) =>
            CoreImpl.CreateLocalVehicle((uint)modelHash, dimension, position, rotation, useStreaming, streamingDistance);

        public static IMarker CreateMarker(MarkerType type, Position pos, Rgba color, bool useStreaming,
            uint streamingDistance) => CoreImpl.CreateMarker(type, pos, color, useStreaming, streamingDistance);

        public static ITextLabel CreateTextLabel(string name, string fontName, float fontSize, float scale,
            Position pos,
            Rotation rot, Rgba color, float outlineWidth, Rgba outlineColor, bool useStreaming,
            uint streamingDistance) => CoreImpl.CreateTextLabel(name, fontName, fontSize, scale, pos,
            rot, color, outlineWidth, outlineColor, useStreaming, streamingDistance);

        public static IColShape CreateColShapeCircle(Position position, float radius) => CoreImpl.CreateColShapeCircle(position, radius);
        public static IColShape CreateColShapeCube(Position pos1, Position pos2) => CoreImpl.CreateColShapeCube(pos1, pos2);
        public static IColShape CreateColShapeCylinder(Position position, float radius, float height) => CoreImpl.CreateColShapeCylinder(position, radius, height);
        public static IColShape CreateColShapePolygon(float minZ, float maxZ, Vector2[] points) => CoreImpl.CreateColShapePolygon(minZ, maxZ, points);
        public static IColShape CreateColShapeRectangle(float x1, float y1, float x2, float y2, float z) => CoreImpl.CreateColShapeRectangle(x1, y1, x2, y2, z);
        public static IColShape CreateColShapeSphere(Vector3 position, float radius) => CoreImpl.CreateColShapeSphere(position, radius);
    }
}