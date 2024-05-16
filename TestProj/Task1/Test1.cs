using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProj.Task1
{
    public class Test1
    {
        public void OpenFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new Exception("File does not exist");

            File.Open(filePath, FileMode.Open);
        }
    }
}