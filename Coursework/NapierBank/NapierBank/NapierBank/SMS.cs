using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace NapierBank
{
    [DataContract]
    public class SMS : Message
    {
        [DataMember(Name = "Sender", IsRequired = true, Order = 1)]
        private string sender;
        public SMS(string sMessageText, string sMessageHeader)
        {
            MessageHeader = sMessageHeader;
            sMessageText = sMessageText.Trim();
            string[] tokens = sMessageText.Split(' ');
            Sender = tokens[0];
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

