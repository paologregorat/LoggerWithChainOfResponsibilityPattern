using LoggerWithChainOfResponsibilityPattern.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LoggerWithChainOfResponsibilityPattern.Concrete
{
    public class FileLogger : AbstractLogger
    {
        private string _filePath;
        public FileLogger(string path, LogLevel level) : base(level)
        {
            _filePath = path;
        }
        protected override void CreateLog(string message)
        {
            File.AppendAllText(_filePath, message);
        }
    }
}
