using AltV.Net.Elements.Entities;

namespace AltV.Net;

public partial class Alt
{
    public static IPlayer GetPlayerById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.Player, id) as IPlayer;
    public static IVehicle GetVehicleById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.Vehicle, id) as IVehicle;
    public static IPed GetPedById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.Ped, id) as IPed;
    public static IBlip GetBlipById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.Blip, id) as IBlip;
    public static IVoiceChannel GetVoiceChannelById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.VoiceChannel, id) as IVoiceChannel;
    public static IColShape GetColShapeById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.ColShape, id) as IColShape;
    public static ICheckpoint GetCheckpointById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.Checkpoint, id) as ICheckpoint;
    public static IVirtualEntity GetVirtualEntityById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.VirtualEntity, id) as IVirtualEntity;
    public static IVirtualEntityGroup GetVirtualEntityGroupById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.VirtualEntityGroup, id) as IVirtualEntityGroup;
    public static IMarker GetMarkerById(uint id) => CoreImpl.GetBaseObject(BaseObjectType.Marker, id) as IMarker;
}