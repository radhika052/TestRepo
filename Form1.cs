using System;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = GetMessage(textBox1.Text);
        }

        public string GetMessage(string name)
        {
            var msg= "Hi " + name + "! How are you doing today?";
            return msg;
        }

        public string GetMessageWithFullName(string title, string firstname, string lastname)
        {
            var msg = "Hi " + title + " " + firstname + " " + lastname + "! How are you doing today?";
            return msg;
        }
    }
}
