using System;

namespace AbstractClassAndMembers
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle drawing ...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
        }
    }
}
