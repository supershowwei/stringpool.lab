using System;
using System.Windows.Forms;

namespace StringPoolLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str1 = this.textBox2.Text;
            var str2 = string.Intern(this.textBox3.Text);
            var str3 = "aaa";
            var str4 = "aaa";

            this.textBox1.Text = string.Concat(
                $"{str1.Address()}\r\n{str2.Address()}\r\n",
                $"{str3.Address()}\r\n{str4.Address()}");
        }
    }
}