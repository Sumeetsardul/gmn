using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace summoit
{
    public partial class Form2 : Form
    {
        
        int l;
        
        int t = 2;
        int s;
        int sp;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\sunny\source\repos\summoit\res\1.gif");
            pictureBox1.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\sunny\source\repos\summoit\res\1.wav");
            player.Play();
            l = 1;


            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\sunny\source\repos\summoit\res\2.gif");
            pictureBox1.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\sunny\source\repos\summoit\res\1.wav");
            player.Play();
            Random rnd = new Random();
            //below code helps to pick random number between 1-7.
            s = rnd.Next(1, 7);

            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\sunny\source\repos\summoit\res\3.wav");
            player.Play();
            for (s = 0; s <= 2; s++) 
            {
                if (s == 0 && l == sp)
                {
                    MessageBox.Show("you won and your score is 100");
                    s = 5;
                    t = t - 1;
                }
                else if (s == 1 && l == sp)
                {
                    MessageBox.Show("you won and your score is 100");
                    s = 5;
                    t = t - 1;
                }
                else if (s == 2)
                {
                    MessageBox.Show("you won and your score is 500");
                    s = 5;
                    t = t - 1;
                }
                else
                {
                    if (sp == 6)
                    {
                        sp = 1;

                    }
                    else
                    {
                        sp++;
                    }
                }
            }
            if (t == 0)
            {
                button3.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                t = 2;
            }

                

            }
            

        }

     
    }
  

