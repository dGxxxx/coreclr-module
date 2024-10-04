using AltV.Net.Data;

namespace AltV.Net.Client.Elements.Data;

public interface IInterior
{
    IInteriorRoom GetRoomByIndex(uint roomIndex);
    IInteriorRoom GetRoomByHash(uint roomHash);
    IInteriorPortal GetPortalByIndex(uint portalIndex);
    ushort RoomCount { get; }
    ushort PortalCount { get; }
    Position Position { get; }
    Rotation Rotation { get; }
    InteriorExtentInfo EntitiesExtents { get; }
}