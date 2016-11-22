using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBank
{
    class Tweet:Message
    {

        List<string> hashTags = new List<string>();
        private string twitterID;
        private string sender;

        public Tweet(string tMessageText, string tMessageHeader)
        {
            MessageHeader = tMessageHeader;
            string[] tokens = MessageText.Split(' ');
            Sender = tokens[1];
            TwitterID = Sender;
            tMessageText = tMessageText.Replace(Sender, null);
            tMessageText = tMessageText.Trim();
            MessageText = tMessageText;

            

            foreach (string s in tokens)
            {
                if (s.StartsWith("#"))
                {
                    hashTags.Add(s);
                }
            }

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

        public string TwitterID
        {
            get { return twitterID; }
            set { twitterID = value; }
        }



    }
    }



