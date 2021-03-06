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
        private Color color = Color.Black;
        private bool canDraw = false;
        private int mouseX;
        private int mouseY;
        List<Bitmap> undoList = new List<Bitmap>();
        Bitmap bitmap;
        Graphics g;
        String brushType = "circle";

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.ClientRectangle.Width, Canvas.ClientRectangle.Height);
            g = Canvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }

        // When the mouse is clicked, set the ability to draw to true and draw a circle based on mouse position
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            canDraw = true;
            mouseX = e.X;
            mouseY = e.Y;
            using (Graphics toBitmap = Graphics.FromImage(bitmap))
            {  
                if(undoList.Count() == 0)
                {
                    toBitmap.FillRectangle(new SolidBrush(Canvas.BackColor), 0, 0, Canvas.Width, Canvas.Height);
                }
                toBitmap.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                Shape circle = new Shape(mouseX, mouseY, size, color);
                SolidBrush brush = new SolidBrush(color);
                if(brushType == "circle")
                {
                    toBitmap.FillEllipse(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
                    g.FillEllipse(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
                } else if(brushType == "square")
                {
                    toBitmap.FillRectangle(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
                    g.FillRectangle(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
                }
                brush.Dispose();
            }
        }

        // When the mouse click is lifted, set the ability to draw to false so shapes aren't being painted 100% of the time
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            canDraw = false;
            undoList.Add(new Bitmap(bitmap));
            Canvas.Invalidate();
        }

        // If the ability to draw is true (mouse is down) continue drawing shapes as the mouse moves
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            if (canDraw)
            {
                using (Graphics toBitmap = Graphics.FromImage(bitmap))
                {
                    toBitmap.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    Shape circle = new Shape(mouseX, mouseY, size, color);
                    SolidBrush brush = new SolidBrush(color);
                    if (brushType == "circle")
                    {
                        toBitmap.FillEllipse(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
                        g.FillEllipse(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
                    }
                    else if (brushType == "square")
                    {
                        toBitmap.FillRectangle(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
                        g.FillRectangle(brush, mouseX - (size / 2), mouseY - (size / 2), size, size);
                    }
                    brush.Dispose();
                }
            }
        }

        // Set the size of the brush based on the trackbar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value * 2;
            Console.WriteLine("Set size to {0}", size);
            BrushSizeLabel.Text = Convert.ToString(size);
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

        // Clear the canvas completely
        private void clearButton_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Canvas.ClientRectangle.Width, Canvas.ClientRectangle.Height);
            undoList.Add(new Bitmap(bitmap));
            Canvas.Refresh();
            Canvas.Invalidate();
            Console.WriteLine("Canvas has been cleared");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile.ShowDialog();
            String path = SaveFile.FileName;
            if (path != null)
            {
                
                bitmap.Save(path);
                Console.WriteLine("Saved file to {0}", path);
            }
            
        }

        private void CanvasColorButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Changing the canvas color will clear it!  Would you like to proceed?", "Warning!", MessageBoxButtons.OKCancel);
            if(confirm == DialogResult.OK)
            {
                Canvas.Refresh();
                undoList.Clear();
                ColorDialog.ShowDialog();
                Canvas.BackColor = ColorDialog.Color;
                Console.WriteLine("Canvas changed to Custom Color");
                bitmap = new Bitmap(Canvas.ClientRectangle.Width, Canvas.ClientRectangle.Height);
                Canvas.Invalidate();
                Console.WriteLine("{0}", undoList.Count());
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoList.Count() > 0)
            {
                int lastIndex = undoList.Count() - 1;
                undoList.RemoveAt(lastIndex);
                if(undoList.Count > 0)
                {
                    bitmap = undoList.ElementAt(undoList.Count() - 1);
                } else
                {
                    bitmap = new Bitmap(Canvas.ClientRectangle.Width, Canvas.ClientRectangle.Height);
                }
            }
            Canvas.Invalidate();
        }

        private void setBrushSquare_Click(object sender, EventArgs e)
        {
            brushType = "square";
            Console.WriteLine("Brush shape changed to square.");
        }

        private void setBrushCircle_Click(object sender, EventArgs e)
        {
            brushType = "circle";
            Console.WriteLine("Brush shape changed to circle.");
        }

        private void brushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            color = ColorDialog.Color;
            Console.WriteLine("Canvas changed to Custom Color");
        }
    }
}