using System;

namespace Inheritances
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink()
        {
            Console.WriteLine("Hyperlink was added");
        }
    }
}