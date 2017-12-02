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
    public partial class Form7 : Form
    {
        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form7(string BookID)
        {
            InitializeComponent();
            bkIDlbl.Text = BookID;
            string Query = "select * from LocationTbl,BookInfoTbl where LocationTbl.BookID=BookInfoTbl.BookID AND BookInfoTbl.BookID LIKE'" + BookID + "'";
            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            SqlDataReader bookReader;

            SQLLibrary.Open();
            bktitlebox.Enabled = false;

            bookReader = sqlCmd.ExecuteReader();
            // bookReader1 = sqlCmd1.ExecuteReader();

            int TitleVal = bookReader.GetOrdinal("BookTitle");
            int AuthorVal = bookReader.GetOrdinal("Author");
            int GenreVal = bookReader.GetOrdinal("Genre");
            int bkdescription = bookReader.GetOrdinal("BookDescription");
            int pdateVal = bookReader.GetOrdinal("PublishDate");
            int ISBNVal = bookReader.GetOrdinal("ISBN");
            int LibraryVal = bookReader.GetOrdinal("Library");
            int LocationVal = bookReader.GetOrdinal("Location");
            int ShelfVal = bookReader.GetOrdinal("ShelfNumber");
            int QuantityVal = bookReader.GetOrdinal("Quantity");
            
            while (bookReader.Read())
            {
                bktitlebox.Text = bookReader.GetString(TitleVal);
                authorbox.Text = bookReader.GetString(AuthorVal);
                genrebox.Text = bookReader.GetString(GenreVal);
                bkdescripbox.Text = bookReader.GetString(bkdescription);
                pdatebox.Text = bookReader.GetString(pdateVal);
                ISBNbox.Text = bookReader.GetString(ISBNVal);
                librarybox.Text = bookReader.GetString(LibraryVal);
                locationbox.Text = bookReader.GetString(LocationVal);
                shelfbox.Text = bookReader.GetString(ShelfVal);
                quantitybox.Text = bookReader.GetString(QuantityVal);
            }

            SQLLibrary.Close();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            try
            {
                SQLLibrary.Open();
                SqlCommand sqlcmd = new SqlCommand("UpdateBook", SQLLibrary);
                SqlCommand sqlcmd1 = new SqlCommand("UpdateBookLocation", SQLLibrary);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd1.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("BookID", bkIDlbl.Text.Trim());
                sqlcmd.Parameters.AddWithValue("BookTitle", bktitlebox.Text.Trim());
                sqlcmd.Parameters.AddWithValue("Author", authorbox.Text.Trim());
                sqlcmd.Parameters.AddWithValue("Genre", genrebox.Text.Trim());
                sqlcmd.Parameters.AddWithValue("BookDescription", bkdescripbox.Text.Trim());
                sqlcmd.Parameters.AddWithValue("PublishDate", pdatebox.Text.Trim());
                sqlcmd.Parameters.AddWithValue("ISBN", ISBNbox.Text.Trim());
                sqlcmd.Parameters.Add("@Quantity", quantitybox.Text.Trim());

                sqlcmd1.Parameters.AddWithValue("BookID", bkIDlbl.Text.Trim());
                sqlcmd1.Parameters.AddWithValue("BookTitle", bktitlebox.Text.Trim());
                sqlcmd1.Parameters.AddWithValue("Library", librarybox.Text.Trim());
                sqlcmd1.Parameters.AddWithValue("ShelfNumber", shelfbox.Text.Trim());
                sqlcmd1.Parameters.AddWithValue("Location", locationbox.Text.Trim());

                if (!string.IsNullOrWhiteSpace(bktitlebox.Text) && !string.IsNullOrWhiteSpace(pdatebox.Text) && !string.IsNullOrWhiteSpace(ISBNbox.Text) && !string.IsNullOrWhiteSpace(genrebox.Text) && !string.IsNullOrWhiteSpace(bkdescripbox.Text) && !string.IsNullOrWhiteSpace(authorbox.Text) && !string.IsNullOrWhiteSpace(librarybox.Text) && !string.IsNullOrWhiteSpace(locationbox.Text) && !string.IsNullOrWhiteSpace(shelfbox.Text) && !string.IsNullOrWhiteSpace(quantitybox.Text))
                {
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd1.ExecuteNonQuery();
                    MessageBox.Show("Update Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void KeyPressNum(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
