using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemo1Soyutlama
{
    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }
}
