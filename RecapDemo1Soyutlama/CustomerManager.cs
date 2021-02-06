using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemo1Soyutlama
{
    class CustomerManager
    {

        private ILogger _logger;
        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }


        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }

    }
}
