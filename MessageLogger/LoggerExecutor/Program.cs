using MessageLogger;
using MessageLogger.MessageAppenders;
using MessageLogger.MessageFormaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLoggerExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleMessageFormatter = new SimpleMessageFormatter();
            var xmlMessageFormatter = new XMLMessageFormatter();
            var jsonMessageFormatter = new JsonFormatter();

            var fileMessageAppender = new FileMessageAppender(jsonMessageFormatter, "log.txt");
            var consoleMessageAppender = new ConsoleMessageAppender(jsonMessageFormatter);

            var messageAppenders = new IMessageAppender[] 
            {
                fileMessageAppender,
                consoleMessageAppender
            };

            Logger logger = new Logger(messageAppenders);
            logger.LogCriticalError("Out of memory");
            logger.LogInfo("Unused local variable 'name'");

            fileMessageAppender.CloseWriter();
        }
    }
}
