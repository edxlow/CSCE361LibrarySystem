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
    public partial class Form1 : Form
    {
 
        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form1()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void loginbutton_Click(object sender, EventArgs e)
        {
            SQLLibrary.Open();
            SqlDataAdapter loggingS = new SqlDataAdapter("Select Count (*) From Library361.dbo.UserInfoTbl where UserID LIKE'" + usernamebox.Text + "' AND Password LIKE '" + pwbox.Text + "' AND Type='Student'", SQLLibrary);
            SqlDataAdapter loggingA = new SqlDataAdapter("Select Count (*) From Library361.dbo.UserInfoTbl where UserID LIKE'" + usernamebox.Text + "' AND Password LIKE '" + pwbox.Text + "' AND Type='Admin'", SQLLibrary);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            loggingS.Fill(dt);
            loggingA.Fill(dt1);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form3 f3 = new Form3(usernamebox.Text);
                f3.Show();
            }
            else if (dt1.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form4 f4 = new Form4(usernamebox.Text);
                f4.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect!", "Log In Fail");
     
            }
            SQLLibrary.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
