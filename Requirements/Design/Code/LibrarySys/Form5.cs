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
    public partial class Form5 : Form
    {
        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form5(string UserID)
        {
            InitializeComponent();
            userIDlbl.Text = UserID;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLLibrary.Open();
               

                SqlCommand sqlCmd = new SqlCommand("BugReporting", SQLLibrary);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                Random random = new Random();
                int randomNumber = random.Next(0, 99999);

                SqlDataAdapter bugcount = new SqlDataAdapter("SELECT * FROM Library361.dbo.BugReportTbl WHERE Category LIKE '" + categorybox.Text + "'", SQLLibrary);
                DataSet CheckBug = new DataSet();
                bugcount.Fill(CheckBug);

                if (CheckBug.Tables.Count > 0 && CheckBug.Tables[0].Rows.Count >= 0)
                {
                    sqlCmd.Parameters.Add("@BugReportID", categorybox.Text.Trim() + "(" + randomNumber + ")");
                }

                sqlCmd.Parameters.Add("@UserID", userIDlbl.Text.Trim());
                sqlCmd.Parameters.Add("@Category", categorybox.Text.Trim());
                sqlCmd.Parameters.Add("@Comments", descriptionbox.Text.Trim());

                if (descriptionbox.MaxLength> 200)
                {
                    MessageBox.Show("Description is too long!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                if (!string.IsNullOrWhiteSpace(categorybox.Text) && !string.IsNullOrWhiteSpace(descriptionbox.Text) && descriptionbox.MaxLength <= 200)
                {
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Bug Reported Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else if (!string.IsNullOrWhiteSpace(categorybox.Text) && !string.IsNullOrWhiteSpace(descriptionbox.Text))
                {
                    MessageBox.Show("Please fill in all empty boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLLibrary.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
