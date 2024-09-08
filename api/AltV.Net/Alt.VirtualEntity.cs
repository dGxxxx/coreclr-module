using System.Collections.Generic;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace AltV.Net;

public partial class Alt
{
    public static IVirtualEntityGroup CreateVirtualEntityGroup(uint maxEntitiesInStream) =>
        CoreImpl.CreateVirtualEntityGroup(maxEntitiesInStream);

    public static IVirtualEntity CreateVirtualEntity(IVirtualEntityGroup group, Position position,
        uint streamingDistance, Dictionary<string, object> dataDict) =>
        CoreImpl.CreateVirtualEntity(group, position, streamingDistance, dataDict);
}
