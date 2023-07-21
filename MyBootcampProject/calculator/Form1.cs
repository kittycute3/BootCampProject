using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        const string _password = "пароль";
        public Form1()
        {
            InitializeComponent();
        }

        private void lbllCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enterPassword:
            string password = Form2.Show("password", "скажи пароль:");
            if(password == "")
            {
                this.Close();
            }

            if (password != _password && password != "")
            {
                MessageBox.Show("Error!\nTry again", "Неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto enterPassword;
            }

        }
    }
}
