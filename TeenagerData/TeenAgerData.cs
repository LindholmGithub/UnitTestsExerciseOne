using System;
using System.IO;

namespace TeenagerData
{
    public class TeenAgerData
    {
        public bool IsTeenager(DateTime birthday)
        {
            var today = DateTime.Today;
            var age = today.Year - birthday.Year;
            if (age >= 0)
            {
                return age is >= 13 and <= 19;
            }
            throw new InvalidDataException("You Somehow Got the Birthday Wrong, Scrub");
        }
    }
}