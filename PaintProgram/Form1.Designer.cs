namespace PaintProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Canvas = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Black = new System.Windows.Forms.Panel();
            this.White = new System.Windows.Forms.Panel();
            this.Red = new System.Windows.Forms.Panel();
            this.Orange = new System.Windows.Forms.Panel();
            this.Yellow = new System.Windows.Forms.Panel();
            this.Green = new System.Windows.Forms.Panel();
            this.Blue = new System.Windows.Forms.Panel();
            this.Indigo = new System.Windows.Forms.Panel();
            this.Violet = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomColor = new System.Windows.Forms.Panel();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.BrushSizeLabel = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(560, 400);
            this.Canvas.TabIndex = 0;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(468, 418);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 31);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(12, 424);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(25, 25);
            this.Black.TabIndex = 3;
            this.Black.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Black_MouseClick);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(43, 424);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(25, 25);
            this.White.TabIndex = 4;
            this.White.MouseClick += new System.Windows.Forms.MouseEventHandler(this.White_MouseClick);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(74, 424);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(25, 25);
            this.Red.TabIndex = 5;
            this.Red.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Red_MouseClick);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.Location = new System.Drawing.Point(105, 424);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(25, 25);
            this.Orange.TabIndex = 6;
            this.Orange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Orange_MouseClick);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(136, 424);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(25, 25);
            this.Yellow.TabIndex = 7;
            this.Yellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Yellow_MouseClick);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(167, 424);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(25, 25);
            this.Green.TabIndex = 8;
            this.Green.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Green_MouseClick);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(198, 424);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(25, 25);
            this.Blue.TabIndex = 9;
            this.Blue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Blue_MouseClick);
            // 
            // Indigo
            // 
            this.Indigo.BackColor = System.Drawing.Color.Indigo;
            this.Indigo.Location = new System.Drawing.Point(229, 424);
            this.Indigo.Name = "Indigo";
            this.Indigo.Size = new System.Drawing.Size(25, 25);
            this.Indigo.TabIndex = 10;
            this.Indigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Indigo_MouseClick);
            // 
            // Violet
            // 
            this.Violet.BackColor = System.Drawing.Color.Violet;
            this.Violet.Location = new System.Drawing.Point(260, 424);
            this.Violet.Name = "Violet";
            this.Violet.Size = new System.Drawing.Size(25, 25);
            this.Violet.TabIndex = 11;
            this.Violet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Violet_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear Canvas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomColor
            // 
            this.CustomColor.BackColor = System.Drawing.Color.White;
            this.CustomColor.Location = new System.Drawing.Point(291, 424);
            this.CustomColor.Name = "CustomColor";
            this.CustomColor.Size = new System.Drawing.Size(25, 25);
            this.CustomColor.TabIndex = 13;
            this.CustomColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CustomColor_MouseClick);
            // 
            // BrushSizeLabel
            // 
            this.BrushSizeLabel.AutoSize = true;
            this.BrushSizeLabel.Location = new System.Drawing.Point(449, 430);
            this.BrushSizeLabel.Name = "BrushSizeLabel";
            this.BrushSizeLabel.Size = new System.Drawing.Size(13, 13);
            this.BrushSizeLabel.TabIndex = 14;
            this.BrushSizeLabel.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BrushSizeLabel);
            this.Controls.Add(this.CustomColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Violet);
            this.Controls.Add(this.Indigo);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Paint by Quintin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel Black;
        private System.Windows.Forms.Panel White;
        private System.Windows.Forms.Panel Red;
        private System.Windows.Forms.Panel Orange;
        private System.Windows.Forms.Panel Yellow;
        private System.Windows.Forms.Panel Green;
        private System.Windows.Forms.Panel Blue;
        private System.Windows.Forms.Panel Indigo;
        private System.Windows.Forms.Panel Violet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel CustomColor;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label BrushSizeLabel;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}

