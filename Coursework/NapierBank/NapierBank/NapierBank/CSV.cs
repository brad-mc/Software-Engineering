using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapierBank
{
    public static class CSV
    {

        public static Dictionary<string, string> abreveations = new Dictionary<string, string>();

        //This method reads in the text abreviations from the csv file and adds them to a dictionary 
        public static void readCSV() {

            string filePath = @"C:\Users\Bradley\Documents\Napier\Software-Engineering\Coursework\NapierBank\NapierBank\NapierBank\textwords.csv";
            StreamReader sr = new StreamReader(filePath);
            var lines = new List<string[]>();
            int Row = 0;
            while (!sr.EndOfStream)
            {
                string[] Line = sr.ReadLine().Split(',');
                abreveations.Add(Line[0], Line[1]);
                Row++;
                Console.WriteLine(Row);
            }

               
           
        }
}
}
