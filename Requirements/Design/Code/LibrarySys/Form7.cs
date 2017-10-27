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
            }

            SQLLibrary.Close();

        }

        private void updatebtn_Click(object sender, EventArgs e)
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

            sqlcmd1.Parameters.AddWithValue("BookID", bkIDlbl.Text.Trim());
            sqlcmd1.Parameters.AddWithValue("BookTitle", bktitlebox.Text.Trim());
            sqlcmd1.Parameters.AddWithValue("Library", librarybox.Text.Trim());
            sqlcmd1.Parameters.AddWithValue("ShelfNumber", shelfbox.Text.Trim());
            sqlcmd1.Parameters.AddWithValue("Location", locationbox.Text.Trim());

            sqlcmd1.ExecuteNonQuery();
            sqlcmd.ExecuteNonQuery();

            MessageBox.Show("Update Successful !", "Update Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SQLLibrary.Close();
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
