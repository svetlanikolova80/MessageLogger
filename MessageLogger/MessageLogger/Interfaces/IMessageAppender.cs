using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger
{
    public interface IMessageAppender
    {
        void AppendMessage(string message, IssueLevel issueLevel, DateTime date);
    }
}
