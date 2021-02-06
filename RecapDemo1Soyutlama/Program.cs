using System;

namespace RecapDemo1Soyutlama
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager( new DataBaseLogger());
            
           
            customerManager.Add();
        }
    }
}
