using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace AltV.Net
{
    public partial class Alt
    {
        public static IPed CreatePed(uint model, Position pos, Rotation rot, uint streamingDistance = 0) =>
            CoreImpl.CreatePed(model, pos, rot, streamingDistance);

        public static IPed CreatePed(PedModel model, Position pos, Rotation rot, uint streamingDistance = 0) =>
            CoreImpl.CreatePed((uint)model, pos, rot, streamingDistance);

        public static IPed CreatePed(string model, Position pos, Rotation rot, uint streamingDistance = 0) =>
            CoreImpl.CreatePed(CoreImpl.Hash(model), pos, rot, streamingDistance);
    }
}