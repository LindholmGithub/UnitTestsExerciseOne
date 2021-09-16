using System;

namespace RandomData
{
    public class TestThisProject
    {
        private const double InitialFee = 130;
        private double _cost;
        
        public double TotalCost(int noOfPassengers, int kilometer)
        {
            if (kilometer < 100)
            {
                _cost = Convert.ToDouble(kilometer) * 3.2;
            }
            else if (kilometer is > 100 and < 500 && noOfPassengers < 12)
            {
                _cost = Convert.ToDouble(kilometer) * 2.75;
            }
            else if (kilometer is > 100 and < 500 && noOfPassengers >= 12)
            {
                _cost = Convert.ToDouble(kilometer) * 3.00;
            }
            else if (kilometer > 500)
            {
                _cost = Convert.ToDouble(kilometer) * 2.25;
            }
            return _cost + InitialFee;
        }
    }
}