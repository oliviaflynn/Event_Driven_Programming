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

    public partial class Main : Form
    {
        private User user;
        private Help helpForm;
        private Form callingForm;
        private User userLogin;

        /// <summary>
        /// Referance to user object from previous form
        /// </summary>
        public Main(Form callingForm, User user)
        {
            this.callingForm = callingForm;
            this.user = user;
            InitializeComponent();            
        }
        /// <summary>
        /// Referance to user object from previous form
        /// </summary>
        public Main(User userLogin)
        {
            this.userLogin = userLogin;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {

            Close();
            MessageBox.Show("You are now logged out.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            textBoxName.Text = user.FirstName+ " " + user.LastName;            
            textBoxUserName.Text = user.UserID;            
            textBoxRole.Text = user.Role;
            textBoxAccountNumber.Text = user.AccountNumber;
            textBoxEmailAddress.Text = user.EmailAddress;

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm = new Help();
            helpForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
