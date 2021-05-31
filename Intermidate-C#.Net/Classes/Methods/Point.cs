using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point point)
        {
            if (point == null)
            {
                throw new NullReferenceException("point is null");
            }
            this.Move(point.X, point.Y);
        }
    }
}