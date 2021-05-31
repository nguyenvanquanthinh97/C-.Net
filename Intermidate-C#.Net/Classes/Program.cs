using System;

namespace Classes
{
    public class Person
    {
        public string _name;

        public void Introduce(Person person) {
            Console.WriteLine("Hi {0}, my name is {1}", person._name, _name);
        }

        public static Person Parse(string name)
        {
            var person = new Person();
            person._name = name;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            person1._name = "John";

            var person2 = Person.Parse("Thinh");
            person1.Introduce(person2);
        }
    }
}
