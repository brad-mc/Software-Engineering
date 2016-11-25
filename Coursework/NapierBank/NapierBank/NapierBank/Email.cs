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
        private string sirSortCode;
        private string sirIncident;
        
        public Email(string eMessageText, string eMessageHeader)
        {
            //Extracts the information from the text string passed to it.
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
           
            //Determines if the email message is a Serious Incident one
            if (Subject.StartsWith("SIR"))
            {
                
                
                SIRSortCode= tokens[0];
                foreach(string s in MessageList.sirType)
                {
                    if (s.Contains(tokens[1]))
                    {
                        SIRIncident = tokens[1];
                    }
                    try
                    {
                        if (s.Contains(tokens[2]))
                        {
                            SIRIncident = SIRIncident + " " + tokens[2];
                        }
                    }
                    catch (Exception e) { }

                }

                

            }
            //Expands the abbreviations in the message
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

        public string SIRSortCode
        {
            get { return sirSortCode; }
            set { sirSortCode = value; }
        }

        public string SIRIncident
        {
            get { return sirIncident; }
            set { sirIncident = value; }
        }

        //Extracts the sender from the message string using a reglar expression
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
