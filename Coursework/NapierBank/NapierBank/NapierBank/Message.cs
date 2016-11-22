using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBank
{
    class Message
    {
        
        private string messageText;
        private string messageHeader;

        public string MessageHeader
        {
            get { return messageHeader; }
            set { messageHeader = value; }
        }

        public string MessageText
        {
            get { return messageText; }
            set { messageText = value; }
        }
      

        public string URLRemoval (string message)
        {
            var linkParser = new Regex("((https?://)?www\\.[^\\s]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match m in linkParser.Matches(message))
            {
                MessageList.urlQuarantine.Add(m.Value);
            }

            string safeMessage = Regex.Replace(message, "((https?://)?www\\.[^\\s]+)", "<URL Quarantined>");
            return safeMessage;

        }
      
        }
 }

