using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageLogger;
using MessageLogger.MessageFormaters;
using MessageLogger.MessageAppenders;

namespace MessageLoggerUserInterface
{
    public partial class MainWindow : Window
    {
        private Logger logger;

        public MainWindow()
        {
            InitializeComponent();

            var simpleMessageFormatter = new SimpleMessageFormatter();
                        
            ListBox listBox = (ListBox)this.FindName("ListBox");

            var listBoxMessageAppender = new ListBoxMessageAppender(simpleMessageFormatter, listBox);
            var fileMessageAppender = new FileMessageAppender(simpleMessageFormatter, "log.txt");

            var messageAppenders = new IMessageAppender[] 
            {
                fileMessageAppender,
                listBoxMessageAppender
            };

            this.logger = new Logger(messageAppenders);

            this.KeyDown += MainWindowKeyDown;
            
        }

        private void MainWindowKeyDown(object sender, KeyEventArgs e)
        {
            this.logger.LogInfo(e.Key.ToString());
        }
    }
}
