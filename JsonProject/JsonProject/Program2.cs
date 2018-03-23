using Newtonsoft.Json;
using System;

namespace JsonProject
{
    public class MyDetail2
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            string jsonData = @"{  
                                'FirstName':'Razi',  
                                'LastName':'Ahmad'  
                                }";

            //cast json object to custom class object
            //json key name must match with class property name > case insensitive
            MyDetail2 myDetails = JsonConvert.DeserializeObject<MyDetail2>(jsonData);
            Console.WriteLine(string.Concat("Hi ", myDetails.FirstName, " " + myDetails.LastName));
            Console.ReadKey();
        }
    }
}
