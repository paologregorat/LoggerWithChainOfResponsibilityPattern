using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LoggerWithChainOfResponsibilityPattern.Abstract.AbstractLogger;

namespace LoggerWithChainOfResponsibilityPattern.Abstract
{
    public interface ILogger
    {
        public void Log(string msg, LogLevel level);
        public ILogger SetNextHandler(ILogger next);
    }
}
