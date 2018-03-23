using Newtonsoft.Json.Linq;
using System;

namespace JsonProject
{
    public class MyDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string jsonData = "{  \"FirstName\":\"Razi\",\"LastName\":\"Ahmad\" }";
            dynamic data = JObject.Parse(jsonData);

            Console.WriteLine(string.Concat("Hi ", data.FirstName, " " + data.LastName));
            Console.ReadKey();
        }
    }
}
