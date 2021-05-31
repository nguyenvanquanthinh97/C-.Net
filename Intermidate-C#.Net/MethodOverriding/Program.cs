using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Text());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
