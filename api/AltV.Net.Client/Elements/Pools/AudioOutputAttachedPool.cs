using AltV.Net.Client.Elements.Interfaces;

namespace AltV.Net.Client.Elements.Pools
{
    public class AudioOutputAttachedPool : BaseObjectPool<IAudioOutputAttached>
    {
        public AudioOutputAttachedPool(IBaseObjectFactory<IAudioOutputAttached> factory) : base(factory)
        {
        }

        public override uint GetId(IntPtr entityPointer)
        {
            unsafe
            {
                return Alt.CoreImpl.Library.Shared.AudioAttachedOutput_GetID(entityPointer);
            }
        }
    }
}