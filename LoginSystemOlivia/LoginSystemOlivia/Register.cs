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
    /// <summary>
    /// Register Form for Registering new users
    /// </summary>
    public partial class Register : Form
    {   
        /// <summary>
        /// Initialize the Form
        /// </summary>
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (Password.isPassword(textBoxPassword.Text))
            {
                MessageBox.Show("Password is Valid.");
                MessageBox.Show("Registration Sucessful. Once your application has been reviewed, you will receive an email with instructions on how to log in.");
                this.Close();
            }
            else
            {
                MessageBox.Show(Password.getLastErrorMessage());
            }
        
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
