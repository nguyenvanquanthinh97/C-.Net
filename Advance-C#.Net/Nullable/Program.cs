
using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> dateTime = null; // Equilavent to DateTime? dateTime = null;

            DateTime dateTime2 = dateTime.GetValueOrDefault();

            DateTime? dateTime3 = dateTime2;

            DateTime dateTime4 = dateTime != null ? dateTime.Value : DateTime.Now;

            //Console.WriteLine("GetValueOrDefault(): " + dateTime.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + dateTime.HasValue);
            //Console.WriteLine("Value: " + dateTime.Value);
        }
    }
}
