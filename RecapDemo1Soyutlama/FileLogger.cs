using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemo1Soyutlama
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
}
