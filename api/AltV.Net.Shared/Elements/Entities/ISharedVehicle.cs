namespace AltV.Net.Shared.Elements.Entities
{
    public interface ISharedVehicle : ISharedEntity
    {
        IntPtr VehicleNativePointer { get; }

        /// <summary>
        /// Amount of Wheels
        /// </summary>
        byte WheelsCount { get; }

        /// <summary>
        /// Fuel Tank Health
        /// </summary>
        int PetrolTankHealth { get; }

        float SteeringAngle { get; }
        
        float GetWheelCamber(byte wheel);
        void SetWheelCamber(byte wheel, float value);
        float GetWheelTrackWidth(byte wheel);
        void SetWheelTrackWidth(byte wheel, float value);
        float GetWheelHeight(byte wheel);
        void SetWheelHeight(byte wheel, float value);
        float GetWheelTyreRadius(byte wheel);
        void SetWheelTyreRadius(byte wheel, float value);
        float GetWheelRimRadius(byte wheel);
        void SetWheelRimRadius(byte wheel, float value);
        float GetWheelTyreWidth(byte wheel);
        void SetWheelTyreWidth(byte wheel, float value);
    }
}