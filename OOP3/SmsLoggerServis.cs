using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class SmsLoggerServis : ILoggerServis
    {
        public void Log()
        {
            Console.WriteLine("Sms ile loglandı"); 
        }
    }
}
