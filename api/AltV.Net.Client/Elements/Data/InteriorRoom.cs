using AltV.Net.Data;

namespace AltV.Net.Client.Elements.Data;

public class InteriorRoom : IInteriorRoom
{
    private readonly ICore _core;
    private readonly uint _interiorId;
    private readonly uint _roomValue;
    private readonly byte _isIndex;

    internal InteriorRoom(ICore core, uint interiorId, uint roomValue, bool isIndex)
    {
        _core = core;
        _interiorId = interiorId;
        _roomValue = roomValue;
        _isIndex = isIndex ? (byte) 1 : (byte) 0;
    }

    public uint Index
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.InteriorRoom_GetIndex(_interiorId, _roomValue, _isIndex);
            }
        }
    }

    public string Name
    {
        get
        {
            unsafe
            {
                var size = 0;
                return _core.PtrToStringUtf8AndFree(
                    _core.Library.Client.InteriorRoom_GetName(_interiorId, _roomValue, _isIndex, &size), size);   
            }
        }
    }

    public uint NameHash
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.InteriorRoom_GetNameHash(_interiorId, _roomValue, _isIndex);
            }
        }
    }

    public int Flag
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.InteriorRoom_GetFlag(_interiorId, _roomValue, _isIndex);
            }
        }
        set
        {
            unsafe
            {
                _core.Library.Client.InteriorRoom_SetFlag(_interiorId, _roomValue, _isIndex, value);
            }
        }
    }

    public uint Timecycle
    {
        get
        {
            unsafe
            {
                return _core.Library.Client.InteriorRoom_GetTimecycle(_interiorId, _roomValue, _isIndex);
            }
        }
        set
        {
            unsafe
            {
                _core.Library.Client.InteriorRoom_SetTimecycle(_interiorId, _roomValue, _isIndex, value);
            }
        }
    }

    public InteriorExtentInfo Extents
    {
        get
        {
            unsafe
            {
                var interiorExtentInfo = InteriorExtentInfo.Zero;
                _core.Library.Client.InteriorRoom_GetExtents(_interiorId, _roomValue, _isIndex, &interiorExtentInfo);
                return interiorExtentInfo;
            }
        }
        set
        {
            unsafe
            {
                _core.Library.Client.InteriorRoom_SetExtents(_interiorId, _roomValue, _isIndex, value.Min, value.Max);
            }
        }
    }
}