using System;

namespace SIM_4K4_2023_G2_TP5.Logic
{
    public static class DoubleUtils
    {
        public static double RandomNumber()
        {
            Random _rnd = new(Guid.NewGuid().GetHashCode());
            return _rnd.NextDouble();
        }
        public static double TruncateNumber(double number)
        {
            return (double)Math.Truncate((decimal)number * 10000) / 10000.0d;
        }
    }
}
