using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService// sadece imza metodu olur içi dolu olamaz
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
