using AltV.Net.Data;

namespace AltV.Net.Client.Elements.Data;

public interface IInteriorRoom
{
    uint Index { get; }
    string Name { get; }
    uint NameHash { get; }
    int Flag { get; set; }
    uint Timecycle { get; set; }
    InteriorExtentInfo Extents { get; set; }
}