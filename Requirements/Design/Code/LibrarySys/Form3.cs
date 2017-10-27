﻿using System;
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
    public partial class Form3 : Form
    {
        static string strLibraryCon = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryCon"].ToString().Trim();
        SqlConnection SQLLibrary = new SqlConnection(strLibraryCon);

        public Form3(string userName)
        {
            InitializeComponent();
            SQLLibrary.Open();
            userIDlbl.Text = userName;
            SqlDataAdapter sqlCmd = new SqlDataAdapter("SELECT Name FROM UserInfoTbl where UserID ='" + userName + "'", SQLLibrary);
            System.Data.DataTable nametable = new System.Data.DataTable();
            sqlCmd.Fill(nametable);


            foreach (DataRow dr2 in nametable.Rows)
            {
                welcomelbl.Text = "Welcome, " + dr2["Name"].ToString().Trim();
            }

            SQLLibrary.Close();
        }


       

        private void stitlebtn_Click(object sender, EventArgs e)
        {
            title_listbox();
        }

        void title_listbox()
        {
            string Query = "select BookID from BookInfoTbl where BookTitle LIKE'" + searchbox.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            SqlDataReader titleReader;

            try
            {
                SQLLibrary.Open();

                titlelistbox.Items.Clear();
                titleReader = sqlCmd.ExecuteReader();

                int BookIDVal = titleReader.GetOrdinal("BookID");

                while (titleReader.Read())
                {
                    titlelistbox.Items.Add(titleReader.GetString(BookIDVal));
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

        void genre_listbox()
        {
            string Query = "select BookID from BookInfoTbl where Genre LIKE'" + searchbox.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            SqlDataReader genreReader;

            try
            {
                SQLLibrary.Open();

                titlelistbox.Items.Clear();
                genreReader = sqlCmd.ExecuteReader();
                int BookIDVal = genreReader.GetOrdinal("BookID");

                while (genreReader.Read())
                {
                    titlelistbox.Items.Add(genreReader.GetString(BookIDVal));
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

        void ISBN_listbox()
        {
            string Query = "select BookID from BookInfoTbl where ISBN LIKE'" + searchbox.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            SqlDataReader ISBNReader;

            try
            {
                SQLLibrary.Open();

                titlelistbox.Items.Clear();
                ISBNReader = sqlCmd.ExecuteReader();
                int BookIDVal = ISBNReader.GetOrdinal("BookID");

                while (ISBNReader.Read())
                {
                    titlelistbox.Items.Add(ISBNReader.GetString(BookIDVal));
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

        private void sgenrebtn_Click(object sender, EventArgs e)
        {
            genre_listbox();
        }

        private void sisbnbtn_Click(object sender, EventArgs e)
        {
            ISBN_listbox();
        }

        private void titlelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Llibrarylbl.Text = "Library : ";
            blocationlbl.Text = "Location : ";
            Lshelflbl.Text = "Shelf : ";
            bdescriptionlbl.Text = "Book Description : ";

            string Query = "select * from LocationTbl,BookInfoTbl where LocationTbl.BookID=BookInfoTbl.BookID AND BookInfoTbl.BookID LIKE'" + titlelistbox.Text + "'";
            //string Query1 = "select * from BookInfoTbl where BookID LIKE'" + titlelistbox.Text + "'";

            SqlCommand sqlCmd = new SqlCommand(Query, SQLLibrary);
            //SqlCommand sqlCmd1 = new SqlCommand(Query1, SQLLibrary);
            SqlDataReader bookReader;
           // SqlDataReader bookReader1;

            try
            {
                SQLLibrary.Open();

                bookReader = sqlCmd.ExecuteReader();
               // bookReader1 = sqlCmd1.ExecuteReader();

                int TitleVal = bookReader.GetOrdinal("BookTitle");
                int LibraryVal = bookReader.GetOrdinal("Library");
                int LocationVal = bookReader.GetOrdinal("Location");
                int ShelfVal = bookReader.GetOrdinal("ShelfNumber");
                int bkdescription = bookReader.GetOrdinal("BookDescription");
                

                while (bookReader.Read())
                {             
                    btitlelbl.Text = bookReader.GetString(TitleVal);
                    Llibrarylbl.Text = "Library : " + bookReader.GetString(LibraryVal);
                    blocationlbl.Text = "Location : " + bookReader.GetString(LocationVal);
                    Lshelflbl.Text = "Shelf : " + bookReader.GetString(ShelfVal);
                    bdescriptionlbl.Text = "Book Description : " + bookReader.GetString(bkdescription);
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

        private void reportlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5(userIDlbl.Text);
            f5.ShowDialog();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }
    }
}

