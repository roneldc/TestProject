using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task7
{
    public class Test7
    {
        public void ValidateDate(string date)
        {
            try
            {
                DateTime newDate = Convert.ToDateTime(date);
            }
            catch
            {
                throw new Exception($"Invalid input date: {date}");
            }
        }
    }
}