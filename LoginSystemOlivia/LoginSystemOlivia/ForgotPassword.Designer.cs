namespace LoginSystemOlivia
{
    /// <summary>
    /// Forgot Password Class
    /// </summary>
    partial class ForgotPassword
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
            this.textboxUserName = new System.Windows.Forms.MaskedTextBox();
            this.buttonRecoverPassword = new System.Windows.Forms.Button();
            this.labelInfoText = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(24, 78);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name:";
            this.labelUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(93, 75);
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(207, 20);
            this.textboxUserName.TabIndex = 1;
            // 
            // buttonRecoverPassword
            // 
            this.buttonRecoverPassword.Location = new System.Drawing.Point(146, 117);
            this.buttonRecoverPassword.Name = "buttonRecoverPassword";
            this.buttonRecoverPassword.Size = new System.Drawing.Size(117, 23);
            this.buttonRecoverPassword.TabIndex = 2;
            this.buttonRecoverPassword.Text = "Recover Password";
            this.buttonRecoverPassword.UseVisualStyleBackColor = true;
            this.buttonRecoverPassword.Click += new System.EventHandler(this.buttonRecoverPassword_Click);
            // 
            // labelInfoText
            // 
            this.labelInfoText.AutoSize = true;
            this.labelInfoText.Location = new System.Drawing.Point(90, 160);
            this.labelInfoText.Name = "labelInfoText";
            this.labelInfoText.Size = new System.Drawing.Size(193, 13);
            this.labelInfoText.TabIndex = 3;
            this.labelInfoText.Text = "Enter your UserID to recover password.";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(12, 196);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGoBack.TabIndex = 4;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelForgotPassword.Location = new System.Drawing.Point(89, 26);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(152, 24);
            this.labelForgotPassword.TabIndex = 5;
            this.labelForgotPassword.Text = "Forgot Password";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 231);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelInfoText);
            this.Controls.Add(this.buttonRecoverPassword);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.labelUserName);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.MaskedTextBox textboxUserName;
        private System.Windows.Forms.Button buttonRecoverPassword;
        private System.Windows.Forms.Label labelInfoText;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Label labelForgotPassword;
    }
}