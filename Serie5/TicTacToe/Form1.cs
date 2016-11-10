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
        Button[] allBtn;

        public MainForm()
        {
            InitializeComponent();

            //Subscrib method button1_click2 to button1's click event
            this.button1.Click += new System.EventHandler(this.button1_click2);
            allBtn =new Button[]{this.button1,this.button2,this.button3,
                                this.button4,this.button5,this.button6,
                                this.button7,this.button8,this.button9};


        }
        private void play(Button btn)
        {
            if(playerPlaying%2==0)
            {
                btn.Text = "X";
            }
            else
            {
                btn.Text = "0";
            }
            playerPlaying++;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.button1.Text = "X";
            play(this.button1);
        }
        private void button1_click2(object sender, EventArgs e)
        {
            this.button1.BackColor =Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play(this.button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

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
            return false;
        }

    }
}
