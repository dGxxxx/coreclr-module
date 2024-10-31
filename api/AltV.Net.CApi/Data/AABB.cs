using System.Runtime.InteropServices;

namespace AltV.Net.Data
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AABB : IEquatable<AABB>
    {
        public static AABB Zero = new AABB(Position.Zero, Position.Zero);
        
        public Position Min;
        public Position Max;

        public AABB(Position min, Position max)
        {
            Min = min;
            Max = max;
        }

        public override string ToString()
        {
            return $"AABB(min: {Min}, max: {Max})";
        }

        public override bool Equals(object obj)
        {
            return obj is AABB other && Equals(other);
        }

        public bool Equals(AABB other)
        {
            return Min.Equals(other.Min) && Max.Equals(other.Max);
        }

        public override int GetHashCode() => HashCode.Combine(Min.GetHashCode(), Max.GetHashCode());
    }
}