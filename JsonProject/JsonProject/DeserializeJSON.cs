using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject
{
    class DeserializeJSON
    {
        static void Deserialize()
        {
            string data = @"{'ID': 123,
                            'Name':'Afzaal Ahmad Zeeshan',
                            'Married': true,
                            'DateOfBirth':'1975-08-29T00:00:00'
                            }";
            Person obj = JsonConvert.DeserializeObject<Person>(data);
            Console.WriteLine("ID:" + obj.ID);
            Console.WriteLine("Name:" + obj.Name);
            Console.WriteLine("Married:" + obj.Married);
            Console.WriteLine("DateOfBirth:" + obj.DateOfBirth);

        }
        static void Main(string[] args)
        {
            Deserialize();
            Console.ReadKey();
        }
    }
}
