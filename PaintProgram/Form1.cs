using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintProgram
{
    public partial class Form1 : Form
    {
        private int size = 2;
        private ArrayList myPts = new ArrayList();
        Color color;
        bool canDraw = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            canDraw = true;
            Graphics g = Graphics.FromHwnd(this.Handle);
            if (color == null)
            {
                color = Color.Black;
            }
            myPts.Add(new Circle(e.X, e.Y, size, color));
            Canvas.Invalidate();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            canDraw = false;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDraw)
            {
                Graphics g = Graphics.FromHwnd(this.Handle);
                if (color == null)
                {
                    color = Color.Black;
                }
                myPts.Add(new Circle(e.X, e.Y, size, color));
                Canvas.Invalidate();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach(Circle p in myPts)
            {
                g.FillEllipse(new SolidBrush(p.getColor()), p.getX() - p.getSize() / 2, p.getY() - p.getSize() / 2, p.getSize(), p.getSize());
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value * 2;
            Console.WriteLine("Set size to {0}", size);
        }

        private void Black_MouseClick(object sender, MouseEventArgs e)
        {
            color = Color.Black;
            Console.WriteLine("Color changed to Black");
        }
        private void White_MouseClick(object sender, MouseEventArgs e)
        {
            this.color = Color.White;
            Console.WriteLine("Color changed to White");
        }
        private void Red_MouseClick(object sender, MouseEventArgs e)
        {
            color = Color.Red;
            Console.WriteLine("Color changed to Red");
        }
        private void Orange_MouseClick(object sender, MouseEventArgs e)
        {
            color = Color.Orange;
            Console.WriteLine("Color changed to Orange");
        }
        private void Yellow_MouseClick(object sender, MouseEventArgs e)
        {
            color = Color.Yellow;
            Console.WriteLine("Color changed to Yellow");
        }
        private void Green_MouseClick(object sender, MouseEventArgs e)
        {
            color = Color.Green;
            Console.WriteLine("Color changed to Green");
        }
        private void Blue_MouseClick(object sender, MouseEventArgs e)
        {
            color = Color.Blue;
            Console.WriteLine("Color changed to Blue");
        }
        private void Indigo_MouseClick(object sender, MouseEventArgs e)
        {
            color = Color.Indigo;
            Console.WriteLine("Color changed to Indigo");
        }
        private void Violet_MouseClick(object sender, MouseEventArgs e)
        {
            color = Color.Violet;
            Console.WriteLine("Color changed to Violet");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myPts.Clear();
            Canvas.Invalidate();
        }
    }
}
