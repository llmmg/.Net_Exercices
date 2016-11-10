using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Author: Lancelot Magnin*/


namespace TicTacToe
{
    public partial class MainForm : Form
    {
        //%2=0 => user, %2=1=>computer
        int playerPlaying = 0;
        Button[] allBtn;

        public MainForm()
        {
            InitializeComponent();



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
                btn.Text = "O";
            }

            btn.BackColor = Color.AliceBlue;
            btn.Enabled = false;

            //check if there's a win pattern
            if (win())
            {
                this.BackColor = Color.Pink;
                if (playerPlaying % 2 == 0)
                {
                    this.label1.Text = "USER WIN!!!!";
                }
                else
                {
                    this.label1.Text = "COMPUTER WIN!!!";
                }

            }
            else
            {
                playerPlaying++;
            }


            if (playerPlaying > 9)
            {
                this.label1.Text = "END GAME";
            }
            label2.Text = playerPlaying.ToString();
        }

        /***
         * 
         * play random value
         *
         * **/
        private void botPlay()
        {
            Random rnd = new Random();
            int val = rnd.Next(0, 9);
            while (allBtn[val].Enabled == false && playerPlaying < 8)
            {
                val=rnd.Next(0, 9);
            }

            play(allBtn[val]);

        }

        private void click(object sender, EventArgs e)
        {
            Button mybtn= (Button)sender;

            if(mybtn.Enabled)
            {
                play(mybtn);   
                        
                botPlay();
            }

            

        }

        public bool win()
        {
            // 0 1 2
            // 3 4 5
            // 6 7 8

            
            if (allBtn[0].Text == allBtn[1].Text && allBtn[1].Text == allBtn[2].Text && allBtn[0].Text!="")
            {
                return true;
            }
            else if (allBtn[3].Text == allBtn[4].Text && allBtn[4].Text == allBtn[5].Text && allBtn[3].Text != "")
            {
                return true;
            }
            else if (allBtn[6].Text == allBtn[7].Text && allBtn[7].Text == allBtn[8].Text && allBtn[6].Text != "")
            {
                return true;
            }
            else if (allBtn[0].Text == allBtn[3].Text && allBtn[3].Text == allBtn[6].Text && allBtn[0].Text != "")
            {
                return true;
            }
            else if (allBtn[1].Text == allBtn[4].Text && allBtn[4].Text == allBtn[7].Text && allBtn[1].Text != "")
            {
                return true;
            }else if(allBtn[2].Text == allBtn[5].Text && allBtn[5].Text == allBtn[8].Text && allBtn[2].Text != "")
            {
                return true;
            }else if (allBtn[0].Text == allBtn[4].Text && allBtn[4].Text == allBtn[8].Text && allBtn[0].Text != "")
            {
                return true;
            }else if (allBtn[2].Text == allBtn[4].Text && allBtn[4].Text == allBtn[6].Text && allBtn[2].Text != "")
            {
                return true;
            }

            return false;
        }
    }

    //state object, used to know what would be the optimal next play according to actual state...
    /*public class state
    {
        private string[,] value; //actual state 

        public state()
        {
            this.value = new string[3, 3];
        }


        public bool win()
        {
            string tmp = value[0, 0];

            if (tmp == value[0, 1] && tmp == value[0, 2])
                return true;

            
            for(int i=0;i<3;i++)
            {
                if (value[0, i] != tmp)
                    return false;
            }

            return false;
        }

    }*/
}
