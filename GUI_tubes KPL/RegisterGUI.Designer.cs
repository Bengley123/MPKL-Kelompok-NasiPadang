﻿namespace GUI_tubes_KPL
{
    partial class RegisterGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterGUI));
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.cpassword = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.cpasswordText = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(128, 202);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 16);
            this.email.TabIndex = 1;
            this.email.Text = "Email:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(128, 260);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            // 
            // cpassword
            // 
            this.cpassword.AutoSize = true;
            this.cpassword.Location = new System.Drawing.Point(128, 308);
            this.cpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpassword.Name = "cpassword";
            this.cpassword.Size = new System.Drawing.Size(117, 16);
            this.cpassword.TabIndex = 3;
            this.cpassword.Text = "Confirm password:";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(297, 137);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(132, 22);
            this.usernameText.TabIndex = 4;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(297, 202);
            this.emailText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(132, 22);
            this.emailText.TabIndex = 5;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(297, 260);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(132, 22);
            this.passwordText.TabIndex = 6;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // cpasswordText
            // 
            this.cpasswordText.Location = new System.Drawing.Point(297, 308);
            this.cpasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpasswordText.Name = "cpasswordText";
            this.cpasswordText.Size = new System.Drawing.Size(132, 22);
            this.cpasswordText.TabIndex = 7;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(128, 137);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 16);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(297, 362);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(136, 41);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(120, 362);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(132, 41);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // RegisterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 494);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.cpasswordText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.cpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterGUI";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label cpassword;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox cpasswordText;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button loginbtn;
    }
}