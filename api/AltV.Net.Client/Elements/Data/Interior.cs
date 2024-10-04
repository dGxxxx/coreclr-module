using AltV.Net.Data;

namespace AltV.Net.Client.Elements.Data;

public class Interior : IInterior
{
    private readonly ICore _core;
    private readonly uint _interiorId;

    internal Interior(ICore core, uint interiorId)
    {
        _core = core;
        _interiorId = interiorId;
    }

    public IInteriorRoom GetRoomByIndex(uint roomIndex)
    {
        return new InteriorRoom(_core, _interiorId, roomIndex, true);
    }

    public IInteriorRoom GetRoomByHash(uint roomHash)
    {
        return new InteriorRoom(_core, _interiorId, roomHash, false);
    }

    public IInteriorPortal GetPortalByIndex(uint portalIndex)
    {
        return new InteriorPortal(_core, _interiorId, portalIndex);
    }

    public ushort RoomCount
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.Interior_GetRoomCount(_interiorId);
            }
        }
    }

    public ushort PortalCount
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.Interior_GetPortalCount(_interiorId);
            }
        }
    }

    public Position Position
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.Interior_GetPosition(_interiorId);
            }
        }
    }

    public Rotation Rotation
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.Interior_GetPosition(_interiorId);
            }
        }
    }

    public InteriorExtentInfo EntitiesExtents
    {
        get
        {
            unsafe
            {
                var interiorExtentInfo = InteriorExtentInfo.Zero;
                _core.Library.Client.Interior_GetEntitiesExtents(_interiorId, &interiorExtentInfo);
                return interiorExtentInfo;
            }
        }
    }
}