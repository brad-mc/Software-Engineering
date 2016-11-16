using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBank
{
    class MessageList
    {
        public List<SMS> smsList = new List<SMS>();
        public List<Email> emailList = new List<Email>();
        public List<Tweet> tweetList = new List<Tweet>();
    }
}
