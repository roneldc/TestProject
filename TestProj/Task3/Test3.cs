using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task3
{
    public class Test3
    {
        public double CalculateAverage(int[] array)
        {
            if (array.Length < 0)
                throw new Exception("Array input is empty");

            return array.Average();
        }
    }
}