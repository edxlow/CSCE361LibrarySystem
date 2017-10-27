namespace LibrarySys
{
    partial class Form2
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
            this.registerbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phonenumBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.PWbox = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.CPWBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.pnumlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.cpwlbl = new System.Windows.Forms.Label();
            this.pwlbl = new System.Windows.Forms.Label();
            this.addlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.userIDbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(233, 345);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(93, 36);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(72, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(233, 73);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(219, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(72, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(72, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(72, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(72, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address : ";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(233, 294);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(219, 20);
            this.addressBox.TabIndex = 7;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // phonenumBox
            // 
            this.phonenumBox.Location = new System.Drawing.Point(233, 257);
            this.phonenumBox.Multiline = true;
            this.phonenumBox.Name = "phonenumBox";
            this.phonenumBox.Size = new System.Drawing.Size(219, 20);
            this.phonenumBox.TabIndex = 8;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(233, 220);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(219, 20);
            this.emailBox.TabIndex = 9;
            // 
            // PWbox
            // 
            this.PWbox.Location = new System.Drawing.Point(233, 150);
            this.PWbox.Multiline = true;
            this.PWbox.Name = "PWbox";
            this.PWbox.Size = new System.Drawing.Size(219, 20);
            this.PWbox.TabIndex = 10;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(354, 345);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(98, 36);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // CPWBox
            // 
            this.CPWBox.Location = new System.Drawing.Point(233, 184);
            this.CPWBox.Multiline = true;
            this.CPWBox.Name = "CPWBox";
            this.CPWBox.Size = new System.Drawing.Size(219, 20);
            this.CPWBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(72, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Confirm Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Account Registration ";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.Red;
            this.namelbl.Location = new System.Drawing.Point(458, 77);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(12, 17);
            this.namelbl.TabIndex = 15;
            this.namelbl.Text = " ";
            // 
            // pnumlbl
            // 
            this.pnumlbl.AutoSize = true;
            this.pnumlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pnumlbl.ForeColor = System.Drawing.Color.Red;
            this.pnumlbl.Location = new System.Drawing.Point(458, 260);
            this.pnumlbl.Name = "pnumlbl";
            this.pnumlbl.Size = new System.Drawing.Size(12, 17);
            this.pnumlbl.TabIndex = 16;
            this.pnumlbl.Text = " ";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.emaillbl.ForeColor = System.Drawing.Color.Red;
            this.emaillbl.Location = new System.Drawing.Point(458, 223);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(12, 17);
            this.emaillbl.TabIndex = 17;
            this.emaillbl.Text = " ";
            // 
            // cpwlbl
            // 
            this.cpwlbl.AutoSize = true;
            this.cpwlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cpwlbl.ForeColor = System.Drawing.Color.Red;
            this.cpwlbl.Location = new System.Drawing.Point(458, 187);
            this.cpwlbl.Name = "cpwlbl";
            this.cpwlbl.Size = new System.Drawing.Size(12, 17);
            this.cpwlbl.TabIndex = 18;
            this.cpwlbl.Text = " ";
            this.cpwlbl.Click += new System.EventHandler(this.cpwlbl_Click);
            // 
            // pwlbl
            // 
            this.pwlbl.AutoSize = true;
            this.pwlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pwlbl.ForeColor = System.Drawing.Color.Red;
            this.pwlbl.Location = new System.Drawing.Point(458, 153);
            this.pwlbl.Name = "pwlbl";
            this.pwlbl.Size = new System.Drawing.Size(12, 17);
            this.pwlbl.TabIndex = 19;
            this.pwlbl.Text = " ";
            // 
            // addlbl
            // 
            this.addlbl.AutoSize = true;
            this.addlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.addlbl.ForeColor = System.Drawing.Color.Red;
            this.addlbl.Location = new System.Drawing.Point(458, 297);
            this.addlbl.Name = "addlbl";
            this.addlbl.Size = new System.Drawing.Size(12, 17);
            this.addlbl.TabIndex = 20;
            this.addlbl.Text = " ";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.Red;
            this.userlbl.Location = new System.Drawing.Point(458, 115);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(12, 17);
            this.userlbl.TabIndex = 23;
            this.userlbl.Text = " ";
            // 
            // userIDbox
            // 
            this.userIDbox.Location = new System.Drawing.Point(233, 111);
            this.userIDbox.Multiline = true;
            this.userIDbox.Name = "userIDbox";
            this.userIDbox.Size = new System.Drawing.Size(219, 20);
            this.userIDbox.TabIndex = 22;
            this.userIDbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(72, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "UserID : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 423);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.userIDbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addlbl);
            this.Controls.Add(this.pwlbl);
            this.Controls.Add(this.cpwlbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.pnumlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CPWBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.PWbox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phonenumBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerbtn);
            this.Name = "Form2";
            this.Text = "Account Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox phonenumBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox PWbox;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox CPWBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label pnumlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label cpwlbl;
        private System.Windows.Forms.Label pwlbl;
        private System.Windows.Forms.Label addlbl;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.TextBox userIDbox;
        private System.Windows.Forms.Label label9;
    }
}