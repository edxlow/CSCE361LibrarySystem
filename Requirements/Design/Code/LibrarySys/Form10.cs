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
    public partial class Form10 : Form
    {
        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form10(string UserID)
        {
            InitializeComponent();
            userIDlbl.Text = UserID;
            booktitle_listbox();
            FillCombo();
            ratebtn.Enabled = false;
            returnbtn.Enabled = false;
        }

        void booktitle_listbox()
        {
            string Query = "select * from BorrowTbl where BorrowTbl.UserID LIKE'" + userIDlbl.Text + "'";
   
            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            SqlDataReader borrowReader;

            try
            {
                SQLLibrary.Open();
                bktitlelistbox.Items.Clear();
                borrowReader = sqlCmd.ExecuteReader();
                int BookIDVal = borrowReader.GetOrdinal("BookID");
                int BorrowIDVal = borrowReader.GetOrdinal("BorrowID");

                while (borrowReader.Read())
                {
                    bktitlelistbox.Items.Add(borrowReader.GetString(BookIDVal) +" [" + borrowReader.GetString(BorrowIDVal) +"]");
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
            string Query = "select * from BorrowTbl where BorrowTbl.UserID LIKE'" + userIDlbl.Text + "' AND BorrowTbl.BookID LIKE'" + cuttitleresult + "' AND BorrowTbl.BorrowID LIKE'" + cutresult+"'";
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
                        returnbtn.Enabled = true;
                        returntimelbl.Text = "Days Left to Return : 14 Days";
                    }
                    else
                    {
                        returnbtn.Enabled = false;
                    }

                    if (borrowReader.GetString(statusVal) == "Returned")
                    {
                        ratebtn.Enabled = true;
                        returntimelbl.Text = "Days Left to Return : -";
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

        private void returnbtn_Click(object sender, EventArgs e)
        {
            string cut = bktitlelistbox.Text;
            int start = cut.IndexOf("[") + 1;
            int end = cut.IndexOf("]", start);
            string cutresult = cut.Substring(start, end - start);

            string cuttitle = bktitlelistbox.Text;
            int starttitle = 0;
            int endtitle = cuttitle.IndexOf("[", starttitle);
            string cuttitleresult = cuttitle.Substring(starttitle, endtitle - 1);

            string Query = "select * from BorrowTbl where BorrowTbl.UserID LIKE'" + userIDlbl.Text + "' AND BorrowTbl.BookID LIKE'" + cuttitleresult + "' AND BorrowTbl.BorrowID LIKE'" + cutresult + "'";
            SqlCommand sqlCmd1 = new SqlCommand(Query, SQLLibrary);

            SqlDataReader borrowReader;

            SQLLibrary.Open();

            borrowReader = sqlCmd1.ExecuteReader();
            int statusVal = borrowReader.GetOrdinal("Status");
            int borrowVal = borrowReader.GetOrdinal("BorrowID");
            while (borrowReader.Read())
            {
                statuslbl.Text = "Status : " + borrowReader.GetString(statusVal);
                borrowIDlbl.Text = "Borrow ID : " + borrowReader.GetString(borrowVal);
                borrowwID.Text = borrowReader.GetString(borrowVal);
            }

            SQLLibrary.Close();

            SqlCommand sqlCmd = new SqlCommand("RequestReturn", SQLLibrary);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SQLLibrary.Open();
            sqlCmd.Parameters.AddWithValue("UserID", userIDlbl.Text.Trim());
            sqlCmd.Parameters.AddWithValue("BookID", cuttitleresult);
            sqlCmd.Parameters.AddWithValue("@BorrowID", cutresult);
            sqlCmd.Parameters.AddWithValue("Status", "Return Requested");
            sqlCmd.ExecuteNonQuery();

            MessageBox.Show("Return Request Successful! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            returnbtn.Enabled = false;

            string Query2 = "select * from BorrowTbl where BorrowTbl.UserID LIKE'" + userIDlbl.Text + "' AND BorrowTbl.BookID LIKE'" + cuttitleresult + "' AND BorrowTbl.BorrowID LIKE'" + cutresult + "'";
            
            SqlCommand sqlCmd2 = new SqlCommand(Query2, SQLLibrary);

            SqlDataReader borrowReader2;
            borrowReader2 = sqlCmd1.ExecuteReader();
            int statusVal2 = borrowReader2.GetOrdinal("Status");
            int borrowVal2 = borrowReader2.GetOrdinal("BorrowID");

            //while (borrowReader2.Read())
            //{
              //  statuslbl.Text = "Status : " + borrowReader.GetString(statusVal);
                //borrowIDlbl.Text = "Borrow ID : " + borrowReader.GetString(borrowVal);
            //}

            SQLLibrary.Close();
        }

        private void cancelbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        void FillCombo()
        {
            string Query = "select * from RatingTbl";
            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            SqlDataReader rateReader;

            try
            {
                SQLLibrary.Open();

                ratebox.Items.Clear();
                rateReader = sqlCmd.ExecuteReader();
                int RateVal = rateReader.GetOrdinal("Rating");

                while (rateReader.Read())
                {
                    ratebox.Items.Add(rateReader.GetString(RateVal));
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

        private void ratebtn_Click(object sender, EventArgs e)
        {
            SQLLibrary.Open();
            SqlCommand sqlCmd = new SqlCommand("RateBook", SQLLibrary);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("UserID", userIDlbl.Text.Trim());
            sqlCmd.Parameters.AddWithValue("BookID", bktitlelistbox.Text.Trim());
            sqlCmd.Parameters.AddWithValue("Status", "Returned");
            sqlCmd.Parameters.AddWithValue("BorrowID", borrowwID.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Rating", ratebox.Text.Trim());
            sqlCmd.ExecuteNonQuery();

            MessageBox.Show("Rating Success! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SQLLibrary.Close();
        }
    }
}
