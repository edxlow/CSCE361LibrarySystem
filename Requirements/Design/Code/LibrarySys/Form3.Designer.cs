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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.stitlebtn = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sgenrebtn = new System.Windows.Forms.Button();
            this.sisbnbtn = new System.Windows.Forms.Button();
            this.reportlink = new System.Windows.Forms.LinkLabel();
            this.titlelistbox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.availbl = new System.Windows.Forms.Label();
            this.Lshelflbl = new System.Windows.Forms.Label();
            this.Llibrarylbl = new System.Windows.Forms.Label();
            this.blocationlbl = new System.Windows.Forms.Label();
            this.bdescriptionlbl = new System.Windows.Forms.Label();
            this.btitlelbl = new System.Windows.Forms.Label();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.userIDlbl = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.checkoutbtn = new System.Windows.Forms.Button();
            this.viewchckbksbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ratinglbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stitlebtn
            // 
            this.stitlebtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stitlebtn.FlatAppearance.BorderSize = 2;
            this.stitlebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stitlebtn.Location = new System.Drawing.Point(42, 120);
            this.stitlebtn.Name = "stitlebtn";
            this.stitlebtn.Size = new System.Drawing.Size(89, 28);
            this.stitlebtn.TabIndex = 0;
            this.stitlebtn.Text = "By Title";
            this.stitlebtn.UseVisualStyleBackColor = false;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // sgenrebtn
            // 
            this.sgenrebtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sgenrebtn.FlatAppearance.BorderSize = 2;
            this.sgenrebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sgenrebtn.Location = new System.Drawing.Point(150, 120);
            this.sgenrebtn.Name = "sgenrebtn";
            this.sgenrebtn.Size = new System.Drawing.Size(94, 28);
            this.sgenrebtn.TabIndex = 3;
            this.sgenrebtn.Text = "By Genre";
            this.sgenrebtn.UseVisualStyleBackColor = false;
            this.sgenrebtn.Click += new System.EventHandler(this.sgenrebtn_Click);
            // 
            // sisbnbtn
            // 
            this.sisbnbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sisbnbtn.FlatAppearance.BorderSize = 2;
            this.sisbnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sisbnbtn.Location = new System.Drawing.Point(89, 154);
            this.sisbnbtn.Name = "sisbnbtn";
            this.sisbnbtn.Size = new System.Drawing.Size(94, 28);
            this.sisbnbtn.TabIndex = 4;
            this.sisbnbtn.Text = "By ISBN";
            this.sisbnbtn.UseVisualStyleBackColor = false;
            this.sisbnbtn.Click += new System.EventHandler(this.sisbnbtn_Click);
            // 
            // reportlink
            // 
            this.reportlink.AutoSize = true;
            this.reportlink.BackColor = System.Drawing.Color.Transparent;
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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ratinglbl);
            this.panel1.Controls.Add(this.availbl);
            this.panel1.Controls.Add(this.Lshelflbl);
            this.panel1.Controls.Add(this.Llibrarylbl);
            this.panel1.Controls.Add(this.blocationlbl);
            this.panel1.Controls.Add(this.bdescriptionlbl);
            this.panel1.Controls.Add(this.btitlelbl);
            this.panel1.Location = new System.Drawing.Point(399, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 310);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // availbl
            // 
            this.availbl.AutoSize = true;
            this.availbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.availbl.Location = new System.Drawing.Point(66, 239);
            this.availbl.Name = "availbl";
            this.availbl.Size = new System.Drawing.Size(79, 16);
            this.availbl.TabIndex = 5;
            this.availbl.Text = "Availability :";
            // 
            // Lshelflbl
            // 
            this.Lshelflbl.AutoSize = true;
            this.Lshelflbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lshelflbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.Llibrarylbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.blocationlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.bdescriptionlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.btitlelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btitlelbl.Location = new System.Drawing.Point(64, 59);
            this.btitlelbl.Name = "btitlelbl";
            this.btitlelbl.Size = new System.Drawing.Size(117, 25);
            this.btitlelbl.TabIndex = 0;
            this.btitlelbl.Text = "BOOK TITLE";
            // 
            // welcomelbl
            // 
            this.welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomelbl.Location = new System.Drawing.Point(39, 21);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(291, 23);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "Welcome";
            // 
            // userIDlbl
            // 
            this.userIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.userIDlbl.Location = new System.Drawing.Point(950, 495);
            this.userIDlbl.Name = "userIDlbl";
            this.userIDlbl.Size = new System.Drawing.Size(100, 23);
            this.userIDlbl.TabIndex = 9;
            this.userIDlbl.Text = "Welcome";
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutbtn.FlatAppearance.BorderSize = 2;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Location = new System.Drawing.Point(975, 14);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 30);
            this.logoutbtn.TabIndex = 20;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkoutbtn.FlatAppearance.BorderSize = 2;
            this.checkoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutbtn.Location = new System.Drawing.Point(757, 410);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.Size = new System.Drawing.Size(104, 45);
            this.checkoutbtn.TabIndex = 21;
            this.checkoutbtn.Text = "Check Out";
            this.checkoutbtn.UseVisualStyleBackColor = false;
            this.checkoutbtn.Click += new System.EventHandler(this.checkoutbtn_Click);
            // 
            // viewchckbksbtn
            // 
            this.viewchckbksbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewchckbksbtn.FlatAppearance.BorderSize = 2;
            this.viewchckbksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewchckbksbtn.Location = new System.Drawing.Point(893, 410);
            this.viewchckbksbtn.Name = "viewchckbksbtn";
            this.viewchckbksbtn.Size = new System.Drawing.Size(104, 45);
            this.viewchckbksbtn.TabIndex = 22;
            this.viewchckbksbtn.Text = "View Checked Out Books";
            this.viewchckbksbtn.UseVisualStyleBackColor = false;
            this.viewchckbksbtn.Click += new System.EventHandler(this.viewchckbksbtn_Click);
            // 
            // ratinglbl
            // 
            this.ratinglbl.AutoSize = true;
            this.ratinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratinglbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ratinglbl.Location = new System.Drawing.Point(66, 270);
            this.ratinglbl.Name = "ratinglbl";
            this.ratinglbl.Size = new System.Drawing.Size(53, 16);
            this.ratinglbl.TabIndex = 23;
            this.ratinglbl.Text = "Rating :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 520);
            this.Controls.Add(this.viewchckbksbtn);
            this.Controls.Add(this.checkoutbtn);
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
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.Label availbl;
        private System.Windows.Forms.Button checkoutbtn;
        private System.Windows.Forms.Button viewchckbksbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ratinglbl;
    }
}