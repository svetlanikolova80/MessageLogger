using MessageLogger.MessageFormaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger.MessageAppenders
{
    public class ConsoleMessageAppender : MessageAppender
    {

        public ConsoleMessageAppender(IMessageFormatter messageFormater): base(messageFormater)
        {
        }

        public override void AppendMessage(string message, IssueLevel issueLevel, DateTime date)
        {
            var output = this.MessageFormatter.FormatMessage(message, issueLevel, date);
            Console.WriteLine(output);
        }
    }
}
