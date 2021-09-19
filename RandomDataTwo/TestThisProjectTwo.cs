using System;

namespace RandomDataTwo
{
    public class TestThisProjectTwo
    {
        private const int NoCloudBurst = -1;
        private const double CloudBurstLimit = 20.0;
        private int cloudBurstCounter = 0;
        public int ContainsCloudburst(double[] rain)
        {
            foreach (var miliRain in rain)
            {
                if (miliRain >= CloudBurstLimit)
                {
                    return Array.IndexOf(rain, miliRain)+1;
                }
            }
            return NoCloudBurst;
        }
    }
}