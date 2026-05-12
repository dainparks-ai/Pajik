using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registers : Form
    {
        public Registers()
        {
            InitializeComponent();
        }

        UserDAO dao = new UserDAO();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();


            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(
                     txtUsername.Text,
                     txtPassword.Text,
                     txtFirstName.Text,
                     txtLastName.Text,
                     txtAddress.Text,
                     txtCity.Text,
                     txtBarangay.Text,
                     txtContact.Text
                 );

            bool success = dao.Register(user);

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                  string.IsNullOrWhiteSpace(txtPassword.Text) ||
                  string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                  string.IsNullOrWhiteSpace(txtLastName.Text) ||
                  string.IsNullOrWhiteSpace(txtPassword.Text) ||
                  string.IsNullOrWhiteSpace(txtAddress.Text) ||
                  string.IsNullOrWhiteSpace(txtBarangay.Text) ||
                  string.IsNullOrWhiteSpace(txtContact.Text))
            {
               error.Text = "All fields must be filled.";
                return;
            }


            if (success)
            {
                Login welcome = new Login();
                welcome.Show();
                this.Hide();

                this.Close();

            }
            else
            {
                MessageBox.Show("Username already exists.");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
