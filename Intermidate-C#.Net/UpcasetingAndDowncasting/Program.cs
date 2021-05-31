using System;

namespace UpcasetingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Both text, shape and text2 are referencing to the same object in HEAP memory
            Text text = new Text();
            Shape shape = text;
            
            // Downcasting: will throw exception if not invalid
            Text text2 = (Text)shape;

            // For safely use as to converse
            Text test3 = shape as Text;
            if (test3 != null)
            {
                Console.WriteLine("Conversion success");
            }
        }
    }
}
