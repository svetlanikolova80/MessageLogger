using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger.MessageFormaters
{
    public class XMLMessageFormatter : IMessageFormatter
    {
        private static readonly string tabulation = new string(' ', 4); 

        public string FormatMessage(string message, IssueLevel issueLevel, DateTime date)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("<log>");
            output.AppendLine(string.Format("{0}<message>{1}</message>", tabulation, message));
            output.AppendLine(string.Format("{0}<issueLevel>{1}</issueLevel>", tabulation, issueLevel));
            output.AppendLine(string.Format("{0}<date>{1}</date>", tabulation, date));
            output.AppendLine("</log>");
            return output.ToString();
        }
    }
}
