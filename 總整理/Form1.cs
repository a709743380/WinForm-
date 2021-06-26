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
    public partial class Form1 : Form
    {

        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//注冊
        {
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (Form2.ID == textBox1.Text)
                {
                    if (Form2.Passwd == textBox2.Text)
                    {
                        this.Close();
                        Form3 f3 = new Form3();
                        f3.Show();
                    }
                    else
                    {
                        MessageBox.Show("密碼錯誤", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("賬號錯誤", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.ID;
            textBox2.Text = Form2.Passwd;
        }
    }
}
