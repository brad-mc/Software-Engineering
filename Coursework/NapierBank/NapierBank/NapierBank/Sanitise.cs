using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBank
{
    class Sanitise
    {


        public static void SanitiseMessage(string message)
        {

            char messageType;
            string messageHeader;
            string body;
            int length = (message.Length) -10 ;
            messageType = message[0];
            messageHeader = message.Substring(0, 10);
            body = message.Substring(10, length);

            switch (messageType)
            {
                case ('S'):
                    {
                        SMS smsm = new SMS(body, messageHeader);
                        MessageList.smsList.Add(smsm);
                        break;
                    }
                case ('E'):
                    {
                        Email emailm = new Email(body, messageHeader);
                        emailm.URLRemoval(emailm.MessageText);
                        MessageList.emailList.Add(emailm);

                        break;
                    }
                case ('T'):
                    {
                        Tweet tweetm = new Tweet(body, messageHeader);
                        MessageList.tweetList.Add(tweetm);
                        

                        break;
                    }
            }


        }
    }
}
