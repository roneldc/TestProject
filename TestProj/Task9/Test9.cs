using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task9
{
    public class Test9
    {
        public string ConvertToUpper(string input)
        {
            if (!string.IsNullOrEmpty(input))
                throw new NullReferenceException("Input string is empty");

            return input.ToUpper();
        }
    }
}