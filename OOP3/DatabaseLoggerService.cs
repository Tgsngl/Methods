using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService//sadece imza metodu olur içi dolu olamaz
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
