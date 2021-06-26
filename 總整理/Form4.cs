using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 總整理
{
    public partial class Form4 : Form
    {
        Thread thread1;
        Thread thread2;
        Thread thread3;
        Thread thread4;
        Thread thread5;
        Random ran = new Random();
        static int c = 1;//排名
        string bet = "1";
        string win = "";
        public static int  count=0;
        int winer;
        int lost;
        const int line = 615;
        public delegate void MyInvoke(string n);
        private object locker = new object();
        List<TextBox> texboxs = new List<TextBox>();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            texboxs.Add(textBox1);
            texboxs.Add(textBox2);
            texboxs.Add(textBox3);
            texboxs.Add(textBox4);
            texboxs.Add(textBox5);
            button2.Enabled = false;
            label2.Text = $"局數:{count}  \t\t贏:{winer}  \t\tlost:{lost}";
        }
        public void UpdateForm(string n)
        {
            lock (locker)
            {
                int Run = ran.Next(0, 11);
                int runline = 0;
                switch (n)
                {
                    case "1":
                        this.textBox1.Location = new Point(textBox1.Location.X + Run, textBox1.Location.Y);
                        runline = textBox1.Location.X;
                        break;
                    case "2":
                        this.textBox2.Location = new Point(textBox2.Location.X + Run, textBox2.Location.Y);
                        runline = textBox2.Location.X;
                        break;
                    case "3":
                        this.textBox3.Location = new Point(textBox3.Location.X + Run, textBox3.Location.Y);
                        runline = textBox3.Location.X;
                        break;
                    case "4":
                        this.textBox4.Location = new Point(textBox4.Location.X + Run, textBox4.Location.Y);
                        runline = textBox4.Location.X;
                        break;
                    case "5":
                        this.textBox5.Location = new Point(textBox5.Location.X + Run, textBox5.Location.Y);
                        runline = textBox5.Location.X;
                        break;

                }
                if (runline >= line)
                {
                    texboxs[Convert.ToInt32(n) - 1].Text = c + "";
                    texboxs[Convert.ToInt32(n) - 1].Enabled = false;
                    if (c == 1)
                    {
                        win = n;
                    }

                    c++;
                    if (c == 6)
                    {
                        button2.Enabled = true;
                        if (win == bet)
                        {
                            MessageBox.Show("You are win");
                            winer = winer + 1;
                        }
                        else
                        {
                            MessageBox.Show("You are lost");
                            lost = lost + 1;
                        }

                        label2.Text = $"局數:{count}  \t\t贏:{winer}  \t\tlost:{lost}";
                    }
                }
            }

        }
        public void Run1()
        {
            string name = "1";
            MyInvoke m1 = new MyInvoke(UpdateForm);
            while (textBox1.Location.X < line)
            {
                int speed = ran.Next(90, 101);
                this.BeginInvoke(m1, name);
                Thread.Sleep(speed);
            }
        }
        public void Run2()
        {
            string name = "2";
            MyInvoke m2 = new MyInvoke(UpdateForm);
            while (textBox2.Location.X < line)
            {
                int speed = ran.Next(90, 101);
                this.BeginInvoke(m2, name);
                Thread.Sleep(speed);
            }
        }
        public void Run3()
        {
            string name = "3";
            MyInvoke m3 = new MyInvoke(UpdateForm);
            while (textBox3.Location.X < line)
            {
                int speed = ran.Next(90, 101);
                this.BeginInvoke(m3, name);
                Thread.Sleep(speed);
            }
        }
        public void Run4()
        {
            string name = "4";
            MyInvoke m4 = new MyInvoke(UpdateForm);
            while (textBox4.Location.X < line)
            {
                int speed = ran.Next(90, 101);
                this.BeginInvoke(m4, name);
                Thread.Sleep(speed);
            }
        }
        public void Run5()
        {
            string name = "5";
            MyInvoke m5 = new MyInvoke(UpdateForm);
            while (textBox5.Location.X < line)
            {
                int speed = ran.Next(90, 101);
                this.BeginInvoke(m5, name);
                Thread.Sleep(speed);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(Run1));
            thread2 = new Thread(new ThreadStart(Run2));
            thread3 = new Thread(new ThreadStart(Run3));
            thread4 = new Thread(new ThreadStart(Run4));
            thread5 = new Thread(new ThreadStart(Run5));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();

            button2.Enabled = false;
            button1.Enabled = false;
            count = count + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            for (int i = 0; i < 5; i++)
            {
                texboxs[Convert.ToInt32(i)].Enabled = true;
            }

            textBox1.Text = "1號";
            textBox2.Text = "2號";
            textBox3.Text = "3號";
            textBox4.Text = "4號";
            textBox5.Text = "5號";

            textBox1.Location = new Point(12, textBox1.Location.Y);
            textBox2.Location = new Point(12, textBox2.Location.Y);
            textBox3.Location = new Point(12, textBox3.Location.Y);
            textBox4.Location = new Point(12, textBox4.Location.Y);
            textBox5.Location = new Point(12, textBox5.Location.Y);

            c = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bet = "1";
            label1.Text = "您下注的1號";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bet = "2";
            label1.Text = "您下注的2號";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bet = "3";
            label1.Text = "您下注的3號";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            bet = "4";
            label1.Text = "您下注的4號";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            bet = "5";
            label1.Text = "您下注的5號";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
                f3.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
