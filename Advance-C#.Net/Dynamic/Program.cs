
using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            //obj.GetHashCode();

            // Reflection
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            dynamic excelObject = "mosh";
            Console.WriteLine(excelObject.Optimize());
            excelObject.GetHashCode();

            dynamic name = "Thinh";
            name = 10;

            Console.WriteLine(name);
        }
    }
}
