using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class CG : Form
    {
        #region Variables
        public static int width;
        public static int height;
        List<int> listx;
        List<int> listy;
        Color color;
       
        #endregion
        #region Constractor
        public CG()
        {
            InitializeComponent();
            DDA.Checked = true;
            color = Color.White;
            width = image.Width;
            height = image.Height;
            listx = new List<int>(); 
            listy = new List<int>(); 
        }
        #endregion
        #region Button Draw
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                #region DDA 
                if (DDA.Checked)
                {
                    clear();
                    DDA dDA = new DDA(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text));
                    dDA.Draw();
                    listx = dDA.X;
                    listy = dDA.Y;
                }
                #endregion
                #region Bresenham
                else if (Bresenham.Checked)
                {
                    clear();
                    Bresenham r = new Bresenham(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text));
                    r.Draw();
                    listx = r.X;
                    listy = r.Y;
                }
                #endregion
                #region Circle
                else if (C.Checked)
                {
                    clear();
                    Circle circle = new Circle(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text));
                    circle.Draw();
                    listx = circle.X;
                    listy = circle.Y;
                }
                #endregion
                #region Elipse
                else if (E.Checked)
                {
                    clear();
                    Elipse elipse = new Elipse(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text));
                    elipse.Draw();
                    listx = elipse.X;
                    listy = elipse.Y;
                }
                #endregion

                #region code Draw
                Bitmap Draw = new Bitmap(image.Width, image.Height);
                int j = 0;
                foreach (var i in listx)
                {
                    Value.Items.Add(" ( " + (i) + " , " + listy[j] + "  )");
                    Draw.SetPixel(i, listy[j], color);
                    j++;
                }
                image.Image = Draw;
               
                #endregion
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Opps!", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Methods Not important 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lX1.Text = "Xc"; lX2.Text = "R "; LY1.Text = "Yc";
            lY2.Visible = Y2.Visible = false; clear();
            Text = "Computer Graphics : " + C.Text;

            X1.Text = "" + 50;
            Y1.Text = "" + 60;
            X2.Text = "" + 70;
            //Y2.Text = "" + 300;
        }

        private void DDA_CheckedChanged(object sender, EventArgs e)
        {
            lX1.Text = "X1"; lX2.Text = "X2"; LY1.Text = "Y1"; lY2.Visible = Y2.Visible = true; lY2.Text = "Y2"; clear();
            Text = "Computer Graphics : " + DDA.Text;
        }

        private void Bresenham_CheckedChanged(object sender, EventArgs e)
        {
            lX1.Text = "X1"; lX2.Text = "X2"; LY1.Text = "Y1"; lY2.Visible = Y2.Visible = true; lY2.Text = "Y2"; clear();
            Text = "Computer Graphics : " + Bresenham.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lX1.Text = "Xc"; lX2.Text = "Rx"; LY1.Text = "Yc"; lY2.Visible = Y2.Visible = true; lY2.Text = "Ry"; clear();
            Text = "Computer Graphics : " + E.Text;
            X1.Text = "" + 100;
            Y1.Text = "" + 50;
            X2.Text = "" + 120;
            Y2.Text = "" + 50;
        }
        void clear()
        {
            if (image.Image != null)
            {
                image.Image = null;
                Value.Items.Clear();
            }
        }

        private void ColorSelcted_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorSelcted.SelectedIndex == 0)
            {
                color = Color.Red;
            }
            else if (ColorSelcted.SelectedIndex == 1)
            {
                color = Color.Green;
            }
            else
            {
                color = Color.Blue;
            }
            SCL.ForeColor = color;
            if (image.Image != null)
                button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            Y1.Text = Y2.Text = X1.Text = X2.Text = null;
        }

        private void CG_Load(object sender, EventArgs e)
        {
            X1.Text = "" + 150;
            Y1.Text = "" + 150;
            X2.Text = "" + 400;
            Y2.Text = "" + 300;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                button1_Click(null, null);
            }
            else if (keyData == Keys.Delete)
            {
                clear();
                Y1.Text = Y2.Text = X1.Text = X2.Text = null;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        Control ctrl;
        private void KeyDowns(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;

            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
        }
        #endregion
        private void translate_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> point = new transformation().translate(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text), int.Parse(Tx.Text), int.Parse(Ty.Text));
                clear();
                if (DDA.Checked)
                {

                    DDA dDA = new DDA(point[0], point[1], point[2], point[3]);
                    dDA.Draw();
                    listx = dDA.X;
                    listy = dDA.Y;

                }
                else if (Bresenham.Checked)
                {
                    Bresenham dDA = new Bresenham(point[0], point[1], point[2], point[3]);
                    dDA.Draw();
                    listx = dDA.X;
                    listy = dDA.Y;
                }
                else if (C.Checked)
                {
                    clear();
                    Circle circle = new Circle(point[0], point[1], int.Parse(X2.Text));
                    circle.Draw();
                    listx = circle.X;
                    listy = circle.Y;
                }
                X1.Text = point[0].ToString();
                Y1.Text = point[1].ToString();
                X2.Text = point[2].ToString();
                Y2.Text = point[3].ToString();
                #region code Draw
                Bitmap Draw = new Bitmap(image.Width, image.Height);
                int j = 0;
                foreach (var i in listx)
                {
                    Value.Items.Add(" ( " + (i) + " , " + listy[j] + "  )");
                    Draw.SetPixel(i, listy[j], color);
                    j++;
                }
                image.Image = Draw;
                #endregion
            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!", MessageBoxButtons.OK);
            }
        }

        private void Rotate_Click(object sender, EventArgs e)
        {

            try
            {
                List<int> point = new transformation().Rotate(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text), double.Parse(Angle.Text));
                clear();
                if (DDA.Checked)
                {

                    DDA dDA = new DDA(point[0], point[1], point[2], point[3]);
                    dDA.Draw();
                    listx = dDA.X;
                    listy = dDA.Y;

                }
                else if (Bresenham.Checked)
                {
                    Bresenham dDA = new Bresenham(point[0], point[1], point[2], point[3]);
                    dDA.Draw();
                    listx = dDA.X;
                    listy = dDA.Y;
                }
                X1.Text = point[0].ToString();
                Y1.Text = point[1].ToString();
                X2.Text = point[2].ToString();
                Y2.Text = point[3].ToString();
                #region code Draw
                Bitmap Draw = new Bitmap(image.Width, image.Height);
                int j = 0;
                foreach (var i in listx)
                {
                    Value.Items.Add(" ( " + (i) + " , " + listy[j] + "  )");
                    Draw.SetPixel(i, listy[j], color);
                    j++;
                }
                image.Image = Draw;
                #endregion
            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!", MessageBoxButtons.OK);
            }
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> point = new transformation().Scale(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(X2.Text), int.Parse(Y2.Text), double.Parse(Sx.Text), double.Parse(Sy.Text));
                clear();
                if (DDA.Checked)
                {

                    DDA dDA = new DDA(point[0], point[1], point[2], point[3]);
                    dDA.Draw();
                    listx = dDA.X;
                    listy = dDA.Y;

                }
                else if (Bresenham.Checked)
                {

                  Bresenham dDA = new Bresenham(point[0], point[1], point[2], point[3]);
                    dDA.Draw();
                    listx = dDA.X;
                    listy = dDA.Y;
                }
                X1.Text = point[0].ToString();
                Y1.Text = point[1].ToString();
                X2.Text = point[2].ToString();
                Y2.Text = point[3].ToString();
                #region code Draw
                Bitmap Draw = new Bitmap(image.Width, image.Height);
                int j = 0;
                foreach (var i in listx)
                {
                    Value.Items.Add(" ( " + (i) + " , " + listy[j] + "  )");
                    Draw.SetPixel(i, listy[j], color);
                    j++;
                }
                image.Image = Draw;
                #endregion
            }
            catch(Exception ex) {
                button1_Click(null,null);
                MessageBox.Show(ex.Message, "OOps!", MessageBoxButtons.OK);
            }
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void Value_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}