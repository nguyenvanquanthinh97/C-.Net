using System;

namespace ImplementsMultipleInterfaces
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            Console.WriteLine("TextBox is Dragging");
        }

        public void Drop()
        {
            Console.WriteLine("TextBox is Dropping");
        }
    }
}