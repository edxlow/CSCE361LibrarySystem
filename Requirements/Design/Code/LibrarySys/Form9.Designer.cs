namespace LibrarySys
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.statuslbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.UserIDlistbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bktitlelistbox = new System.Windows.Forms.ListBox();
            this.approveborrowbtn = new System.Windows.Forms.Button();
            this.borrowIDlbl = new System.Windows.Forms.Label();
            this.approvereturnbtn = new System.Windows.Forms.Button();
            this.borrowwID = new System.Windows.Forms.Label();
            this.returntimelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.BackColor = System.Drawing.Color.Transparent;
            this.statuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(583, 111);
            this.statuslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(67, 20);
            this.statuslbl.TabIndex = 22;
            this.statuslbl.Text = "Status :";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelbtn.FlatAppearance.BorderSize = 2;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(965, 325);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(133, 46);
            this.cancelbtn.TabIndex = 19;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // UserIDlistbox
            // 
            this.UserIDlistbox.FormattingEnabled = true;
            this.UserIDlistbox.ItemHeight = 16;
            this.UserIDlistbox.Location = new System.Drawing.Point(64, 111);
            this.UserIDlistbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserIDlistbox.Name = "UserIDlistbox";
            this.UserIDlistbox.Size = new System.Drawing.Size(217, 372);
            this.UserIDlistbox.TabIndex = 18;
            this.UserIDlistbox.SelectedIndexChanged += new System.EventHandler(this.UserIDlistbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Viewing Check Out Requests";
            // 
            // bktitlelistbox
            // 
            this.bktitlelistbox.FormattingEnabled = true;
            this.bktitlelistbox.ItemHeight = 16;
            this.bktitlelistbox.Location = new System.Drawing.Point(313, 111);
            this.bktitlelistbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bktitlelistbox.Name = "bktitlelistbox";
            this.bktitlelistbox.Size = new System.Drawing.Size(250, 372);
            this.bktitlelistbox.TabIndex = 24;
            this.bktitlelistbox.SelectedIndexChanged += new System.EventHandler(this.bktitlelistbox_SelectedIndexChanged);
            // 
            // approveborrowbtn
            // 
            this.approveborrowbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.approveborrowbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.approveborrowbtn.FlatAppearance.BorderSize = 2;
            this.approveborrowbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveborrowbtn.Location = new System.Drawing.Point(603, 325);
            this.approveborrowbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.approveborrowbtn.Name = "approveborrowbtn";
            this.approveborrowbtn.Size = new System.Drawing.Size(133, 46);
            this.approveborrowbtn.TabIndex = 25;
            this.approveborrowbtn.Text = "Approve Borrow";
            this.approveborrowbtn.UseVisualStyleBackColor = false;
            this.approveborrowbtn.Click += new System.EventHandler(this.approveborrowbtn_Click);
            // 
            // borrowIDlbl
            // 
            this.borrowIDlbl.AutoSize = true;
            this.borrowIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.borrowIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowIDlbl.Location = new System.Drawing.Point(583, 183);
            this.borrowIDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borrowIDlbl.Name = "borrowIDlbl";
            this.borrowIDlbl.Size = new System.Drawing.Size(95, 20);
            this.borrowIDlbl.TabIndex = 26;
            this.borrowIDlbl.Text = "Borrow ID :";
            // 
            // approvereturnbtn
            // 
            this.approvereturnbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.approvereturnbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.approvereturnbtn.FlatAppearance.BorderSize = 2;
            this.approvereturnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approvereturnbtn.Location = new System.Drawing.Point(787, 325);
            this.approvereturnbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.approvereturnbtn.Name = "approvereturnbtn";
            this.approvereturnbtn.Size = new System.Drawing.Size(133, 46);
            this.approvereturnbtn.TabIndex = 28;
            this.approvereturnbtn.Text = "Approve Return";
            this.approvereturnbtn.UseVisualStyleBackColor = false;
            this.approvereturnbtn.Click += new System.EventHandler(this.approvereturnbtn_Click);
            // 
            // borrowwID
            // 
            this.borrowwID.AutoSize = true;
            this.borrowwID.BackColor = System.Drawing.Color.Transparent;
            this.borrowwID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowwID.ForeColor = System.Drawing.Color.Transparent;
            this.borrowwID.Location = new System.Drawing.Point(583, 236);
            this.borrowwID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borrowwID.Name = "borrowwID";
            this.borrowwID.Size = new System.Drawing.Size(14, 20);
            this.borrowwID.TabIndex = 37;
            this.borrowwID.Text = " ";
            // 
            // returntimelbl
            // 
            this.returntimelbl.AutoSize = true;
            this.returntimelbl.BackColor = System.Drawing.Color.Transparent;
            this.returntimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returntimelbl.Location = new System.Drawing.Point(583, 256);
            this.returntimelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returntimelbl.Name = "returntimelbl";
            this.returntimelbl.Size = new System.Drawing.Size(166, 20);
            this.returntimelbl.TabIndex = 38;
            this.returntimelbl.Text = "Days Left to Return :";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 534);
            this.Controls.Add(this.returntimelbl);
            this.Controls.Add(this.borrowwID);
            this.Controls.Add(this.approvereturnbtn);
            this.Controls.Add(this.borrowIDlbl);
            this.Controls.Add(this.approveborrowbtn);
            this.Controls.Add(this.bktitlelistbox);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.UserIDlistbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ListBox UserIDlistbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox bktitlelistbox;
        private System.Windows.Forms.Button approveborrowbtn;
        private System.Windows.Forms.Label borrowIDlbl;
        private System.Windows.Forms.Button approvereturnbtn;
        private System.Windows.Forms.Label borrowwID;
        private System.Windows.Forms.Label returntimelbl;
    }
}