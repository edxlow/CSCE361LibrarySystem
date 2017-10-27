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
    public partial class Form8 : Form
    {
        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form8()
        {
            InitializeComponent();
            bug_listbox();
            SQLLibrary.Close();
        }

        private void buglistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string Query = "select * from BugReportTbl where BugReportTbl.BugReportID LIKE'" + buglistbox.Text + "'";

            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
 
            SqlDataReader bugReader;


            try
            {
                SQLLibrary.Open();

                bugReader = sqlCmd.ExecuteReader();

                int categoryVal = bugReader.GetOrdinal("Category");
                int commentVal = bugReader.GetOrdinal("Comments");
       

                while (bugReader.Read())
                {
                    categorybox.Text = bugReader.GetString(categoryVal);
                    descriptionbox.Text = bugReader.GetString(commentVal);
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

        void bug_listbox()
        {
            string Query = "select BugReportID from BugReportTbl";
            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            SqlDataReader bugReader;

            try
            {
                SQLLibrary.Open();

                buglistbox.Items.Clear();
                bugReader = sqlCmd.ExecuteReader();
                int BugIDVal = bugReader.GetOrdinal("BugReportID");

                while (bugReader.Read())
                {
                    buglistbox.Items.Add(bugReader.GetString(BugIDVal));
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

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
