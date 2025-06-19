using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Exercise1
{
    internal class FileLogger : ILogger
    {
        
        public void Log(string message)
        {
            Console.WriteLine($"File Logger: {message}");
        }
    }
}
