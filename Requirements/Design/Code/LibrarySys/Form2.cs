using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace LibrarySys
{
    public partial class Form2 : Form
    {
        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form2()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLLibrary.Open();

                //DataSet dsData = new DataSet();
                SqlCommand sqlCmd = new SqlCommand("UserRegister", SQLLibrary);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@Name", nameBox.Text.Trim());
                sqlCmd.Parameters.Add("@UserID", userIDbox.Text.Trim());
                sqlCmd.Parameters.Add("@Password", PWbox.Text.Trim());
                sqlCmd.Parameters.Add("@Email", emailBox.Text.Trim());
                sqlCmd.Parameters.Add("@PhoneNum", phonenumBox.Text.Trim());
                sqlCmd.Parameters.Add("@Address", addressBox.Text.Trim());
                sqlCmd.Parameters.Add("@Type", "Student");

                CheckRegister();

                if (PWbox.Text == CPWBox.Text && !string.IsNullOrWhiteSpace(nameBox.Text) && !string.IsNullOrWhiteSpace(userIDbox.Text) && !string.IsNullOrWhiteSpace(PWbox.Text) && !string.IsNullOrWhiteSpace(emailBox.Text) && !string.IsNullOrWhiteSpace(phonenumBox.Text) && !string.IsNullOrWhiteSpace(addressBox.Text) && !string.IsNullOrWhiteSpace(CPWBox.Text))
                {
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Register Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }

                else if (PWbox.Text != CPWBox.Text)
                {
                    MessageBox.Show("Password is not the same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                SQLLibrary.Close();
            }
         }

        void CheckRegister()
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                namelbl.Text = "Name must be entered!";
            }
            else
            {
                namelbl.Text = " ";
            }

            if (string.IsNullOrWhiteSpace(userIDbox.Text))
            {
                userlbl.Text = "UserID must be entered!";
            }
            else
            {
                userlbl.Text = " ";
            }

            if (string.IsNullOrWhiteSpace(PWbox.Text))
            {
                pwlbl.Text = "Password must be entered!";
            }
            else
            {
                pwlbl.Text = " ";
            }

            if (string.IsNullOrWhiteSpace(CPWBox.Text))
            {
                cpwlbl.Text = "Please confirm password!";
            }
            else
            {
                cpwlbl.Text = " ";
            }

            if (string.IsNullOrWhiteSpace(emailBox.Text))
            {
                emaillbl.Text = "Email must be entered";
            }
            else
            {
                emaillbl.Text = " ";
            }

            if (string.IsNullOrWhiteSpace(phonenumBox.Text))
            {
                pnumlbl.Text = "Phone number must be entered!";
            }
            else
            {
                pnumlbl.Text = " ";
            }

            if (string.IsNullOrWhiteSpace(addressBox.Text))
            {
                addlbl.Text = "Address must be entered!";
            }
            else
            {
                addlbl.Text = " ";
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cpwlbl_Click(object sender, EventArgs e)
        {

        }
    }
}


