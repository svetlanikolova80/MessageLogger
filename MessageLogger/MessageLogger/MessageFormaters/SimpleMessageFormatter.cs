using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger.MessageFormaters
{
    public class SimpleMessageFormatter : IMessageFormatter
    {

        public string FormatMessage(string message, IssueLevel issueLevel, DateTime date)
        {
            return string.Format("{0} - {1} - {2}", message, issueLevel, date);
        }
    }
}
