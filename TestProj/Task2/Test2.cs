using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task2
{
    public class Test2
    {
        public void InputNumber(int num)
        {
            System.Console.WriteLine("Input number:");
            if (num < 0 || num > 1000)
                throw new Exception("Invalid input number.");
        }
    }
}