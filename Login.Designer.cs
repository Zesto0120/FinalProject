namespace FinalProject
{
    partial class Login
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnsignin = new Button();
            Password = new TextBox();
            label3 = new Label();
            Username = new TextBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(41, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(306, 273);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtUsername);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(298, 245);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(21, 116);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 73);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(89, 31);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnsignin);
            tabPage2.Controls.Add(Password);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(Username);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(298, 245);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sign In";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnsignin
            // 
            btnsignin.Location = new Point(19, 110);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(75, 23);
            btnsignin.TabIndex = 9;
            btnsignin.Text = "Sign In";
            btnsignin.UseVisualStyleBackColor = true;
            btnsignin.Click += btnsignin_Click;
            // 
            // Password
            // 
            Password.Location = new Point(87, 64);
            Password.Name = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 8;
            Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 67);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // Username
            // 
            Username.Location = new Point(87, 25);
            Username.Name = "Username";
            Username.Size = new Size(100, 23);
            Username.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 25);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 5;
            label4.Text = "UserName";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(tabControl1);
            Name = "Login";
            Text = "Login";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private Button btnsignin;
        private TextBox Password;
        private Label label3;
        private TextBox Username;
        private Label label4;
    }
}