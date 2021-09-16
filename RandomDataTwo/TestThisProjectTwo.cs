using System;

namespace RandomDataTwo
{
    public class TestThisProjectTwo
    {
        private int noCloudBurst = -1;
        private int cloudBurstCounter = 0;
        public int ContainsCloudburst(double[] rain)
        {
            foreach (var entry in rain)
            {
                if (entry >= 20.0)
                {
                    cloudBurstCounter++;
                }
            }
            if (cloudBurstCounter != 0)
            {
                return cloudBurstCounter;
            }
            return noCloudBurst;
        }
    }
}