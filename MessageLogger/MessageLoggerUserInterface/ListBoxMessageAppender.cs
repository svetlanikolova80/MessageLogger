using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageLogger;
using MessageLogger.MessageAppenders;
using MessageLogger.MessageFormaters;
using System.Windows.Controls;

namespace MessageLoggerUserInterface
{
    public class ListBoxMessageAppender : MessageAppender
    {
        public ListBox ListBox { get; private set; }

        public ListBoxMessageAppender(IMessageFormatter messageFormatter, ListBox listBox) : base(messageFormatter)
        {
            this.ListBox = listBox;
        }
       
        public override void AppendMessage(string message, IssueLevel issueLevel, DateTime date)
        {
            string output = this.MessageFormatter.FormatMessage(message, issueLevel, date);
            this.ListBox.Items.Add(output);
        }
    }
}
