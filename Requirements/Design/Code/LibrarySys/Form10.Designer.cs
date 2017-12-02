namespace LibrarySys
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.borrowIDlbl = new System.Windows.Forms.Label();
            this.returnbtn = new System.Windows.Forms.Button();
            this.bktitlelistbox = new System.Windows.Forms.ListBox();
            this.statuslbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ratebtn = new System.Windows.Forms.Button();
            this.userIDlbl = new System.Windows.Forms.Label();
            this.borrowwID = new System.Windows.Forms.Label();
            this.ratebox = new System.Windows.Forms.ComboBox();
            this.returntimelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // borrowIDlbl
            // 
            this.borrowIDlbl.AutoSize = true;
            this.borrowIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.borrowIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowIDlbl.Location = new System.Drawing.Point(394, 159);
            this.borrowIDlbl.Name = "borrowIDlbl";
            this.borrowIDlbl.Size = new System.Drawing.Size(72, 16);
            this.borrowIDlbl.TabIndex = 33;
            this.borrowIDlbl.Text = "Borrow ID :";
            // 
            // returnbtn
            // 
            this.returnbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnbtn.FlatAppearance.BorderSize = 2;
            this.returnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbtn.Location = new System.Drawing.Point(420, 254);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(100, 37);
            this.returnbtn.TabIndex = 32;
            this.returnbtn.Text = "Request Return";
            this.returnbtn.UseVisualStyleBackColor = false;
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // bktitlelistbox
            // 
            this.bktitlelistbox.FormattingEnabled = true;
            this.bktitlelistbox.Location = new System.Drawing.Point(59, 99);
            this.bktitlelistbox.Name = "bktitlelistbox";
            this.bktitlelistbox.Size = new System.Drawing.Size(185, 251);
            this.bktitlelistbox.TabIndex = 31;
            this.bktitlelistbox.SelectedIndexChanged += new System.EventHandler(this.bktitlelistbox_SelectedIndexChanged);
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.BackColor = System.Drawing.Color.Transparent;
            this.statuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(394, 118);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(51, 16);
            this.statuslbl.TabIndex = 30;
            this.statuslbl.Text = "Status :";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbtn.FlatAppearance.BorderSize = 2;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(579, 254);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(100, 37);
            this.cancelbtn.TabIndex = 29;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Viewing Checked Out Books";
            // 
            // ratebtn
            // 
            this.ratebtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ratebtn.FlatAppearance.BorderSize = 2;
            this.ratebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratebtn.Location = new System.Drawing.Point(548, 309);
            this.ratebtn.Name = "ratebtn";
            this.ratebtn.Size = new System.Drawing.Size(85, 25);
            this.ratebtn.TabIndex = 34;
            this.ratebtn.Text = "Rate";
            this.ratebtn.UseVisualStyleBackColor = false;
            this.ratebtn.Click += new System.EventHandler(this.ratebtn_Click);
            // 
            // userIDlbl
            // 
            this.userIDlbl.AutoSize = true;
            this.userIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.userIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDlbl.Location = new System.Drawing.Point(679, 334);
            this.userIDlbl.Name = "userIDlbl";
            this.userIDlbl.Size = new System.Drawing.Size(53, 16);
            this.userIDlbl.TabIndex = 35;
            this.userIDlbl.Text = "User ID";
            // 
            // borrowwID
            // 
            this.borrowwID.AutoSize = true;
            this.borrowwID.BackColor = System.Drawing.Color.Transparent;
            this.borrowwID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowwID.ForeColor = System.Drawing.Color.Transparent;
            this.borrowwID.Location = new System.Drawing.Point(394, 89);
            this.borrowwID.Name = "borrowwID";
            this.borrowwID.Size = new System.Drawing.Size(11, 16);
            this.borrowwID.TabIndex = 36;
            this.borrowwID.Text = " ";
            // 
            // ratebox
            // 
            this.ratebox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ratebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratebox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ratebox.FormattingEnabled = true;
            this.ratebox.Location = new System.Drawing.Point(421, 309);
            this.ratebox.Name = "ratebox";
            this.ratebox.Size = new System.Drawing.Size(121, 21);
            this.ratebox.TabIndex = 37;
            // 
            // returntimelbl
            // 
            this.returntimelbl.AutoSize = true;
            this.returntimelbl.BackColor = System.Drawing.Color.Transparent;
            this.returntimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returntimelbl.Location = new System.Drawing.Point(394, 204);
            this.returntimelbl.Name = "returntimelbl";
            this.returntimelbl.Size = new System.Drawing.Size(126, 16);
            this.returntimelbl.TabIndex = 39;
            this.returntimelbl.Text = "Days Left to Return :";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 378);
            this.Controls.Add(this.returntimelbl);
            this.Controls.Add(this.ratebox);
            this.Controls.Add(this.borrowwID);
            this.Controls.Add(this.userIDlbl);
            this.Controls.Add(this.ratebtn);
            this.Controls.Add(this.borrowIDlbl);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.bktitlelistbox);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label borrowIDlbl;
        private System.Windows.Forms.Button returnbtn;
        private System.Windows.Forms.ListBox bktitlelistbox;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ratebtn;
        private System.Windows.Forms.Label userIDlbl;
        private System.Windows.Forms.Label borrowwID;
        private System.Windows.Forms.ComboBox ratebox;
        private System.Windows.Forms.Label returntimelbl;
    }
}