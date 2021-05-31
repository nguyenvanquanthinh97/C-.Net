using System;

namespace MethodOverriding
{
    public class Text : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Text is writing...");
        }
    }
}