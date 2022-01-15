using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class DataBaseLoggerServis : ILoggerServis 
    {
        public void Log()
        {
            Console.WriteLine("veri tabanına loglandı");
        }
    }


}
