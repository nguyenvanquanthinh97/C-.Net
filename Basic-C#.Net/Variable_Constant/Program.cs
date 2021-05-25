using System;

namespace Variable_Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variable
            // Method - 1:
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Mosh";
            //bool isWorking = false;

            // Method - 2:
            var number = 1;
            var count = 10;
            var totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;

            const float Pi = 3.14f; 

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}
