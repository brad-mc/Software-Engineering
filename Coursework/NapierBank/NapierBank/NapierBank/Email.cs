using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace NapierBank
{
    [DataContract]
    public class Email:Message
    {
        [DataMember(Name = "Subject", IsRequired = true, Order = 2)]
        private string subject;
        [DataMember(Name = "Sender", IsRequired = true, Order = 1)]
        private string sender;
        
        public Email(string eMessageText, string eMessageHeader)
        {
            
            MessageHeader = eMessageHeader;
            Sender = GetSender(eMessageText);
            eMessageText = eMessageText.Replace(Sender, null);
            eMessageText = eMessageText.Trim();
            Subject = eMessageText.Substring(0, 20);
            eMessageText = eMessageText.Replace(Subject, null);
            eMessageText = eMessageText.Trim();
            MessageText = eMessageText;

            string[] tokens = MessageText.Split(' ');
            List<string> tokensList = new List<string>(tokens);
           
            if (Subject.StartsWith("SIR"))
            {
                string sortcode= "";
                string incident= "";
                sortcode = tokens[0];
                foreach(string s in MessageList.sirType)
                {
                    if (s.Contains(tokens[1]))
                    {
                        incident = tokens[1];
                    }
                    try
                    {
                        if (s.Contains(tokens[2]))
                        {
                            incident = incident + " " + tokens[2];
                        }
                    }
                    catch (Exception e) { }

                }

                MessageList.sirList.Add(sortcode + " " + incident);

            }

            foreach (string key in CSV.abreveations.Keys)
            {
                if (MessageText.Contains(key))
                {
                    MessageText = MessageText.Replace(key, key + " " + "<" + CSV.abreveations[key] + ">" + " ");
                }

            }





        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }


        public string GetSender (string message)
        {
            string emailSender="";
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);

            foreach (Match m in emailRegex.Matches(message))
            {
                emailSender = m.Value;
                break;
            }

            return emailSender;

        }
    }
}
