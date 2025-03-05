using System;

namespace LibrarySystem
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.RegisterNewReader = new System.Windows.Forms.Button();
            this.UsernameLable = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.ChooseUserTypeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.Default;
            this.Username.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Username.Location = new System.Drawing.Point(377, 91);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(193, 31);
            this.Username.TabIndex = 0;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password
            // 
            this.Password.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Password.Location = new System.Drawing.Point(377, 145);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(193, 31);
            this.Password.TabIndex = 0;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(378, 308);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(192, 45);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // UserType
            // 
            this.UserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UserType.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UserType.FormattingEnabled = true;
            this.UserType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserType.Items.AddRange(new object[] {
            "I\'m reader",
            "I\'m librarian"});
            this.UserType.Location = new System.Drawing.Point(366, 222);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(218, 33);
            this.UserType.TabIndex = 2;
            // 
            // RegisterNewReader
            // 
            this.RegisterNewReader.Location = new System.Drawing.Point(662, 477);
            this.RegisterNewReader.Name = "RegisterNewReader";
            this.RegisterNewReader.Size = new System.Drawing.Size(253, 47);
            this.RegisterNewReader.TabIndex = 1;
            this.RegisterNewReader.Text = "Register New Reader";
            this.RegisterNewReader.UseVisualStyleBackColor = true;
            this.RegisterNewReader.Click += new System.EventHandler(this.RegisterNewReader_Click);
            // 
            // UsernameLable
            // 
            this.UsernameLable.AutoSize = true;
            this.UsernameLable.Location = new System.Drawing.Point(248, 97);
            this.UsernameLable.Name = "UsernameLable";
            this.UsernameLable.Size = new System.Drawing.Size(116, 25);
            this.UsernameLable.TabIndex = 3;
            this.UsernameLable.Text = "Username:";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(252, 151);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(112, 25);
            this.PasswordLable.TabIndex = 3;
            this.PasswordLable.Text = "Password:";
            // 
            // ChooseUserTypeLable
            // 
            this.ChooseUserTypeLable.AutoSize = true;
            this.ChooseUserTypeLable.Location = new System.Drawing.Point(178, 225);
            this.ChooseUserTypeLable.Name = "ChooseUserTypeLable";
            this.ChooseUserTypeLable.Size = new System.Drawing.Size(187, 25);
            this.ChooseUserTypeLable.TabIndex = 3;
            this.ChooseUserTypeLable.Text = "Choose user type:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 555);
            this.Controls.Add(this.ChooseUserTypeLable);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.UsernameLable);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.RegisterNewReader);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button RegisterNewReader;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Label UsernameLable;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label ChooseUserTypeLable;


    }
}