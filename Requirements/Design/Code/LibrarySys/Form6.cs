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
    public partial class Form6 : Form
    {

        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form6()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLLibrary.Open();

                //DataSet dsData = new DataSet();
                SqlCommand sqlCmd = new SqlCommand("AddBooks", SQLLibrary);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCommand sqlCmd1 = new SqlCommand("AddLocation", SQLLibrary);
                sqlCmd1.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter IDcount = new SqlDataAdapter("SELECT * FROM Library361.dbo.BookInfoTbl WHERE BookTitle LIKE '" + bktitlebox.Text + "'", SQLLibrary);
                DataSet CheckID = new DataSet();
                IDcount.Fill(CheckID);

                Random random = new Random();
                int randomNumber = random.Next(0, 99999);

                if (CheckID.Tables.Count > 0 && CheckID.Tables[0].Rows.Count > 0)
                {
                    sqlCmd.Parameters.Add("@BookID", bktitlebox.Text.Trim() + "(" + randomNumber + ")");
                    sqlCmd1.Parameters.Add("@BookID", bktitlebox.Text.Trim() + "(" + randomNumber + ")");
                }

                sqlCmd.Parameters.Add("@BookTitle", bktitlebox.Text.Trim());
                sqlCmd.Parameters.Add("@PublishDate", pdatebox.Text.Trim());
                sqlCmd.Parameters.Add("@ISBN", ISBNbox.Text.Trim());
                sqlCmd.Parameters.Add("@Genre", genrebox.Text.Trim());
                sqlCmd.Parameters.Add("@BookDescription", bkdescripbox.Text.Trim());
                sqlCmd.Parameters.Add("@Author", authorbox.Text.Trim());

                sqlCmd1.Parameters.Add("@BookTitle", bktitlebox.Text.Trim());
                sqlCmd1.Parameters.Add("@Library", librarybox.Text.Trim());
                sqlCmd1.Parameters.Add("@Location", locationbox.Text.Trim());
                sqlCmd1.Parameters.Add("@ShelfNumber", shelfbox.Text.Trim());


                if (!string.IsNullOrWhiteSpace(bktitlebox.Text) && !string.IsNullOrWhiteSpace(pdatebox.Text) && !string.IsNullOrWhiteSpace(ISBNbox.Text) && !string.IsNullOrWhiteSpace(genrebox.Text) && !string.IsNullOrWhiteSpace(bkdescripbox.Text) && !string.IsNullOrWhiteSpace(authorbox.Text))
                {
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd1.ExecuteNonQuery();
                    MessageBox.Show("Add Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Please fill up all the empty boxes! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

     
    }
}
