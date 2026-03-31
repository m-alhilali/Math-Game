namespace Quiz_Master
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginScreen = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(328, 269);
            this.textPassword.MaxLength = 30;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(288, 32);
            this.textPassword.TabIndex = 1;
            this.textPassword.Tag = "1234";
            this.textPassword.UseSystemPasswordChar = true;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Window;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPassword.Location = new System.Drawing.Point(334, 271);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Tag = "1234";
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Indigo;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(387, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // lblLoginScreen
            // 
            this.lblLoginScreen.AutoSize = true;
            this.lblLoginScreen.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginScreen.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.lblLoginScreen.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblLoginScreen.Location = new System.Drawing.Point(362, 206);
            this.lblLoginScreen.Name = "lblLoginScreen";
            this.lblLoginScreen.Size = new System.Drawing.Size(191, 31);
            this.lblLoginScreen.TabIndex = 5;
            this.lblLoginScreen.Text = "Login Screen";
            // 
            // checkBox1
            // 
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox1.Location = new System.Drawing.Point(308, 270);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Quiz_Master.Properties.Resources.BackGroundImageLoginScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 615);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblLoginScreen);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textPassword);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "Quiz Master";
            this.Enter += new System.EventHandler(this.btnLogin_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginScreen;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

