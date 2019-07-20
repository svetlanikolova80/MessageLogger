using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MessageLogger.MessageFormaters;

namespace MessageLogger.MessageAppenders
{

    public class FileMessageAppender : MessageAppender
    {
        private readonly StreamWriter writer;
        public string FilePath { get; private set; }

        public FileMessageAppender(IMessageFormatter messageFormatter, string filePath): base(messageFormatter) 
        {
            this.FilePath = filePath;
            this.writer = new StreamWriter(this.FilePath, true);
        }

        public override void AppendMessage(string message, IssueLevel issueLevel, DateTime date)
        {   
            var output = this.MessageFormatter.FormatMessage(message, issueLevel, date);
            this.writer.WriteLine(output);
            this.writer.Flush();
        }

        public void CloseWriter() 
        {
            this.writer.Close();
        } 
    }
}
