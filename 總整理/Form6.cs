using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 總整理
{
    public partial class Form6 : Form
    {
       
        public Form6()
        {
            InitializeComponent();
        }
        static int min = 0;
        static int max = 100;
        static int rd = 0;
        static int game = 0;
        Random ran = new Random();
        public static int count = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool minnumber = Regex.IsMatch(inputmin.Text, "^[0-9]");
            bool maxnumber = Regex.IsMatch(inputmax.Text, "^[0-9]");
            if(!(minnumber && maxnumber))
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            if (inputmin.Text == "" || inputmax.Text== "" ){
                MessageBox.Show("請輸入範圍");
                return;
            }
            else if(Convert.ToInt32(inputmin.Text)> Convert.ToInt32(inputmax.Text))
            {
                min = Convert.ToInt32(inputmax.Text);
                max = Convert.ToInt32(inputmin.Text);
            }
            else
            {
                min = Convert.ToInt32(inputmin.Text);
                max = Convert.ToInt32(inputmax.Text);
            }
            rd = ran.Next(min, max + 1);
            label2.Text = min.ToString();
            label3.Text = max.ToString();
            groupBox1.Visible = false;
            inputguess.Enabled = true;
            groupBox2.Visible = true; 
            button1.Enabled = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  guess=0;
            count = count + 1;
            bool guessnumber = Regex.IsMatch(inputguess.Text, "^[0-9]");
            if (guessnumber)
            {
                 guess = Convert.ToInt32(inputguess.Text);
            }
            else
            {
                MessageBox.Show("請輸入數字");
                inputguess.Text = "";
                return;
            }
            int smaller = Convert.ToInt32(label2.Text);
            int larger = Convert.ToInt32(label3.Text);
            if (guess < min || guess > max)
            {
                MessageBox.Show("請輸入範圍内的數字");
                inputguess.Text = "";
                return;
            }
            if (guess < rd)
            {
                
                if (smaller<guess)
                {
                    label2.Text = guess.ToString();
                }
                label7.ForeColor = Color.Red;
                label7.Text = "再大些！！";
            }
            else if(guess > rd)
            {
                if (larger > guess)
                {
                    label7.ForeColor = Color.Black;
                    label3.Text = guess.ToString();
                }
                label7.Text = "再小些！！";
            }
            else
            {
                
                label1.Text = guess.ToString();
                label7.Text=$"恭喜你猜對了，猜了{count}次";
                count = 0;
                game = game + 1;
                label6.Text = game.ToString();
                button1.Enabled = false;
                button1.Visible = false;
                button3.Visible = true;
                inputguess.Enabled = false;

            }
            inputguess.Text = "";
            inputguess.Focus();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label2.Text = "小";
            label1.Text = "?";
            label3.Text = "大";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            DialogResult result= MessageBox.Show("是否重新設定範圍？", "詢問", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
            if (result == DialogResult.OK)
            {
                label7.Text = "請輸入數字";
                label2.Text = "小";
                label1.Text = "?";
                label3.Text = "大";
                groupBox2.Visible = false;
                groupBox1.Visible = true;
                button3.Visible = false;
            }
            else
            {
                rd = ran.Next(min, max + 1);
                label7.Text = "請輸入數字";
                label2.Text = min.ToString();
                label1.Text = "?";
                label3.Text = max.ToString();
                button3.Visible = false;
                button1.Visible = true;
                button1.Enabled = true;
                inputguess.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
