using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace JsonProject
{
    [DataContract]
    public class MyDetail3
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            string jsonData = "{  \"FirstName\":\"Razi\",\"LastName\":\"Ahmad\" }";

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(MyDetail3));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonData));

            stream.Position = 0;

            MyDetail3 dataContractDetail = (MyDetail3)jsonSerializer.ReadObject(stream);
            Console.WriteLine(string.Concat("Hi ", dataContractDetail.FirstName, " " + dataContractDetail.LastName));
            Console.ReadKey();
        }
    }
}
