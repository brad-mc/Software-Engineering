using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBank
{
    class SMS : Message
    {
        private string sender;
        public SMS(string sMessageText, string sMessageHeader)
        {
            MessageHeader = sMessageHeader;
            string[] tokens = sMessageText.Split(' ');
            Sender = tokens[1];
            sMessageText = sMessageText.Replace(Sender, null);
            sMessageText = sMessageText.Trim();
            MessageText = sMessageText;

            

            foreach (string key in CSV.abreveations.Keys)
            {
                if (MessageText.Contains(key))
                {
                    MessageText = MessageText.Replace(key, key + " " + "<" + CSV.abreveations[key] + ">" + " ");
                }

            }

            
        }

        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
    }
}

