using LoggerWithChainOfResponsibilityPattern.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LoggerWithChainOfResponsibilityPattern.Concrete
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(LogLevel level) : base(level)
        {
        }
        protected override void CreateLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
