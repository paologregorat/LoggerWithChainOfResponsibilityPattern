using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerWithChainOfResponsibilityPattern.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoggerWithChainOfResponsibilityPattern.Abstract;

namespace LoggerWithChainOfResponsibilityPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            Abstract.ILogger defaultLogger = new ConsoleLogger(AbstractLogger.LogLevel.INFO);
            Abstract.ILogger warnLogger = new FileLogger("Log.txt",AbstractLogger.LogLevel.WARN);
            Abstract.ILogger errorLogger = new EmailLogger("pippo@gmail.com", AbstractLogger.LogLevel.ERROR);

            defaultLogger.SetNextHandler(warnLogger).SetNextHandler(errorLogger);


            defaultLogger.Log("Errore livello debug", AbstractLogger.LogLevel.DEBUG);
            defaultLogger.Log("Errore livello info", AbstractLogger.LogLevel.INFO);
            defaultLogger.Log("Errore livello warn", AbstractLogger.LogLevel.WARN);
            defaultLogger.Log("Errore livello error", AbstractLogger.LogLevel.ERROR);

        }
    }
}
