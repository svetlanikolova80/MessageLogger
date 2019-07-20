using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger
{
    public interface IMessageFormatter
    {
        string FormatMessage(string message, IssueLevel issueLevel, DateTime date);
    }
}
