using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 總整理
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static string numbers;
        static List<string> nums;
        static int count =0;
        public static int play;
        private void button1_Click(object sender, EventArgs e)
        {
            count = count + 1;
            byte A = 0, B = 0;
            string guess = textBox2.Text;
            if (Nomul(guess)==false)
            {
                textBox2.Text = "";
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                if (nums[i] == guess[i].ToString())
                {
                    A++;
                    continue;
                }

                for (int j = 0; j < 4; j++)
                {
                    
                    if (nums[i] == guess[j].ToString())
                    {
                        B++;
                    }
                }
            }
            string view = ($"{A}A{B}B");
            textBox1.Enabled = false;
            textBox1.Text = textBox1.Text + "\r\n" + textBox2.Text + "\t" + view;
            if (A == 4)
            {
                label2.ForeColor = Color.Red;
                label2.Text = $"答對了是{numbers}";
                textBox1.Text = textBox1.Text + "\r\n" + $"總共猜了{count}次";
                button2.Enabled = true;
                button1.Enabled = false;
                textBox2.Enabled = false;
                play = play + 1;
            }
            textBox2.Text = "";
            textBox2.Focus();

        }
        static public List<string> GetNumber()
        {
            nums = new List<string>();
            Random ran = new Random();
            string num;
            for (int i = 0; i < 4; i++)
            {
                num = (ran.Next(0, 10)).ToString();
                while (nums.Contains(num) == true)
                {
                    num = (ran.Next(0, 10)).ToString();
                }
                nums.Add(num);
            }
            return nums;
        }
        static public bool Nomul(string n)
        {
            if (n.Length != 4)
            {
                MessageBox.Show("請輸入4個數字");
                return false;
            }
            else if (n.Length == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (n.IndexOf((n[i].ToString())) != 3)
                    {
                        int num = 0;
                        num = n.IndexOf((n[i].ToString()));
                        if (n.IndexOf((n[i].ToString()), num + 1, 3 - num) != -1)
                        {
                            MessageBox.Show("請輸入不重複的數字");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "小記事本";
            label3.Text = $"局數:{play}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nums = GetNumber();
            numbers = nums[0] + nums[1] + nums[2] + nums[3];
            label2.ForeColor = Color.Blue;
            textBox1.Text = "小記事本";
            button2.Enabled = false;
            button1.Enabled = true;
            count = 0;
            textBox2.Enabled = true;
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
