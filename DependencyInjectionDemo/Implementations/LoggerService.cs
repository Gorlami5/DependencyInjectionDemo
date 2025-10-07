using DependencyInjectionDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Implementations
{
    public class LoggerService : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
