using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LoginSystemOlivia
{
    /// <summary>
    /// Login Form, First Screen of Application
    /// </summary>
    public partial class Login_Screen : Form
    {
        List<User> userList = new List<User>();

        private Help helpForm;
        private Register registerForm;
        private ForgotPassword forgotPassword;
      
        /// <summary>
        /// Initialize the Login Form
        /// </summary>
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"p_words.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    User user = new User();
                    user.FirstName = values[0];
                    user.LastName = values[1];
                    user.UserID = values[2];
                    user.Password = values[3];
                    user.Role = values[4];
                    user.AccountNumber = values[5];
                    user.EmailAddress = values[6];

                    if (values[7].ToLower().Equals("yes"))
                    {
                        user.adminFullAccess = true;
                    }
                    else
                    {
                        user.adminFullAccess = false;
                    }

                    if (values[8].ToLower().Equals("yes"))
                    {
                        user.AdminReportPrivileges = true;
                    }
                    else
                    {
                        user.AdminReportPrivileges = false;
                    }

                    if (values[9].ToLower().Equals("yes"))
                    {
                        user.genAuditReports = true;
                    }
                    else
                    {
                        user.genAuditReports = false;
                    }

                    if (values[10].ToLower().Equals("yes"))
                    {
                        user.ViewAuditRecords = true;
                    }
                    else
                    {
                        user.ViewAuditRecords = false;
                    }

                    if (values[11].ToLower().Equals("yes"))
                    {
                        user.InputAccountPayments = true;
                    }
                    else
                    {
                        user.InputAccountPayments = false;
                    }

                    if (values[12].ToLower().Equals("yes"))
                    {
                        user.authAccountPayments = true;
                    }
                    else
                    {
                        user.authAccountPayments = false;
                    }

                    if (values[13].ToLower().Equals("yes"))
                    {
                        user.manageAccount = true;
                    }
                    else
                    {
                        user.manageAccount = false;
                    }

                    if (values[14].ToLower().Equals("yes"))
                    {
                        user.viewAccountInformation = true;
                    }
                    else
                    {
                        user.viewAccountInformation = false;
                    }

                    if (values[15].ToLower().Equals("yes"))
                    {
                        user.viewAccountBalances = true;
                    }
                    else
                    {
                        user.viewAccountBalances = false;
                    }
                    userList.Add(user);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userid = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            User userLogin = new User();

            foreach (User user in userList)
            {
                if (user.UserID.Equals(userid))
                {
                    userLogin = user;
                    Debug.WriteLine(userLogin.UserID);
                    Debug.WriteLine(userLogin.Password);
                }
            }

            if (userLogin.Password != null && userLogin.Password.Equals(password))
            {
                
                Main form = new Main(this, userLogin);
                form.Show();
            }
            else
            {
                MessageBox.Show("Wrong user name or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            helpForm = new Help();
            helpForm.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            registerForm = new Register();
            registerForm.Show();
        }

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void SetButton()
        {
            buttonLogin.Enabled = (textBoxUserName.Text != "" || textBoxUserName.Visible == false) && (textBoxPassword.Text != "" || textBoxPassword.Visible == false);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            SetButton();

         }
    }
}
