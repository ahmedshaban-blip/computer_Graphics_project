
namespace Project
{
    partial class CG
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lX1 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.LY1 = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.lX2 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.TextBox();
            this.lY2 = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.DDA = new System.Windows.Forms.RadioButton();
            this.Bresenham = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.E = new System.Windows.Forms.RadioButton();
            this.image = new System.Windows.Forms.PictureBox();
            this.Value = new System.Windows.Forms.ListBox();
            this.ColorSelcted = new System.Windows.Forms.ComboBox();
            this.SCL = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.translate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ty = new System.Windows.Forms.TextBox();
            this.Tx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lab = new System.Windows.Forms.Label();
            this.Rotate = new System.Windows.Forms.Button();
            this.Angle = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Sy = new System.Windows.Forms.TextBox();
            this.Sx = new System.Windows.Forms.TextBox();
            this.Scale = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lX1);
            this.flowLayoutPanel1.Controls.Add(this.X1);
            this.flowLayoutPanel1.Controls.Add(this.LY1);
            this.flowLayoutPanel1.Controls.Add(this.Y1);
            this.flowLayoutPanel1.Controls.Add(this.lX2);
            this.flowLayoutPanel1.Controls.Add(this.X2);
            this.flowLayoutPanel1.Controls.Add(this.lY2);
            this.flowLayoutPanel1.Controls.Add(this.Y2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(112, 30);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 60);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lX1
            // 
            this.lX1.AutoSize = true;
            this.lX1.Location = new System.Drawing.Point(3, 0);
            this.lX1.Name = "lX1";
            this.lX1.Size = new System.Drawing.Size(25, 17);
            this.lX1.TabIndex = 0;
            this.lX1.Text = "X1";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(34, 2);
            this.X1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 22);
            this.X1.TabIndex = 1;
            this.X1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDowns);
            // 
            // LY1
            // 
            this.LY1.AutoSize = true;
            this.LY1.Location = new System.Drawing.Point(140, 0);
            this.LY1.Name = "LY1";
            this.LY1.Size = new System.Drawing.Size(25, 17);
            this.LY1.TabIndex = 2;
            this.LY1.Text = "Y1";
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(171, 2);
            this.Y1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(100, 22);
            this.Y1.TabIndex = 3;
            this.Y1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDowns);
            // 
            // lX2
            // 
            this.lX2.AutoSize = true;
            this.lX2.Location = new System.Drawing.Point(3, 26);
            this.lX2.Name = "lX2";
            this.lX2.Size = new System.Drawing.Size(25, 17);
            this.lX2.TabIndex = 4;
            this.lX2.Text = "X2";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(34, 28);
            this.X2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(100, 22);
            this.X2.TabIndex = 5;
            this.X2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDowns);
            // 
            // lY2
            // 
            this.lY2.AutoSize = true;
            this.lY2.Location = new System.Drawing.Point(140, 26);
            this.lY2.Name = "lY2";
            this.lY2.Size = new System.Drawing.Size(25, 17);
            this.lY2.TabIndex = 6;
            this.lY2.Text = "Y2";
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(171, 28);
            this.Y2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(100, 22);
            this.Y2.TabIndex = 7;
            this.Y2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDowns);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.DDA);
            this.flowLayoutPanel2.Controls.Add(this.Bresenham);
            this.flowLayoutPanel2.Controls.Add(this.C);
            this.flowLayoutPanel2.Controls.Add(this.E);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(163, 108);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(190, 57);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // DDA
            // 
            this.DDA.AutoSize = true;
            this.DDA.Location = new System.Drawing.Point(3, 2);
            this.DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(58, 21);
            this.DDA.TabIndex = 0;
            this.DDA.Text = "DDA";
            this.DDA.UseVisualStyleBackColor = true;
            this.DDA.CheckedChanged += new System.EventHandler(this.DDA_CheckedChanged);
            // 
            // Bresenham
            // 
            this.Bresenham.AutoSize = true;
            this.Bresenham.Location = new System.Drawing.Point(67, 2);
            this.Bresenham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bresenham.Name = "Bresenham";
            this.Bresenham.Size = new System.Drawing.Size(101, 21);
            this.Bresenham.TabIndex = 1;
            this.Bresenham.Text = "Bresenham";
            this.Bresenham.UseVisualStyleBackColor = true;
            this.Bresenham.CheckedChanged += new System.EventHandler(this.Bresenham_CheckedChanged);
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(3, 27);
            this.C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C.Name = "C";
            this.C.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.C.Size = new System.Drawing.Size(64, 21);
            this.C.TabIndex = 2;
            this.C.Text = "Circle";
            this.C.UseVisualStyleBackColor = true;
            this.C.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(73, 27);
            this.E.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(67, 21);
            this.E.TabIndex = 3;
            this.E.Text = "Elipse";
            this.E.UseVisualStyleBackColor = true;
            this.E.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.image.Location = new System.Drawing.Point(927, 12);
            this.image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(645, 592);
            this.image.TabIndex = 4;
            this.image.TabStop = false;
            this.image.WaitOnLoad = true;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // Value
            // 
            this.Value.FormattingEnabled = true;
            this.Value.ItemHeight = 16;
            this.Value.Location = new System.Drawing.Point(179, 260);
            this.Value.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(124, 308);
            this.Value.TabIndex = 5;
            this.Value.SelectedIndexChanged += new System.EventHandler(this.Value_SelectedIndexChanged);
            // 
            // ColorSelcted
            // 
            this.ColorSelcted.FormattingEnabled = true;
            this.ColorSelcted.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.ColorSelcted.Location = new System.Drawing.Point(421, 141);
            this.ColorSelcted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorSelcted.Name = "ColorSelcted";
            this.ColorSelcted.Size = new System.Drawing.Size(95, 24);
            this.ColorSelcted.TabIndex = 6;
            this.ColorSelcted.SelectedIndexChanged += new System.EventHandler(this.ColorSelcted_SelectedIndexChanged);
            // 
            // SCL
            // 
            this.SCL.AutoSize = true;
            this.SCL.Location = new System.Drawing.Point(432, 108);
            this.SCL.Name = "SCL";
            this.SCL.Size = new System.Drawing.Size(84, 17);
            this.SCL.TabIndex = 7;
            this.SCL.Text = "Select Color";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // translate
            // 
            this.translate.Location = new System.Drawing.Point(31, 41);
            this.translate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(69, 23);
            this.translate.TabIndex = 9;
            this.translate.Text = "translate";
            this.translate.UseVisualStyleBackColor = true;
            this.translate.Click += new System.EventHandler(this.translate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Ty);
            this.panel1.Controls.Add(this.translate);
            this.panel1.Controls.Add(this.Tx);
            this.panel1.Location = new System.Drawing.Point(469, 211);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 79);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tx";
            // 
            // Ty
            // 
            this.Ty.Location = new System.Drawing.Point(301, 42);
            this.Ty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ty.Name = "Ty";
            this.Ty.Size = new System.Drawing.Size(100, 22);
            this.Ty.TabIndex = 11;
            // 
            // Tx
            // 
            this.Tx.Location = new System.Drawing.Point(149, 42);
            this.Tx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(100, 22);
            this.Tx.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lab);
            this.panel2.Controls.Add(this.Rotate);
            this.panel2.Controls.Add(this.Angle);
            this.panel2.Location = new System.Drawing.Point(469, 294);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 79);
            this.panel2.TabIndex = 14;
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.Location = new System.Drawing.Point(121, 44);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(44, 17);
            this.Lab.TabIndex = 12;
            this.Lab.Text = "Angle";
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(31, 41);
            this.Rotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(69, 23);
            this.Rotate.TabIndex = 9;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(181, 41);
            this.Angle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(100, 22);
            this.Angle.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.Sy);
            this.panel3.Controls.Add(this.Sx);
            this.panel3.Controls.Add(this.Scale);
            this.panel3.Location = new System.Drawing.Point(469, 377);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 79);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(121, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Sx";
            // 
            // Sy
            // 
            this.Sy.Location = new System.Drawing.Point(301, 41);
            this.Sy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sy.Name = "Sy";
            this.Sy.Size = new System.Drawing.Size(100, 22);
            this.Sy.TabIndex = 15;
            // 
            // Sx
            // 
            this.Sx.Location = new System.Drawing.Point(149, 41);
            this.Sx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sx.Name = "Sx";
            this.Sx.Size = new System.Drawing.Size(100, 22);
            this.Sx.TabIndex = 14;
            // 
            // Scale
            // 
            this.Scale.Location = new System.Drawing.Point(31, 41);
            this.Scale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(69, 23);
            this.Scale.TabIndex = 9;
            this.Scale.Text = "Scale";
            this.Scale.UseVisualStyleBackColor = true;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // CG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1603, 636);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SCL);
            this.Controls.Add(this.ColorSelcted);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.image);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CG";
            this.Text = "Computer Graphics";
            this.Load += new System.EventHandler(this.CG_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lX1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Label LY1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.Label lX2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Label lY2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton DDA;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.RadioButton Bresenham;
        private System.Windows.Forms.ListBox Value;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton E;
        private System.Windows.Forms.ComboBox ColorSelcted;
        private System.Windows.Forms.Label SCL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button translate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lab;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ty;
        private System.Windows.Forms.TextBox Tx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Sy;
        private System.Windows.Forms.TextBox Sx;
        private System.Windows.Forms.Button Scale;
    }
}

