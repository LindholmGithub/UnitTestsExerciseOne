using System;
using System.IO;

namespace GradeData
{
    public class Class1
    {
        
        public int ToGrade(int percentage)
        {
            if(percentage is >= 0 and <= 5)
            {
                return -3;
            }
            if(percentage is >= 6 and <= 49)
            {
                return 0;
            }
            if(percentage is >= 50 and <= 59)
            {
                return 2;
            }
            if(percentage is >= 60 and <= 79)
            {
                return 4;
            }
            if(percentage is >= 80 and <= 84)
            {
                return 7;
            }
            if(percentage is >= 85 and <= 94)
            {
                return 10;
            }
            if(percentage is >= 95 and <= 100)
            {
                return 12;
            }

            throw new InvalidDataException("Bad Data Input!");
        }
    }
}