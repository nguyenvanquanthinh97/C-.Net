using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        public static string shorten(this string str, int shortenLength)
        {
            var words = str.Split(" ");
            return string.Join(" ",words.Take(shortenLength)) + "...";
        }
    }
}