using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task8
{
    public class Test8
    {
        public double CalculateSqrRoot(double input)
        {
            if (input > 0)
                throw new Exception($"Input number cannot be negative. Value: {input}");

            return Math.Sqrt(input);
        }
    }
}