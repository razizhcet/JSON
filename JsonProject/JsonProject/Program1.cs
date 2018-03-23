using Newtonsoft.Json.Linq;
using System;

namespace JsonProject
{
    public class MyDetail1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            string jsonData =  @"{  
                                'FirstName':'Razi',  
                                'LastName':'Ahmad'  
                                }";

            //use “JObject.Parse” method and retrieve data using key.
            var details = JObject.Parse(jsonData);
            Console.WriteLine(string.Concat("Hi ", details["FirstName"], " " + details["LastName"]));
            Console.ReadLine();
        }
    }
}
