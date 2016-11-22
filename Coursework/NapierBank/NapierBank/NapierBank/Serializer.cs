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
        [DataContract]
        class Spell
        {
            [DataMember(Name = "cast", IsRequired = true)]
            public String cast;

            [DataMember(Name = "cooldown", IsRequired = true)]
            public String cooldown;

            [DataMember(Name = "powerCost", IsRequired = true)]
            public String cost;

            [DataMember(Name = "description", IsRequired = true)]
            public String description;

            [DataMember(Name = "icon", IsRequired = false)]
            public String icon;

            [DataMember(Name = "id", IsRequired = true)]
            public Int16 id;

            [DataMember(Name = "name", IsRequired = true)]
            public String name;

            [DataMember(Name = "range", IsRequired = true)]
            public String range;
        }

        DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(List<string>));
        MemoryStream ms = new MemoryStream();
        js.WriteObject(ms, frostShock);

            

     Console.WriteLine("\r\nUdemy.com - Serializing and Deserializing JSON in C#\r\n");
     ms.Position = 0;
     StreamReader sr = new StreamReader(ms);
        Console.WriteLine(sr.ReadToEnd());
     sr.Close();
     ms.Close();

    }
}
