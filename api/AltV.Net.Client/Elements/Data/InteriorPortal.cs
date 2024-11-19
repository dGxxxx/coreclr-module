using AltV.Net.Data;

namespace AltV.Net.Client.Elements.Data;

public class InteriorPortal : IInteriorPortal
{
    private readonly ICore _core;
    private readonly uint _interiorId;
    private readonly uint _portalIndex;

    public InteriorPortal(ICore core, uint interiorId, uint portalIndex)
    {
        _core = core;
        _interiorId = interiorId;
        _portalIndex = portalIndex;
    }

    public uint Index
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.InteriorPortal_GetIndex(_interiorId, _portalIndex);
            }
        }
    }

    public ushort CornerCount
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.InteriorPortal_GetCornerCount(_interiorId, _portalIndex);
            }
        }
    }

    public Position GetCornerPosition(uint cornerIndex)
    {
        unsafe
        {
            return _core.Library.Client.InteriorPortal_GetCornerPosition(_interiorId, _portalIndex, cornerIndex);
        }
    }

    public IInteriorRoom RoomFrom
    {
        get
        {
            unsafe
            {
                var roomFrom = _core.Library.Client.InteriorPortal_GetRoomFrom(_interiorId, _portalIndex);
                return new InteriorRoom(_core, _interiorId, roomFrom, true);
            }
        }
        set
        {
            unsafe
            {
                _core.Library.Client.InteriorPortal_SetRoomFrom(_interiorId, _portalIndex, value.Index);
            }
        }
    }

    public IInteriorRoom RoomTo
    {
        get
        {
            unsafe
            {
                var roomtTo = _core.Library.Client.InteriorPortal_GetRoomTo(_interiorId, _portalIndex);
                return new InteriorRoom(_core, _interiorId, roomtTo, true);
            }
        }
        set
        {
            unsafe
            {
                _core.Library.Client.InteriorPortal_SetRoomTo(_interiorId, _portalIndex, value.Index);
            }
        }
    }

    public int Flag
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.InteriorPortal_GetFlag(_interiorId, _portalIndex);
            }
        }
        set
        {
            unsafe
            {
                _core.Library.Client.InteriorPortal_SetFlag(_interiorId, _portalIndex, value);
            }
        }
    }

    public ushort EntityCount
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.InteriorPortal_GetEntityCount(_interiorId, _portalIndex);
            }
        }
    }

    public uint GetEntityArcheType(uint entityIndex)
    {
        unsafe
        {
            return _core.Library.Client.InteriorPortal_GetEntityArcheType(_interiorId, _portalIndex, entityIndex);
        }
    }

    public int GetEntityFlag(uint entityIndex)
    {
        unsafe
        {
            return _core.Library.Client.InteriorPortal_GetEntityFlag(_interiorId, _portalIndex, entityIndex);
        }
    }

    public void SetEntityFlag(uint entityIndex, int flag)
    {
        unsafe
        {
            _core.Library.Client.InteriorPortal_SetEntityFlag(_interiorId, _portalIndex, entityIndex, flag);
        }
    }

    public Position GetEntityPosition(uint entityIndex)
    {
        unsafe
        {
            return _core.Library.Client.InteriorPortal_GetEntityPosition(_interiorId, _portalIndex, entityIndex);
        }
    }

    public Rotation GetEntityRotation(uint entityIndex)
    {
        unsafe
        {
            return _core.Library.Client.InteriorPortal_GetEntityRotation(_interiorId, _portalIndex, entityIndex);
        }
    }

    public void SetCornerPosition(uint cornerIndex, Position position)
    {
        unsafe
        {
            _core.Library.Client.InteriorPortal_SetCornerPosition(_interiorId, _portalIndex, cornerIndex, position);
        }
    }
}