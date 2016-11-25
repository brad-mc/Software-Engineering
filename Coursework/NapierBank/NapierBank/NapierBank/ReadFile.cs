using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBank
{
    class ReadFile
    {
        
        //This method uses a regular expression to break down the messages contained in the file and displays them on screen
        public static void read(string filepath)
        {
            
                string text = File.ReadAllText(@filepath, Encoding.UTF8);
                string[] messages = Regex.Split(text, @"([TSE]{1}[0-9]{9}(?:(?![TSE]{1}[0-9]{9}).)*)");
                List<string> mm = new List<string>(messages);
                mm = mm.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

                foreach (string s in mm)
                {
                    s.Trim();
                    Sanitise.SanitiseMessage(s);
                }
            
           
        }

        
    }
}
