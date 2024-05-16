using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task10
{
    public class Test10
    {
        public int CalculateFactorial(int input)
        {
            int num = input * CalculateFactorial(input - 1);
            if (num > Int32.MaxValue)
                throw new OverflowException($"Factorial result exceed maximum value. Value: {num}");

            return num;
        }
    }
}