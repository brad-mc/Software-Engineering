using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;

namespace NapierBank
{
    [DataContract]
    public class Tweet:Message
    {

        private List<string> hashTags = new List<string>();
        [DataMember(Name = "Sender", IsRequired = true, Order = 1)]
        private string twitterID;
        private string sender;

        public Tweet(string tMessageText, string tMessageHeader)
        {
            MessageHeader = tMessageHeader;
            tMessageText = tMessageText.Trim();
            string[] tokens = tMessageText.Split(' ');
            Sender = tokens[0];
            TwitterID = Sender;
            
            tMessageText = tMessageText.Replace(Sender, null);
            tMessageText = tMessageText.Trim();
            MessageText = tMessageText;

            var mentionParser = new  Regex("((@)((?:[A-Za-z0-9-_]*)))");
            var match = mentionParser.Match(MessageText);
            if (match.Success)
            {
                MessageList.mentions.Add(match.Value);
            }

            //Finds hashtags and adds them to a list to be catalogued
            foreach (string s in tokens)
            {
                if (s.StartsWith("#"))
                {
                    hashTags.Add(s);
                    MessageList.hashTags.Add(s);
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

        public List<string> HashTags
        {
            // no setter
            get { return hashTags; }
        }



    }
    }



