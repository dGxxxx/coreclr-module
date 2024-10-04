using System;
using System.Runtime.InteropServices;

namespace AltV.Net.Data
{
    [StructLayout(LayoutKind.Sequential)]
    public struct InteriorExtentInfo : IEquatable<InteriorExtentInfo>
    {
        public static InteriorExtentInfo Zero = new InteriorExtentInfo(Position.Zero, Position.Zero);
        
        public Position Min;
        public Position Max;

        public InteriorExtentInfo(Position min, Position max)
        {
            Min = min;
            Max = max;
        }

        public override string ToString()
        {
            return $"InteriorExtentInfo(min: {Min}, max: {Max})";
        }

        public override bool Equals(object obj)
        {
            return obj is InteriorExtentInfo other && Equals(other);
        }

        public bool Equals(InteriorExtentInfo other)
        {
            return Min.Equals(other.Min) && Max.Equals(other.Max);
        }

        public override int GetHashCode() => HashCode.Combine(Min.GetHashCode(), Max.GetHashCode());
    }
}