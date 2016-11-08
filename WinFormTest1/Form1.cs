using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest1
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl1.Text = $"X:{e.X} Y:{e.Y}";
        }
        private void Form1_MouseMove2(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(e.X%255, e.Y%255, 100);
        }
    }
}
