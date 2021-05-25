using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // *Implicit type conversion
            byte b_i = 1;
            int i = b_i;
            Console.WriteLine(i);

            // int i_b = 1;
            // byte b = i_b; // can not happen because it will cause lost data

            // *Explicit type conversion
            int i_b = 1;
            byte b = (byte)i_b;
            Console.WriteLine(b);

            // string s_i = "1";
            // int i2 = (int)s_i; // can not happen because string and int are totally differect

            // *Conversion between non-compatible types
            string s_i = "1";
            int i2 = Convert.ToInt32(s_i);
            Console.WriteLine(i2);

            ///////////////////////
            try
            {
                int i_b2 = 1234;
                byte b2 = Convert.ToByte(i_b2);
                Console.WriteLine(b2);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}
