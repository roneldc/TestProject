using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task4
{
    public class Test4
    {
        public int ConvertToInt(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch
            {
                throw new Exception("Cannot convert to string");
            }

        }
    }
}