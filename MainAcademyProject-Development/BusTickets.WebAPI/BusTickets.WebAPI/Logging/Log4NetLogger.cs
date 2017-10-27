using System;
using System.Reflection;
using System.Xml;
using log4net;
using log4net.Repository;
using Microsoft.Extensions.Logging;

namespace BusTickets.WebAPI
{
    public class Log4NetLogger : ILogger
    {
        private readonly string name;
        private readonly XmlElement xmlElement;
        private readonly ILog log;
        private ILoggerRepository loggerRepository;

        public Log4NetLogger(string name, XmlElement xmlElement)
        {
            this.name = name;
            this.xmlElement = xmlElement;
            this.loggerRepository = log4net.LogManager.CreateRepository(
                Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
            this.log = LogManager.GetLogger(this.loggerRepository.Name, name);
            log4net.Config.XmlConfigurator.Configure(this.loggerRepository, xmlElement);
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Critical:
                    return this.log.IsFatalEnabled;
                case LogLevel.Debug:
                case LogLevel.Trace:
                    return this.log.IsDebugEnabled;
                case LogLevel.Error:
                    return this.log.IsErrorEnabled;
                case LogLevel.Information:
                    return this.log.IsInfoEnabled;
                case LogLevel.Warning:
                    return this.log.IsWarnEnabled;
                default:
                    throw new ArgumentOutOfRangeException(nameof(logLevel));
            }
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!this.IsEnabled(logLevel))
            {
                return;
            }

            if (formatter == null)
            {
                throw new ArgumentNullException(nameof(formatter));
            }

            string message = null;
            if (formatter != null)
            {
                message = formatter(state, exception);
            }

            if (!string.IsNullOrEmpty(message) || exception != null)
            {
                switch (logLevel)
                {
                    case LogLevel.Critical:
                        this.log.Fatal(message);
                        break;
                    case LogLevel.Debug:
                    case LogLevel.Trace:
                        this.log.Debug(message);
                        break;
                    case LogLevel.Error:
                        this.log.Error(message);
                        break;
                    case LogLevel.Information:
                        this.log.Info(message);
                        break;
                    case LogLevel.Warning:
                        this.log.Warn(message);
                        break;
                    default:
                        this.log.Warn($"Encountered unknown log level {logLevel}, writing out as Info.");
                        this.log.Info(message, exception);
                        break;
                }
            }
        }
    }
}
