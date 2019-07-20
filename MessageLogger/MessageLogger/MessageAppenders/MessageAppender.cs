using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger.MessageAppenders
{
    public abstract class MessageAppender : IMessageAppender
    {
        public IMessageFormatter MessageFormatter { get;  private set; }

        protected MessageAppender(IMessageFormatter messageFormatter) 
        {
            this.MessageFormatter = messageFormatter;
        }

        public abstract void AppendMessage(string message, IssueLevel issueLevel, DateTime date);
    }
}
