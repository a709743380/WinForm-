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
    public partial class Form2 : Form
    {
        public static string name { get; set; } = "";
        public static string ID { get; set; } = "";
        public  static string Passwd { get; set; } = "";
          
        
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool id1 = Regex.IsMatch(textBox2.Text, "^[a-z0-9A-Z]{6,}$");
            bool id2 = Regex.IsMatch(textBox3.Text, "^[a-zA-Z]{1,}[0-9]{4,}$");
            if (id1 == true)
            { 
                if( id2 == true )
                {
                    if(textBox3.Text == textBox4.Text)
                    {
                        ID = textBox2.Text;
                        Passwd= textBox3.Text;
                        name = textBox1.Text;
                        MessageBox.Show("賬號創立成功", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("此密碼不相同", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("密碼格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("賬號格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
