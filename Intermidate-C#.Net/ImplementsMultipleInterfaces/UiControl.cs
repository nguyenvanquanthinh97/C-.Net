using System;
using System.Drawing;

namespace ImplementsMultipleInterfaces
{
    public class UiControl
    {
        public string Id { get; set; }
        public Size size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw() { }

        public void Focus()
        {
            Console.WriteLine("Received Focus");
        }
    }
}