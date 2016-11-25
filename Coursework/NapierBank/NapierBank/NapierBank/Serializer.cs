using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace NapierBank
{
    class Serializer
    {
        // This method serialises and outputs the message sent to in JSON format
        public static void Json(Email m)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Email));
            MemoryStream ms = new MemoryStream();
            
            js.WriteObject(ms, m);
            string st = "";
            
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            st = sr.ReadToEnd();
            System.IO.File.AppendAllText(".\\Messages.json", st + Environment.NewLine);

          
            sr.Close();
            ms.Close();
           
        }
        // This method serialises and outputs the message sent to in JSON format
        public static void Json(Tweet t)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Tweet));
            MemoryStream ms = new MemoryStream();

            js.WriteObject(ms, t);
            string st = "";

            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            st = sr.ReadToEnd();
            System.IO.File.AppendAllText(".\\test.json", st + Environment.NewLine);


            sr.Close();
            ms.Close();

        }
        // This method serialises and outputs the message sent to in JSON format
        public static void Json(SMS s)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SMS));
            MemoryStream ms = new MemoryStream();

            js.WriteObject(ms, s);
            string st = "";

            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            st = sr.ReadToEnd();
            System.IO.File.AppendAllText(".\\test.json", st + Environment.NewLine);


            sr.Close();
            ms.Close();

        }

    }
}
