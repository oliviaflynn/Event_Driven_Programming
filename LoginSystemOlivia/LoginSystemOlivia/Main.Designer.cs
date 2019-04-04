namespace LoginSystemOlivia
{
    /// <summary>
    /// Main Form
    /// </summary>
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.Location = new System.Drawing.Point(13, 169);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(0, 13);
            this.labelAccountNumber.TabIndex = 5;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(16, 275);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(75, 23);
            this.buttonGoBack.TabIndex = 7;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(383, 281);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 8;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(127, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(279, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(127, 114);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(279, 20);
            this.textBoxUserName.TabIndex = 11;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(127, 154);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.ReadOnly = true;
            this.textBoxRole.Size = new System.Drawing.Size(279, 20);
            this.textBoxRole.TabIndex = 12;
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(127, 190);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.ReadOnly = true;
            this.textBoxAccountNumber.Size = new System.Drawing.Size(279, 20);
            this.textBoxAccountNumber.TabIndex = 13;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(127, 225);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.ReadOnly = true;
            this.textBoxEmailAddress.Size = new System.Drawing.Size(279, 20);
            this.textBoxEmailAddress.TabIndex = 14;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(36, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Customer Name:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(58, 117);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 16;
            this.labelUserName.Text = "User Name:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(86, 157);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(32, 13);
            this.labelRole.TabIndex = 17;
            this.labelRole.Text = "Role:";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(31, 193);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(90, 13);
            this.labelAccount.TabIndex = 18;
            this.labelAccount.Text = "Account Number:";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(45, 228);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.labelEmailAddress.TabIndex = 19;
            this.labelEmailAddress.Text = "Email Address:";
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelHeading.Location = new System.Drawing.Point(123, 34);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(277, 24);
            this.labelHeading.TabIndex = 20;
            this.labelHeading.Text = "Welcome to your Account Page";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 316);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxAccountNumber);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelAccountNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Page";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelHeading;
    }
}