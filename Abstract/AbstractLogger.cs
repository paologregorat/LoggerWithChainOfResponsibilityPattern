using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggerWithChainOfResponsibilityPattern.Abstract
{
    public abstract class AbstractLogger : ILogger
    {
        public enum LogLevel
        {
            DEBUG,
            INFO,
            WARN,
            ERROR
        }
        private ILogger _nexthandler;
        protected LogLevel _level;
        public AbstractLogger(LogLevel level)
        {
            _level = level;
        }
        public void Log(string msg, LogLevel level)
        {
            if (_level >= level)
            {
                CreateLog(msg);
            } else
            {
                if (_nexthandler != null)
                {
                    _nexthandler.Log(msg, level);
                }
            }
        }

        public ILogger SetNextHandler(ILogger next)
        {
            _nexthandler = next;
            return next;
        }

        protected abstract void CreateLog(string message);
    }
}
