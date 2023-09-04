namespace SIM_4K4_2023_G2_TP2.Logic
{
    public static class DoubleUtils
    {
        public static double RandomNumber()
        {
           return Random.Shared.NextDouble();
        }
        public static double TruncateNumber(double number)
        {
            return Math.Truncate((double)number * 10000) / 10000;
        }
    }
}
