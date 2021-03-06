﻿namespace AcademicIS
{
    partial class LoginForm
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
            this.loginButton = new FlatUI.FlatButton();
            this.passwordLabel = new FlatUI.FlatLabel();
            this.usernameTB = new FlatUI.FlatTextBox();
            this.passwordTB = new FlatUI.FlatTextBox();
            this.titleLabel = new FlatUI.FlatLabel();
            this.alertBox = new FlatUI.FlatAlertBox();
            this.usernameLabel = new FlatUI.FlatLabel();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginButton.Location = new System.Drawing.Point(351, 255);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rounded = false;
            this.loginButton.Size = new System.Drawing.Size(106, 32);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(263, 208);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(42, 20);
            this.passwordLabel.TabIndex = 99;
            this.passwordLabel.Text = "Şifre:";
            this.passwordLabel.Visible = false;
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.Transparent;
            this.usernameTB.FocusOnHover = false;
            this.usernameTB.Location = new System.Drawing.Point(311, 158);
            this.usernameTB.MaxLength = 32767;
            this.usernameTB.Multiline = false;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.ReadOnly = false;
            this.usernameTB.Size = new System.Drawing.Size(186, 29);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTB.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernameTB.UseSystemPasswordChar = false;
            // 
            // passwordTB
            // 
            this.passwordTB.AccessibleName = "";
            this.passwordTB.BackColor = System.Drawing.Color.Transparent;
            this.passwordTB.FocusOnHover = false;
            this.passwordTB.Location = new System.Drawing.Point(311, 206);
            this.passwordTB.MaxLength = 32767;
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.ReadOnly = false;
            this.passwordTB.Size = new System.Drawing.Size(186, 29);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTB.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(337, 97);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(127, 25);
            this.titleLabel.TabIndex = 99;
            this.titleLabel.Text = "Yönetici Girişi";
            this.titleLabel.Visible = false;
            // 
            // alertBox
            // 
            this.alertBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.alertBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.alertBox.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.alertBox.Location = new System.Drawing.Point(12, 371);
            this.alertBox.Name = "alertBox";
            this.alertBox.Size = new System.Drawing.Size(771, 42);
            this.alertBox.TabIndex = 100;
            this.alertBox.Text = "Kullanıcı adı ve/veya şifre hatalı!";
            this.alertBox.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(210, 161);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(95, 20);
            this.usernameLabel.TabIndex = 99;
            this.usernameLabel.Text = "Kullanıcı Adı:";
            this.usernameLabel.Visible = false;
            // 
            // background
            // 
            this.background.ErrorImage = null;
            this.background.InitialImage = global::AcademicIS.Properties.Resources.login;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(795, 425);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.background.TabIndex = 101;
            this.background.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.alertBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.background);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatButton loginButton;
        private FlatUI.FlatLabel passwordLabel;
        private FlatUI.FlatTextBox usernameTB;
        private FlatUI.FlatTextBox passwordTB;
        private FlatUI.FlatLabel titleLabel;
        private FlatUI.FlatAlertBox alertBox;
        private System.Windows.Forms.PictureBox background;
        private FlatUI.FlatLabel usernameLabel;
    }
}