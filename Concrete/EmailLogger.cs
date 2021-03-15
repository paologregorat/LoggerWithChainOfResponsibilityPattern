using LoggerWithChainOfResponsibilityPattern.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LoggerWithChainOfResponsibilityPattern.Concrete
{
    public class EmailLogger : AbstractLogger
    {
        private string _mailto;
        public EmailLogger(string mailto, LogLevel level) : base(level)
        {
            _mailto = mailto;
        }
        protected override void CreateLog(string message)
        {
            SendMail(_mailto, message);
        }

        protected void SendMail(string mailTo, string message)
        { }
    }
}
