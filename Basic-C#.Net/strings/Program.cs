using System;
using System.Collections.Generic;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nguyen";
            string lastName = "Thinh";
            Console.WriteLine(string.Format("{0} {1}", firstName, lastName));

            var strs = new string[3] { "John", "Jane", "Mary" };
            Console.WriteLine(string.Join(":", strs));

            string path = "C:\\projects\\project1\\folder1";
            string verbastismPath = @"C:\projects\project1\folder1";

            Console.WriteLine(path);
            Console.WriteLine(verbastismPath);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            var verbastismText = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(text);
            Console.WriteLine(verbastismText);

            //////////////////////
            var fullName = "Thinh Nguyen ";
            Console.WriteLine("Trim: {0}", fullName.Trim());
            Console.WriteLine("ToUpper: {0}", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(" ");
            Console.WriteLine("FirstName: " + fullName.Substring(0, index));
            Console.WriteLine("LastName: " + fullName.Substring(index + 1));

            var names = fullName.Split(" ");
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine("" + fullName.Replace("Nguyen", "Van Quan Nguyen"));

            if (string.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

            ///////////////////
            // Summarize
            var sentence = "This is going to be a really really really really really really really really long text.";
            var summary = summarize(sentence, 23);
            Console.WriteLine(summary);
        }

        static string summarize(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            var words = text.Split(" ");
            var summarizeWords = new List<string>();

            var totalLength = 0;
            foreach(var word in words)
            {
                summarizeWords.Add(word);
                totalLength += word.Length + 1;
                if (totalLength > maxLength)
                {
                    break;
                }
            }
            var summarizeText = string.Join(" ", summarizeWords);
            return summarizeText + "...";
        }
    }
}
