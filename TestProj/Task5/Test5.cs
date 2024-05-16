using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task5
{
    public class Test5
    {
        public void ValidateList(List<int> numbers)
        {
            foreach (var num in numbers)
            {
                if (num > Int32.MaxValue)
                    throw new Exception($"{num} exceeds maximum value.");
            }
        }
    }
}