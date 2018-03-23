using Newtonsoft.Json;
using System;

namespace JsonProject
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Married { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    class SerializeJSON
    {
        static void Main(string[] args)
        {
            Person any = new Person
            {
                ID = 123,
                Name = "Afzaal Ahmad Zeeshan",
                Married = false,
                DateOfBirth = new DateTime(1975, 08, 29)
            };
            string serializedJson = JsonConvert.SerializeObject(any);

            Console.WriteLine(serializedJson);
            Console.ReadKey();
        }
    }
}
