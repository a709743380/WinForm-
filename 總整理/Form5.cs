using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 總整理
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static int r;
        public static int w = 0;
        public static int d = 0;
        public static int l = 0;
        public static int t = 0;
        

        private void Form5_Load(object sender, EventArgs e)
        {
            c.Image = imageList1.Images[0];
            bu.Image= Image.FromFile("C:\\Users\\wwwhu\\source\\repos\\總整理\\總整理\\pic\\paper.png");
            dao.Image = Image.FromFile("C:\\Users\\wwwhu\\source\\repos\\總整理\\總整理\\pic\\scissors.png");
            shi.Image = Image.FromFile("C:\\Users\\wwwhu\\source\\repos\\總整理\\總整理\\pic\\stone.png");
            label2.Text = $"局數{w + d + l}  Win:{w}  Lost:{l}  Draw:{d}";
        }
        public static byte user =5;
        private void bu_Click(object sender, EventArgs e)
        {
            this.bu.Location = new System.Drawing.Point(95, 203);
            this.dao.Location = new System.Drawing.Point(310, 233);
            this.shi.Location = new System.Drawing.Point(558, 233);
            user = 0;
        }

        private void dao_Click(object sender, EventArgs e)
        {
            this.dao.Location = new System.Drawing.Point(310, 203);
            this.shi.Location = new System.Drawing.Point(558, 233);
            this.bu.Location = new System.Drawing.Point(95, 233);
            user = 1;
        }

        private void shi_Click(object sender, EventArgs e)
        {
            this.shi.Location = new System.Drawing.Point(558, 203);
            this.bu.Location = new System.Drawing.Point(95, 233);
            this.dao.Location = new System.Drawing.Point(310, 233);
            user = 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (user != 5)
            {
                Random ran = new Random();
                r = ran.Next(9, 12);
                Thread impic = new Thread(new ThreadStart(pic));
                impic.Start();
                impic.Join();

                int com = r % 3;
                if ((user == 0 && com == 2) || (user == 1 && com == 0) || (user == 2 && com == 1))
                {
                    label1.Text = "你贏了";
                    w = w + 1;

                }
                else if (user == com)
                {
                    label1.Text = "平手";
                    d = d + 1;
                }
                else
                {
                    label1.Text = "你輸了";
                    l = l+ 1;
                }
                
            }
            else
            {
                MessageBox.Show("請出拳");
            }
            t = 0;
            label2.Text =$"局數{w + d + l}  Win:{w}  Lost:{l}  Draw:{d}";

        }
        
        public void pic()
        {
            while (t <= r)
            {
                c.Image = imageList1.Images[t % 3];
                t =t+ 1;
                Thread.Sleep(50);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
