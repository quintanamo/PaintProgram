using System.Drawing;

namespace PaintProgram
{
    internal class Circle
    {
        private int X;
        private int Y;
        private int size;
        private Color color;
        public Circle(int x, int y, int size, Color color)
        {
            this.X = x;
            this.Y = y;
            this.size = size;
            this.color = color;
        }

        public int getX()
        {
            return this.X;
        }
        public int getY()
        {
            return this.Y;
        }
        public int getSize()
        {
            return this.size;
        }

        public Color getColor()
        {
            return this.color;
        }
    }
}