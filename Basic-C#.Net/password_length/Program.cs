using System;

namespace RandomPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var random = new Random();
                Console.Write("Input password length:");
                var passwordLength = Convert.ToInt32(Console.ReadLine());

                var buffer = new char[passwordLength];
                for(int idx = 0; idx < passwordLength; idx++)
                {
                    buffer[idx] = (char)('a' + random.Next(0,26));
                }

                var password = new string(buffer);
                Console.WriteLine("Random password: {0}", password);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Can not convert String to Int32");
            }
        }
    }
}
