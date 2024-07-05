using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrnlBypasses
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // width of ellipse
    int nHeightEllipse // height of ellipse
);

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Set_background);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
                   private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
         private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(36, 36, 46), Color.FromArgb(55, 55, 65), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Bypass_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("ByFron Bypassed, click OK to close the tab.", "Bypass Correct", MessageBoxButtons.OK);
            Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("ByFron Bypassed, click OK to close the tab.", "Bypass Correct", MessageBoxButtons.OK);
            timer3.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity==1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity==0)
            {
                this.Close();
                Close();
            }
            Opacity -= .1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity==0)
            {
                this.Close();
                Close();
            }
            Opacity -= .1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
