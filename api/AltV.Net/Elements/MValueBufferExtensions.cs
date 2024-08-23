using AltV.Net.Elements.Args;

namespace AltV.Net.Elements
{
    public static class MValueBufferExtensions
    {
        public static MValueBuffer2 Reader(this MValueConst[] array)
        {
            return new MValueBuffer2(Alt.CoreImpl, array); // todo remove Alt.Core
        }
    }
}