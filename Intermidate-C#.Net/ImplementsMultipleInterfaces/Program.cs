using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace ImplementsMultipleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var textBox = new TextBox
            {
                Id = "1",
                size = Size.Empty,
                TopLeft = new Position()
            };

            textBox.Focus();
            textBox.Draw();
            textBox.Drag();
            textBox.Drop();
        }
    }
}
