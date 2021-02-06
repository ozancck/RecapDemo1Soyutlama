using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemo1Soyutlama
{
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }
}
