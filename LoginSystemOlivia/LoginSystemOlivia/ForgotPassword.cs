using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystemOlivia
{
    public partial class ForgotPassword : Form
    {
        /// <summary>
        /// Build the form Forgot Password
        /// </summary>
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRecoverPassword_Click(object sender, EventArgs e)
        {
            if (textboxUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("An Email has been sent to you containing a link to your registered email address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
