using AltV.Net.Client.Elements.Interfaces;

namespace AltV.Net.Client.Elements.Pools
{
    public class VirtualEntityGroupPool : BaseObjectPool<IVirtualEntityGroup>
    {
        public VirtualEntityGroupPool(IBaseObjectFactory<IVirtualEntityGroup> virtualEntityGroupFactory) : base(virtualEntityGroupFactory)
        {
        }

        public override uint GetId(IntPtr entityPointer)
        {
            unsafe
            {
                return Alt.CoreImpl.Library.Shared.VirtualEntity_GetID(entityPointer);
            }
        }
    }
}