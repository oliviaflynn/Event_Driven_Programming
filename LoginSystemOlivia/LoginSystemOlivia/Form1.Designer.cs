namespace LoginSystemOlivia
{
    partial class Login_Screen
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonForgotPassword = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(56, 45);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User Name:";
            // 
            // textBoxUserName
            // 
            this.helpProvider1.SetHelpString(this.textBoxUserName, "Input your Username");
            this.textBoxUserName.Location = new System.Drawing.Point(125, 42);
            this.textBoxUserName.Name = "textBoxUserName";
            this.helpProvider1.SetShowHelp(this.textBoxUserName, true);
            this.textBoxUserName.Size = new System.Drawing.Size(153, 20);
            this.textBoxUserName.TabIndex = 3;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // textBoxPassword
            // 
            this.helpProvider1.SetHelpString(this.textBoxPassword, "Input your Password");
            this.textBoxPassword.Location = new System.Drawing.Point(125, 83);
            this.textBoxPassword.Name = "textBoxPassword";
            this.helpProvider1.SetShowHelp(this.textBoxPassword, true);
            this.textBoxPassword.Size = new System.Drawing.Size(153, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(63, 86);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            // 
            // buttonForgotPassword
            // 
            this.helpProvider1.SetHelpString(this.buttonForgotPassword, "Request your password from administrator");
            this.buttonForgotPassword.Location = new System.Drawing.Point(140, 198);
            this.buttonForgotPassword.Name = "buttonForgotPassword";
            this.helpProvider1.SetShowHelp(this.buttonForgotPassword, true);
            this.buttonForgotPassword.Size = new System.Drawing.Size(107, 23);
            this.buttonForgotPassword.TabIndex = 8;
            this.buttonForgotPassword.Text = "Forgot Password?";
            this.buttonForgotPassword.UseVisualStyleBackColor = true;
            this.buttonForgotPassword.Click += new System.EventHandler(this.buttonForgotPassword_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Enabled = false;
            this.helpProvider1.SetHelpString(this.buttonLogin, "Click to Login after entering Username and Password above");
            this.buttonLogin.Location = new System.Drawing.Point(154, 140);
            this.buttonLogin.Name = "buttonLogin";
            this.helpProvider1.SetShowHelp(this.buttonLogin, true);
            this.buttonLogin.Size = new System.Drawing.Size(84, 30);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonHelp
            // 
            this.helpProvider1.SetHelpString(this.buttonHelp, "Click for more help");
            this.buttonHelp.Location = new System.Drawing.Point(12, 198);
            this.buttonHelp.Name = "buttonHelp";
            this.helpProvider1.SetShowHelp(this.buttonHelp, true);
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonRegister
            // 
            this.helpProvider1.SetHelpString(this.buttonRegister, "Register for new users");
            this.buttonRegister.Location = new System.Drawing.Point(291, 198);
            this.buttonRegister.Name = "buttonRegister";
            this.helpProvider1.SetShowHelp(this.buttonRegister, true);
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelWelcome.Location = new System.Drawing.Point(121, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(91, 24);
            this.labelWelcome.TabIndex = 10;
            this.labelWelcome.Text = "Welcome";
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 233);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonForgotPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonForgotPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label labelWelcome;
    }
}

