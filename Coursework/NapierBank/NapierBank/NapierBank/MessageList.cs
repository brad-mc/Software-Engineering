﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBank
{  // This class contains lists of messages and quarentined items.
    class MessageList
    {
        public static List<SMS> smsList = new List<SMS>();
        public static List<Email> emailList = new List<Email>();
        public static List<Tweet> tweetList = new List<Tweet>();
        public static List<string> hashTags = new List<string>();
        public static List<string> mentions = new List<string>();
        public static List<string> urlQuarantine = new List<string>();
        public static List<string> sirType = new List<string> { "Theft", "Staff Attack", "ATM Theft", "Raid", "Customer Attack","Staff Abuse","Bomb Threat", "Terrorism", "Suspicious Incident", "Intelligence","Cash Loss" };
        public static List<Email> sirList = new List<Email>();
    }
}
