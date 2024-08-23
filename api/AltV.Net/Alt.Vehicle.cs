using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace AltV.Net
{
    public partial class Alt
    {
        public static IVehicle CreateVehicle(uint model, Position pos, Rotation rotation, uint streamingDistance = 0) =>
            CoreImpl.CreateVehicle(model, pos, rotation, streamingDistance);

        public static IVehicle CreateVehicle(VehicleModel model, Position pos, Rotation rotation, uint streamingDistance = 0) =>
            CoreImpl.CreateVehicle((uint) model, pos, rotation, streamingDistance);

        public static IVehicle CreateVehicle(string model, Position pos, Rotation rotation, uint streamingDistance = 0) =>
            CoreImpl.CreateVehicle(CoreImpl.Hash(model), pos, rotation, streamingDistance);
    }
}