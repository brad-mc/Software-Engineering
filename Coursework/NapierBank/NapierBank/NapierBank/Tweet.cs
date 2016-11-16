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
        string twitterID;

        public Tweet(string tMessageText, string tMessageHeader)
        {
            messageHeader = tMessageHeader;
            messageText = tMessageText;

            string[] tokens = messageText.Split(' ');
            sender = tokens[1];
            twitterID = sender;

            foreach (string s in tokens)
            {
                if (s.StartsWith("#"))
                {
                    hashTags.Add(s);
                }
            }



        }
    }
}
