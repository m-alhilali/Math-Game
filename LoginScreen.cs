using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Master
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool CheckFromUserAndPassword(string Password)
        {
            if(Password == textPassword.Tag.ToString()) 
            {
                return true;
            }
            return false;
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text != string.Empty)
            {
                lblPassword.Visible = false;
            }
            else
            {
                lblPassword.Visible = true;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightBlue;
            btnLogin.Size = new Size(btnLogin.Width+10,btnLogin.Height+5);

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Indigo;
            btnLogin.Size = new Size(btnLogin.Width - 10, btnLogin.Height - 5);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(CheckFromUserAndPassword(textPassword.Text))
            {
                Form quiz = new Quiz_Master();
                FormLogin formLogin = this;
                formLogin.Hide();
                quiz.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Password","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar= true;
            }
        }
    }
}
