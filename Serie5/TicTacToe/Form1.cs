using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        //0 = user, 1=computer
        int playerPlaying = 0;

        public MainForm()
        {
            InitializeComponent();

            //Subscrib method button1_click2 to button1's click event
            this.button1.Click += new System.EventHandler(this.button1_click2);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "X";
        }
        private void button1_click2(object sender, EventArgs e)
        {
            this.button1.BackColor =Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = "X";
        }
    }
    public class state
    {
        private string[,] value;

        public state()
        {
            this.value = new string[3,3];
        }


        public bool win()
        {
            string tmp = value[0, 0];

            if (tmp == value[0, 1] && tmp == value[0, 2])
                return true;
            
            
            /*for(int i=0;i<3;i++)
            {
                value[0,i]
            }*/
        }

    }
}
