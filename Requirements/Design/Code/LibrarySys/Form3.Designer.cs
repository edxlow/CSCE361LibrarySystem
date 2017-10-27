namespace LibrarySys
{
    partial class Form3
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
            this.stitlebtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sgenrebtn = new System.Windows.Forms.Button();
            this.sisbnbtn = new System.Windows.Forms.Button();
            this.reportlink = new System.Windows.Forms.LinkLabel();
            this.titlelistbox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lshelflbl = new System.Windows.Forms.Label();
            this.Llibrarylbl = new System.Windows.Forms.Label();
            this.blocationlbl = new System.Windows.Forms.Label();
            this.bdescriptionlbl = new System.Windows.Forms.Label();
            this.btitlelbl = new System.Windows.Forms.Label();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.userIDlbl = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stitlebtn
            // 
            this.stitlebtn.Location = new System.Drawing.Point(42, 120);
            this.stitlebtn.Name = "stitlebtn";
            this.stitlebtn.Size = new System.Drawing.Size(89, 28);
            this.stitlebtn.TabIndex = 0;
            this.stitlebtn.Text = "By Title";
            this.stitlebtn.UseVisualStyleBackColor = true;
            this.stitlebtn.Click += new System.EventHandler(this.stitlebtn_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(42, 94);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(202, 20);
            this.searchbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // sgenrebtn
            // 
            this.sgenrebtn.Location = new System.Drawing.Point(150, 120);
            this.sgenrebtn.Name = "sgenrebtn";
            this.sgenrebtn.Size = new System.Drawing.Size(94, 28);
            this.sgenrebtn.TabIndex = 3;
            this.sgenrebtn.Text = "By Genre";
            this.sgenrebtn.UseVisualStyleBackColor = true;
            this.sgenrebtn.Click += new System.EventHandler(this.sgenrebtn_Click);
            // 
            // sisbnbtn
            // 
            this.sisbnbtn.Location = new System.Drawing.Point(89, 154);
            this.sisbnbtn.Name = "sisbnbtn";
            this.sisbnbtn.Size = new System.Drawing.Size(94, 28);
            this.sisbnbtn.TabIndex = 4;
            this.sisbnbtn.Text = "By ISBN";
            this.sisbnbtn.UseVisualStyleBackColor = true;
            this.sisbnbtn.Click += new System.EventHandler(this.sisbnbtn_Click);
            // 
            // reportlink
            // 
            this.reportlink.AutoSize = true;
            this.reportlink.Location = new System.Drawing.Point(33, 495);
            this.reportlink.Name = "reportlink";
            this.reportlink.Size = new System.Drawing.Size(98, 13);
            this.reportlink.TabIndex = 5;
            this.reportlink.TabStop = true;
            this.reportlink.Text = "Report Bugs Here !";
            this.reportlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reportlink_LinkClicked);
            // 
            // titlelistbox
            // 
            this.titlelistbox.FormattingEnabled = true;
            this.titlelistbox.Location = new System.Drawing.Point(42, 204);
            this.titlelistbox.Name = "titlelistbox";
            this.titlelistbox.Size = new System.Drawing.Size(226, 251);
            this.titlelistbox.TabIndex = 7;
            this.titlelistbox.SelectedIndexChanged += new System.EventHandler(this.titlelistbox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lshelflbl);
            this.panel1.Controls.Add(this.Llibrarylbl);
            this.panel1.Controls.Add(this.blocationlbl);
            this.panel1.Controls.Add(this.bdescriptionlbl);
            this.panel1.Controls.Add(this.btitlelbl);
            this.panel1.Location = new System.Drawing.Point(354, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 274);
            this.panel1.TabIndex = 8;
            // 
            // Lshelflbl
            // 
            this.Lshelflbl.AutoSize = true;
            this.Lshelflbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lshelflbl.Location = new System.Drawing.Point(66, 207);
            this.Lshelflbl.Name = "Lshelflbl";
            this.Lshelflbl.Size = new System.Drawing.Size(47, 16);
            this.Lshelflbl.TabIndex = 4;
            this.Lshelflbl.Text = "Shelf : ";
            // 
            // Llibrarylbl
            // 
            this.Llibrarylbl.AutoSize = true;
            this.Llibrarylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llibrarylbl.Location = new System.Drawing.Point(66, 143);
            this.Llibrarylbl.Name = "Llibrarylbl";
            this.Llibrarylbl.Size = new System.Drawing.Size(55, 16);
            this.Llibrarylbl.TabIndex = 3;
            this.Llibrarylbl.Text = "Library :";
            // 
            // blocationlbl
            // 
            this.blocationlbl.AutoSize = true;
            this.blocationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocationlbl.Location = new System.Drawing.Point(66, 174);
            this.blocationlbl.Name = "blocationlbl";
            this.blocationlbl.Size = new System.Drawing.Size(117, 16);
            this.blocationlbl.TabIndex = 2;
            this.blocationlbl.Text = "Location of Book : ";
            // 
            // bdescriptionlbl
            // 
            this.bdescriptionlbl.AutoSize = true;
            this.bdescriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdescriptionlbl.Location = new System.Drawing.Point(66, 110);
            this.bdescriptionlbl.Name = "bdescriptionlbl";
            this.bdescriptionlbl.Size = new System.Drawing.Size(134, 16);
            this.bdescriptionlbl.TabIndex = 1;
            this.bdescriptionlbl.Text = "Description of Book : ";
            // 
            // btitlelbl
            // 
            this.btitlelbl.AutoSize = true;
            this.btitlelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btitlelbl.Location = new System.Drawing.Point(64, 59);
            this.btitlelbl.Name = "btitlelbl";
            this.btitlelbl.Size = new System.Drawing.Size(117, 25);
            this.btitlelbl.TabIndex = 0;
            this.btitlelbl.Text = "BOOK TITLE";
            // 
            // welcomelbl
            // 
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(39, 21);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(100, 23);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "Welcome";
            // 
            // userIDlbl
            // 
            this.userIDlbl.Location = new System.Drawing.Point(950, 495);
            this.userIDlbl.Name = "userIDlbl";
            this.userIDlbl.Size = new System.Drawing.Size(100, 23);
            this.userIDlbl.TabIndex = 9;
            this.userIDlbl.Text = "Welcome";
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(935, 21);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(104, 45);
            this.logoutbtn.TabIndex = 20;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 520);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.userIDlbl);
            this.Controls.Add(this.welcomelbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlelistbox);
            this.Controls.Add(this.reportlink);
            this.Controls.Add(this.sisbnbtn);
            this.Controls.Add(this.sgenrebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.stitlebtn);
            this.Name = "Form3";
            this.Text = "Student Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stitlebtn;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sgenrebtn;
        private System.Windows.Forms.Button sisbnbtn;
        private System.Windows.Forms.LinkLabel reportlink;
        private System.Windows.Forms.ListBox titlelistbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lshelflbl;
        private System.Windows.Forms.Label Llibrarylbl;
        private System.Windows.Forms.Label blocationlbl;
        private System.Windows.Forms.Label bdescriptionlbl;
        private System.Windows.Forms.Label btitlelbl;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Label userIDlbl;
        private System.Windows.Forms.Button logoutbtn;
    }
}