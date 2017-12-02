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
    public partial class Form9 : Form
    {
        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form9()
        {
            InitializeComponent();
            UserID_listbox();
            approveborrowbtn.Enabled = false;
            approvereturnbtn.Enabled = false;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        void UserID_listbox()
        {
            string Query = "select UserID from BorrowTbl";
            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            SqlDataReader borrowReader;

            try
            {
                SQLLibrary.Open();
                UserIDlistbox.Items.Clear();
                borrowReader = sqlCmd.ExecuteReader();
                int UserIDVal = borrowReader.GetOrdinal("UserID");

               
                while (borrowReader.Read())
                {
                    if (UserIDlistbox.Items.Contains(borrowReader.GetString(UserIDVal)) == false)
                    {
                        UserIDlistbox.Items.Add(borrowReader.GetString(UserIDVal));
                    }
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

        private void UserIDlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
                string Query = "select * from BorrowTbl where BorrowTbl.UserID LIKE'" + UserIDlistbox.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
           bktitlelistbox.Items.Clear();
            SqlDataReader borrowReader;
                try
                {
                    SQLLibrary.Open();

                borrowReader = sqlCmd.ExecuteReader();
                    int bktitleVal = borrowReader.GetOrdinal("BookID");
                int BorrowIDVal = borrowReader.GetOrdinal("BorrowID");

                while (borrowReader.Read())
                    {
                    bktitlelistbox.Items.Add(borrowReader.GetString(bktitleVal) + " [" + borrowReader.GetString(BorrowIDVal) + "]");
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

        private void bktitlelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cut = bktitlelistbox.Text;
            int start = cut.IndexOf("[") + 1;
            int end = cut.IndexOf("]", start);
            string cutresult = cut.Substring(start, end - start);

            string cuttitle = bktitlelistbox.Text;
            int starttitle = 0;
            int endtitle = cuttitle.IndexOf("[", starttitle);
            string cuttitleresult = cuttitle.Substring(starttitle, endtitle - 1);
            string Query = "select * from BorrowTbl where BorrowTbl.UserID LIKE'" + UserIDlistbox.Text + "' AND BorrowTbl.BookID LIKE'" + cuttitleresult + "' AND BorrowTbl.BorrowID LIKE'" + cutresult + "'";

            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);

            SqlDataReader borrowReader;
            try
            {
                SQLLibrary.Open();

                borrowReader = sqlCmd.ExecuteReader();
                int statusVal = borrowReader.GetOrdinal("Status");
                int borrowVal = borrowReader.GetOrdinal("BorrowID");

                while (borrowReader.Read())
                {
                    statuslbl.Text = "Status : " + borrowReader.GetString(statusVal);
                    borrowIDlbl.Text = "Borrow ID : " + borrowReader.GetString(borrowVal);
                    borrowwID.Text = borrowReader.GetString(borrowVal);

                    if (borrowReader.GetString(statusVal) == "Borrowing")
                    {
                        approveborrowbtn.Enabled = false;
                    }
                    else if(borrowReader.GetString(statusVal) == "Pending")
                    {
                        approveborrowbtn.Enabled = true;
                    }
                    if (borrowReader.GetString(statusVal) == "Return Requested")
                    {
                        approvereturnbtn.Enabled = true;
                    }
                    else if (borrowReader.GetString(statusVal) == "Returned")
                    {
                        approvereturnbtn.Enabled = false;
                    }
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

        private void approveborrowbtn_Click(object sender, EventArgs e)
        {
            string cut = bktitlelistbox.Text;
            int start = cut.IndexOf("[") + 1;
            int end = cut.IndexOf("]", start);
            string cutresult = cut.Substring(start, end - start);

            string cuttitle = bktitlelistbox.Text;
            int starttitle = 0;
            int endtitle = cuttitle.IndexOf("[", starttitle);
            string cuttitleresult = cuttitle.Substring(starttitle, endtitle - 1);

            SQLLibrary.Open();
            SqlCommand sqlCmd = new SqlCommand("UpdateBookRequest", SQLLibrary);
            sqlCmd.CommandType = CommandType.StoredProcedure;


            sqlCmd.Parameters.AddWithValue("UserID", UserIDlistbox.Text.Trim());
            sqlCmd.Parameters.AddWithValue("BookID", cuttitleresult);
            sqlCmd.Parameters.AddWithValue("@BorrowID", cutresult);
            sqlCmd.Parameters.AddWithValue("Status", "Borrowing");
            sqlCmd.ExecuteNonQuery();
            

            MessageBox.Show("Approved Success! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string Query = "select * from BorrowTbl where BorrowTbl.UserID LIKE'" + UserIDlistbox.Text + "' AND BorrowTbl.BookID LIKE'" + bktitlelistbox.Text + "'";
            SqlCommand sqlCmd1 = new SqlCommand(Query, SQLLibrary);
            SqlDataReader borrowReader;
            borrowReader = sqlCmd1.ExecuteReader();
            int statusVal = borrowReader.GetOrdinal("Status");
            int borrowVal = borrowReader.GetOrdinal("BorrowID");

            while (borrowReader.Read())
            {
                statuslbl.Text = "Status : " + borrowReader.GetString(statusVal);
                borrowIDlbl.Text = "Borrow ID : " + borrowReader.GetString(borrowVal);
            }

            returntimelbl.Text = "Days Left to Return : 14 Days";
            SQLLibrary.Close();
            approveborrowbtn.Enabled = false;
        }

        private void approvereturnbtn_Click(object sender, EventArgs e)
        {
            string cut = bktitlelistbox.Text;
            int start = cut.IndexOf("[") + 1;
            int end = cut.IndexOf("]", start);
            string cutresult = cut.Substring(start, end - start);

            string cuttitle = bktitlelistbox.Text;
            int starttitle = 0;
            int endtitle = cuttitle.IndexOf("[", starttitle);
            string cuttitleresult = cuttitle.Substring(starttitle, endtitle - 1);

            SQLLibrary.Open();
            SqlCommand sqlCmd = new SqlCommand("ReturnApprove", SQLLibrary);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("UserID", UserIDlistbox.Text.Trim());
            sqlCmd.Parameters.AddWithValue("BookID", cuttitleresult);
            sqlCmd.Parameters.AddWithValue("@BorrowID", cutresult);
            sqlCmd.Parameters.AddWithValue("Status", "Returned");
            sqlCmd.ExecuteNonQuery();

            MessageBox.Show("Approved Return Success! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string Query = "select * from BorrowTbl where BorrowTbl.UserID LIKE'" + UserIDlistbox.Text + "' AND BorrowTbl.BookID LIKE'" + bktitlelistbox.Text + "'";
            SqlCommand sqlCmd1 = new SqlCommand(Query, SQLLibrary);
            SqlDataReader borrowReader;
            borrowReader = sqlCmd1.ExecuteReader();
            int statusVal = borrowReader.GetOrdinal("Status");
            int borrowVal = borrowReader.GetOrdinal("BorrowID");

            while (borrowReader.Read())
            {
                statuslbl.Text = "Status : " + borrowReader.GetString(statusVal);
                borrowIDlbl.Text = "Borrow ID : " + borrowReader.GetString(borrowVal);
            }
            returntimelbl.Text = "Days Left to Return : -";
            SQLLibrary.Close();
            approvereturnbtn.Enabled = false;
        }
    }
}
