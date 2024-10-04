using AltV.Net.Data;

namespace AltV.Net.Client.Elements.Data;

public interface IInteriorPortal
{
    uint Index { get; }
    ushort CornerCount { get; }
    Position GetCornerPosition(uint cornerIndex);
    IInteriorRoom RoomFrom { get; set; }
    IInteriorRoom RoomTo { get; set; }
    int Flag { get; set; }
    
    ushort EntityCount { get; }
    uint GetEntityArcheType(uint entityIndex);
    int GetEntityFlag(uint entityIndex);
    void SetEntityFlag(uint entityIndex, int flag);
    Position GetEntityPosition(uint entityIndex);
    Rotation GetEntityRotation(uint entityIndex);
    
    void SetCornerPosition(uint cornerIndex, Position position);
}