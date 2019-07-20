namespace MessageLogger
{
    using System;
    using System.Collections.Generic;

    public class Logger
    {
        public List<IMessageAppender> MessageAppenders { get; set; }

        public Logger(IMessageAppender[] messageAppenders) 
        {
            this.MessageAppenders = new List<IMessageAppender>(messageAppenders);
        }

        public void LogInfo(string message)
        {
            this.LogAnMessage(message, IssueLevel.Info);
        }

        public void LogWarning(string message)
        {
            this.LogAnMessage(message, IssueLevel.Warning);
        }

        public void LogError(string message)
        {
            this.LogAnMessage(message, IssueLevel.Error);
        }

        public void LogCriticalError(string message)
        {
            this.LogAnMessage(message, IssueLevel.Critical);
        }

        public void LogFatalError(string message)
        {
            this.LogAnMessage(message, IssueLevel.Fatal);
        }

        private void LogAnMessage(string message, IssueLevel issueLevel) 
        {
            var date = DateTime.Now;

            foreach (var item in this.MessageAppenders)
            {
                item.AppendMessage(message, issueLevel, date);  
            }                    
        }
    }
}