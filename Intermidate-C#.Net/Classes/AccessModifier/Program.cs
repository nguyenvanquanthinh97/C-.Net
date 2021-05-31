using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1997, 5,22));

            Console.WriteLine(person.GetBirthDate());
        }
    }
}
