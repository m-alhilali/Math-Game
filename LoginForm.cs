using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Quiz_Master
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Form frm = new Quiz_Master();
        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            label1.Visible = true;

            while (progressBar1.Value < progressBar1.Maximum)
            {
                Thread.Sleep(100);
                progressBar1.Value+=5;
                label1.Text=(((float)progressBar1.Value/progressBar1.Maximum)*100)+"%";
                progressBar1.Update();
                label1.Update();
            }
            progressBar1.Value =0;

            progressBar1.Visible = false;
            label1.Visible = false;
            frm.ShowDialog();
        }

       
    }
}
