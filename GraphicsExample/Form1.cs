using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
            Graphics g = this.CreateGraphics();
            Pen DrawPen = new Pen(Color.Red, 10);
            SolidBrush DrawBrush = new SolidBrush(Color.Black);
            g.Clear(Color.White);
            g.DrawLine(DrawPen, 0, 0, 300, 100);
            g.DrawRectangle(DrawPen, 30, 30, 50, 150);
            g.FillRectangle(DrawBrush, 30, 30, 100, 200);

            g.DrawEllipse(DrawPen, 25, 25, 200, 100);
            g.FillEllipse(DrawBrush, 55, 55, 100, 100);

            g.DrawArc(DrawPen, 50, 50, 50, 50, 100, 300);
            g.DrawPie(DrawPen, 20, 20, 50, 50, 30, 45);
            g.FillPie(DrawBrush, 130, 160, 50, 50, 90, 180);
            Font DrawFont = new Font("Arial", 16, FontStyle.Bold);
            g.DrawString("Hello", DrawFont, DrawBrush, 150, 80);

            //this is a test
        }
    }
}