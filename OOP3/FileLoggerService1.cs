using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    partial class DatabaseLoggerService : ILoggerService
    {
        class FileLoggerService
        {
            public void Log()
            {
                Console.WriteLine("Dosyaya loglandı");
            }
        }
    }
}