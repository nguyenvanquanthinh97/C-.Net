using System;

namespace TimeSpans
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Create
            var timespan = new TimeSpan(1, 2, 3);

            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            Console.WriteLine(timespan1 == timespan2);

            // Timespan can be created by subtract 2 dateTimes
            var now = DateTime.Now;
            var now2 = now.AddMinutes(2);
            var timespan3 = now2.Subtract(now);
            Console.WriteLine(timespan3);

            // *Properties
            Console.WriteLine(timespan.Minutes);
            Console.WriteLine(timespan.TotalMinutes);

            //* Add
            Console.WriteLine(timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timespan.Subtract(TimeSpan.FromMinutes(2)));

            //* ToString
            Console.WriteLine("ToString: " + timespan.ToString());

            //* Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:00").TotalMinutes);
        }
    }
}
