using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task6
{
    public class Test9
    {
        public double ValidateDenominator(int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Denominator value cannot be zero.");

            return num1 / num2;
        }
    }
}