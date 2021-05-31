using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime dateTime, string name, string username)
        {
            Birthdate = dateTime;
            Name = name;
            Username = username;
        }

        public int Age
        {
            get
            {
                var timespan = DateTime.Now.Year - Birthdate.Year;
                return timespan;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1997,05,22), "Thinh", "thinhvqnguyen");
            Console.WriteLine(person.Birthdate);
            Console.WriteLine("Age: {0}", person.Age);
        }
    }
}
