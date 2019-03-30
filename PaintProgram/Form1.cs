﻿using System;
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
        private Color color = Color.Black;
        private bool canDraw = false;
        private int mouseX;
        private int mouseY;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = Canvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }
        
        // When the mouse is clicked, set the ability to draw to true and draw a circle based on mouse position
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            canDraw = true;
            mouseX = e.X;
            mouseY = e.Y;
            Circle circle = new Circle(mouseX, mouseY, size, color);
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, mouseX - (size/2), mouseY - (size/2), size, size);
        }

        // When the mouse click is lifted, set the ability to draw to false so shapes aren't being painted 100% of the time
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            canDraw = false;
        }

        // If the ability to draw is true (mouse is down) continue drawing shapes as the mouse moves
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            Circle circle = new Circle(mouseX, mouseY, size, color);
            if (canDraw)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
            }
        }
        
        // Set the size of the brush based on the trackbar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value * 2;
            Console.WriteLine("Set size to {0}", size);
        }

        // set all of the colors.  Last color can be customized.
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
        // opens the Color Dialog, sets the color of the box to the color selected which in turn sets the brush color
        private void CustomColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog.ShowDialog();
            CustomColor.BackColor = ColorDialog.Color;
            color = CustomColor.BackColor;
            Console.WriteLine("Color changed to Custom Color");
        }

        // Clear the canvas completely
        private void button1_Click(object sender, EventArgs e)
        {
            Canvas.Refresh();
            Canvas.Invalidate();
            Console.WriteLine("Canvas has been cleared");
        }
    }
}
