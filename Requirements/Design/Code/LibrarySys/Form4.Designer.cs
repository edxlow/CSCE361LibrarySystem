﻿namespace LibrarySys
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletebkbtn = new System.Windows.Forms.Button();
            this.updatebkbtn = new System.Windows.Forms.Button();
            this.Lshelflbl = new System.Windows.Forms.Label();
            this.Llibrarylbl = new System.Windows.Forms.Label();
            this.blocationlbl = new System.Windows.Forms.Label();
            this.bdescriptionlbl = new System.Windows.Forms.Label();
            this.btitlelbl = new System.Windows.Forms.Label();
            this.titlelistbox = new System.Windows.Forms.ListBox();
            this.sisbnbtn = new System.Windows.Forms.Button();
            this.sgenrebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.stitlebtn = new System.Windows.Forms.Button();
            this.addbkbtn = new System.Windows.Forms.Button();
            this.bugbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(23, 28);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(205, 23);
            this.welcomelbl.TabIndex = 9;
            this.welcomelbl.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deletebkbtn);
            this.panel1.Controls.Add(this.updatebkbtn);
            this.panel1.Controls.Add(this.addbkbtn);
            this.panel1.Controls.Add(this.Lshelflbl);
            this.panel1.Controls.Add(this.Llibrarylbl);
            this.panel1.Controls.Add(this.blocationlbl);
            this.panel1.Controls.Add(this.bdescriptionlbl);
            this.panel1.Controls.Add(this.btitlelbl);
            this.panel1.Location = new System.Drawing.Point(329, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 309);
            this.panel1.TabIndex = 16;
            // 
            // deletebkbtn
            // 
            this.deletebkbtn.Location = new System.Drawing.Point(528, 218);
            this.deletebkbtn.Name = "deletebkbtn";
            this.deletebkbtn.Size = new System.Drawing.Size(104, 45);
            this.deletebkbtn.TabIndex = 19;
            this.deletebkbtn.Text = "Delete Book";
            this.deletebkbtn.UseVisualStyleBackColor = true;
            this.deletebkbtn.Click += new System.EventHandler(this.deletebkbtn_Click);
            // 
            // updatebkbtn
            // 
            this.updatebkbtn.Location = new System.Drawing.Point(398, 218);
            this.updatebkbtn.Name = "updatebkbtn";
            this.updatebkbtn.Size = new System.Drawing.Size(104, 45);
            this.updatebkbtn.TabIndex = 18;
            this.updatebkbtn.Text = "Update Book";
            this.updatebkbtn.UseVisualStyleBackColor = true;
            this.updatebkbtn.Click += new System.EventHandler(this.updatebkbtn_Click);
            // 
            // Lshelflbl
            // 
            this.Lshelflbl.AutoSize = true;
            this.Lshelflbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lshelflbl.Location = new System.Drawing.Point(59, 176);
            this.Lshelflbl.Name = "Lshelflbl";
            this.Lshelflbl.Size = new System.Drawing.Size(47, 16);
            this.Lshelflbl.TabIndex = 4;
            this.Lshelflbl.Text = "Shelf : ";
            // 
            // Llibrarylbl
            // 
            this.Llibrarylbl.AutoSize = true;
            this.Llibrarylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llibrarylbl.Location = new System.Drawing.Point(59, 121);
            this.Llibrarylbl.Name = "Llibrarylbl";
            this.Llibrarylbl.Size = new System.Drawing.Size(55, 16);
            this.Llibrarylbl.TabIndex = 3;
            this.Llibrarylbl.Text = "Library :";
            // 
            // blocationlbl
            // 
            this.blocationlbl.AutoSize = true;
            this.blocationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocationlbl.Location = new System.Drawing.Point(62, 151);
            this.blocationlbl.Name = "blocationlbl";
            this.blocationlbl.Size = new System.Drawing.Size(117, 16);
            this.blocationlbl.TabIndex = 2;
            this.blocationlbl.Text = "Location of Book : ";
            // 
            // bdescriptionlbl
            // 
            this.bdescriptionlbl.AutoSize = true;
            this.bdescriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdescriptionlbl.Location = new System.Drawing.Point(59, 92);
            this.bdescriptionlbl.Name = "bdescriptionlbl";
            this.bdescriptionlbl.Size = new System.Drawing.Size(134, 16);
            this.bdescriptionlbl.TabIndex = 1;
            this.bdescriptionlbl.Text = "Description of Book : ";
            // 
            // btitlelbl
            // 
            this.btitlelbl.AutoSize = true;
            this.btitlelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btitlelbl.Location = new System.Drawing.Point(57, 46);
            this.btitlelbl.Name = "btitlelbl";
            this.btitlelbl.Size = new System.Drawing.Size(117, 25);
            this.btitlelbl.TabIndex = 0;
            this.btitlelbl.Text = "BOOK TITLE";
            // 
            // titlelistbox
            // 
            this.titlelistbox.FormattingEnabled = true;
            this.titlelistbox.Location = new System.Drawing.Point(26, 205);
            this.titlelistbox.Name = "titlelistbox";
            this.titlelistbox.Size = new System.Drawing.Size(226, 277);
            this.titlelistbox.TabIndex = 15;
            this.titlelistbox.SelectedIndexChanged += new System.EventHandler(this.titlelistbox_SelectedIndexChanged);
            // 
            // sisbnbtn
            // 
            this.sisbnbtn.Location = new System.Drawing.Point(73, 155);
            this.sisbnbtn.Name = "sisbnbtn";
            this.sisbnbtn.Size = new System.Drawing.Size(94, 28);
            this.sisbnbtn.TabIndex = 14;
            this.sisbnbtn.Text = "By ISBN";
            this.sisbnbtn.UseVisualStyleBackColor = true;
            this.sisbnbtn.Click += new System.EventHandler(this.sisbnbtn_Click);
            // 
            // sgenrebtn
            // 
            this.sgenrebtn.Location = new System.Drawing.Point(134, 121);
            this.sgenrebtn.Name = "sgenrebtn";
            this.sgenrebtn.Size = new System.Drawing.Size(94, 28);
            this.sgenrebtn.TabIndex = 13;
            this.sgenrebtn.Text = "By Genre";
            this.sgenrebtn.UseVisualStyleBackColor = true;
            this.sgenrebtn.Click += new System.EventHandler(this.sgenrebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search:";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(26, 95);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(202, 20);
            this.searchbox.TabIndex = 11;
            // 
            // stitlebtn
            // 
            this.stitlebtn.Location = new System.Drawing.Point(26, 121);
            this.stitlebtn.Name = "stitlebtn";
            this.stitlebtn.Size = new System.Drawing.Size(89, 28);
            this.stitlebtn.TabIndex = 10;
            this.stitlebtn.Text = "By Title";
            this.stitlebtn.UseVisualStyleBackColor = true;
            this.stitlebtn.Click += new System.EventHandler(this.stitlebtn_Click);
            // 
            // addbkbtn
            // 
            this.addbkbtn.Location = new System.Drawing.Point(269, 218);
            this.addbkbtn.Name = "addbkbtn";
            this.addbkbtn.Size = new System.Drawing.Size(104, 45);
            this.addbkbtn.TabIndex = 11;
            this.addbkbtn.Text = "Add Book";
            this.addbkbtn.UseVisualStyleBackColor = true;
            this.addbkbtn.Click += new System.EventHandler(this.addbkbtn_Click);
            // 
            // bugbtn
            // 
            this.bugbtn.Location = new System.Drawing.Point(787, 16);
            this.bugbtn.Name = "bugbtn";
            this.bugbtn.Size = new System.Drawing.Size(104, 45);
            this.bugbtn.TabIndex = 17;
            this.bugbtn.Text = "View Bug Reports";
            this.bugbtn.UseVisualStyleBackColor = true;
            this.bugbtn.Click += new System.EventHandler(this.bugbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(911, 16);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(104, 45);
            this.logoutbtn.TabIndex = 19;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 523);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.bugbtn);
            this.Controls.Add(this.welcomelbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlelistbox);
            this.Controls.Add(this.sisbnbtn);
            this.Controls.Add(this.sgenrebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.stitlebtn);
            this.Name = "Form4";
            this.Text = "Admin Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deletebkbtn;
        private System.Windows.Forms.Button updatebkbtn;
        private System.Windows.Forms.Label Lshelflbl;
        private System.Windows.Forms.Label Llibrarylbl;
        private System.Windows.Forms.Label blocationlbl;
        private System.Windows.Forms.Label bdescriptionlbl;
        private System.Windows.Forms.Label btitlelbl;
        private System.Windows.Forms.ListBox titlelistbox;
        private System.Windows.Forms.Button sisbnbtn;
        private System.Windows.Forms.Button sgenrebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button stitlebtn;
        private System.Windows.Forms.Button addbkbtn;
        private System.Windows.Forms.Button bugbtn;
        private System.Windows.Forms.Button logoutbtn;
    }
}