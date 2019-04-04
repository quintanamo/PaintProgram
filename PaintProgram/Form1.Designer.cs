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
            this.clearButton = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.BrushSizeLabel = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.SaveButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CanvasColorButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.undoButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.brushShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBrushSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.setBrushCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.brushColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.Toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(12, 37);
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
            this.trackBar1.Location = new System.Drawing.Point(468, 443);
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
            this.Black.Location = new System.Drawing.Point(12, 449);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(25, 25);
            this.Black.TabIndex = 3;
            this.Black.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Black_MouseClick);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(43, 449);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(25, 25);
            this.White.TabIndex = 4;
            this.White.MouseClick += new System.Windows.Forms.MouseEventHandler(this.White_MouseClick);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(74, 449);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(25, 25);
            this.Red.TabIndex = 5;
            this.Red.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Red_MouseClick);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.Location = new System.Drawing.Point(105, 449);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(25, 25);
            this.Orange.TabIndex = 6;
            this.Orange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Orange_MouseClick);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(136, 449);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(25, 25);
            this.Yellow.TabIndex = 7;
            this.Yellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Yellow_MouseClick);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(167, 449);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(25, 25);
            this.Green.TabIndex = 8;
            this.Green.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Green_MouseClick);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(198, 449);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(25, 25);
            this.Blue.TabIndex = 9;
            this.Blue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Blue_MouseClick);
            // 
            // Indigo
            // 
            this.Indigo.BackColor = System.Drawing.Color.Indigo;
            this.Indigo.Location = new System.Drawing.Point(229, 449);
            this.Indigo.Name = "Indigo";
            this.Indigo.Size = new System.Drawing.Size(25, 25);
            this.Indigo.TabIndex = 10;
            this.Indigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Indigo_MouseClick);
            // 
            // Violet
            // 
            this.Violet.BackColor = System.Drawing.Color.Violet;
            this.Violet.Location = new System.Drawing.Point(260, 449);
            this.Violet.Name = "Violet";
            this.Violet.Size = new System.Drawing.Size(25, 25);
            this.Violet.TabIndex = 11;
            this.Violet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Violet_MouseClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(343, 449);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 25);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear Canvas";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // BrushSizeLabel
            // 
            this.BrushSizeLabel.AutoSize = true;
            this.BrushSizeLabel.Location = new System.Drawing.Point(449, 455);
            this.BrushSizeLabel.Name = "BrushSizeLabel";
            this.BrushSizeLabel.Size = new System.Drawing.Size(13, 13);
            this.BrushSizeLabel.TabIndex = 14;
            this.BrushSizeLabel.Text = "2";
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png " +
    "Image (.png)|*.png";
            // 
            // Toolbar
            // 
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.toolStripSeparator1,
            this.CanvasColorButton,
            this.toolStripSeparator2,
            this.undoButton,
            this.toolStripSeparator3,
            this.toolsDropDown});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(584, 25);
            this.Toolbar.TabIndex = 15;
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(31, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CanvasColorButton
            // 
            this.CanvasColorButton.Name = "CanvasColorButton";
            this.CanvasColorButton.Size = new System.Drawing.Size(96, 22);
            this.CanvasColorButton.Text = "Set Canvas Color";
            this.CanvasColorButton.Click += new System.EventHandler(this.CanvasColorButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // undoButton
            // 
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(36, 22);
            this.undoButton.Text = "Undo";
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolsDropDown
            // 
            this.toolsDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brushShapeToolStripMenuItem,
            this.brushColorToolStripMenuItem});
            this.toolsDropDown.Image = ((System.Drawing.Image)(resources.GetObject("toolsDropDown.Image")));
            this.toolsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsDropDown.Name = "toolsDropDown";
            this.toolsDropDown.Size = new System.Drawing.Size(48, 22);
            this.toolsDropDown.Text = "Tools";
            // 
            // brushShapeToolStripMenuItem
            // 
            this.brushShapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setBrushSquare,
            this.setBrushCircle});
            this.brushShapeToolStripMenuItem.Name = "brushShapeToolStripMenuItem";
            this.brushShapeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.brushShapeToolStripMenuItem.Text = "Brush Shape";
            // 
            // setBrushSquare
            // 
            this.setBrushSquare.Name = "setBrushSquare";
            this.setBrushSquare.Size = new System.Drawing.Size(110, 22);
            this.setBrushSquare.Text = "Square";
            this.setBrushSquare.Click += new System.EventHandler(this.setBrushSquare_Click);
            // 
            // setBrushCircle
            // 
            this.setBrushCircle.Name = "setBrushCircle";
            this.setBrushCircle.Size = new System.Drawing.Size(110, 22);
            this.setBrushCircle.Text = "Circle";
            this.setBrushCircle.Click += new System.EventHandler(this.setBrushCircle_Click);
            // 
            // brushColorToolStripMenuItem
            // 
            this.brushColorToolStripMenuItem.Name = "brushColorToolStripMenuItem";
            this.brushColorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.brushColorToolStripMenuItem.Text = "Brush Color";
            this.brushColorToolStripMenuItem.Click += new System.EventHandler(this.brushColorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 486);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.BrushSizeLabel);
            this.Controls.Add(this.clearButton);
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
            this.MaximumSize = new System.Drawing.Size(600, 525);
            this.MinimumSize = new System.Drawing.Size(600, 525);
            this.Name = "Form1";
            this.Text = "Paint by Quintin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
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
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label BrushSizeLabel;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.ToolStrip Toolbar;
        private System.Windows.Forms.ToolStripLabel SaveButton;
        private System.Windows.Forms.ToolStripLabel CanvasColorButton;
        private System.Windows.Forms.ToolStripLabel undoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolsDropDown;
        private System.Windows.Forms.ToolStripMenuItem brushShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBrushSquare;
        private System.Windows.Forms.ToolStripMenuItem setBrushCircle;
        private System.Windows.Forms.ToolStripMenuItem brushColorToolStripMenuItem;
    }
}

