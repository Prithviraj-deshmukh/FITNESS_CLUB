namespace FITNESS_CLUB
{
    partial class Newmember
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
            this.membershiptimeCmb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gymtimeCmb = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.jdate = new System.Windows.Forms.DateTimePicker();
            this.bdate = new System.Windows.Forms.DateTimePicker();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.memberDG = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDG)).BeginInit();
            this.SuspendLayout();
            // 
            // membershiptimeCmb
            // 
            this.membershiptimeCmb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershiptimeCmb.FormattingEnabled = true;
            this.membershiptimeCmb.Items.AddRange(new object[] {
            "1 Month",
            "2 Month",
            "3 Month",
            "6 Month",
            "12 Month"});
            this.membershiptimeCmb.Location = new System.Drawing.Point(592, 327);
            this.membershiptimeCmb.Margin = new System.Windows.Forms.Padding(4);
            this.membershiptimeCmb.Name = "membershiptimeCmb";
            this.membershiptimeCmb.Size = new System.Drawing.Size(235, 31);
            this.membershiptimeCmb.TabIndex = 53;
            this.membershiptimeCmb.Text = "--Select--";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 58);
            this.label10.TabIndex = 52;
            this.label10.Text = "Membership Time";
            // 
            // gymtimeCmb
            // 
            this.gymtimeCmb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymtimeCmb.FormattingEnabled = true;
            this.gymtimeCmb.Items.AddRange(new object[] {
            "06AM-07AM",
            "07AM-08AM",
            "08AM-09AM",
            "05PM-06PM",
            "06PM-07PM"});
            this.gymtimeCmb.Location = new System.Drawing.Point(584, 189);
            this.gymtimeCmb.Margin = new System.Windows.Forms.Padding(4);
            this.gymtimeCmb.Name = "gymtimeCmb";
            this.gymtimeCmb.Size = new System.Drawing.Size(235, 31);
            this.gymtimeCmb.TabIndex = 51;
            this.gymtimeCmb.Text = "--Select Time--";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(337, 471);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(108, 42);
            this.saveBtn.TabIndex = 47;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(584, 254);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(4);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(235, 33);
            this.addressTxt.TabIndex = 46;
            // 
            // mobileTxt
            // 
            this.mobileTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTxt.Location = new System.Drawing.Point(606, 415);
            this.mobileTxt.Margin = new System.Windows.Forms.Padding(4);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(235, 31);
            this.mobileTxt.TabIndex = 43;
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxt.Location = new System.Drawing.Point(173, 266);
            this.lastnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(235, 31);
            this.lastnameTxt.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Gym Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 257);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Join Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Last Name";
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxt.Location = new System.Drawing.Point(173, 197);
            this.firstnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(235, 31);
            this.firstnameTxt.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(403, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 59);
            this.label11.TabIndex = 43;
            this.label11.Text = "New Member";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Maroon;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(1319, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 34);
            this.label12.TabIndex = 44;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Maroon;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Snow;
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 34);
            this.label13.TabIndex = 55;
            this.label13.Text = "<";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 111);
            this.panel1.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 136);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 23);
            this.label14.TabIndex = 55;
            this.label14.Text = "Id";
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(173, 141);
            this.idtxt.Margin = new System.Windows.Forms.Padding(4);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(235, 31);
            this.idtxt.TabIndex = 56;
            // 
            // jdate
            // 
            this.jdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jdate.Location = new System.Drawing.Point(584, 136);
            this.jdate.Name = "jdate";
            this.jdate.Size = new System.Drawing.Size(235, 30);
            this.jdate.TabIndex = 57;
            // 
            // bdate
            // 
            this.bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.Location = new System.Drawing.Point(173, 383);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(235, 30);
            this.bdate.TabIndex = 58;
            // 
            // genderCmb
            // 
            this.genderCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.Location = new System.Drawing.Point(173, 327);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(235, 33);
            this.genderCmb.TabIndex = 59;
            // 
            // memberDG
            // 
            this.memberDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fname,
            this.lname,
            this.gender,
            this.dob,
            this.mobile,
            this.jadate,
            this.time,
            this.address,
            this.mtime});
            this.memberDG.Location = new System.Drawing.Point(-2, 520);
            this.memberDG.Name = "memberDG";
            this.memberDG.RowTemplate.Height = 24;
            this.memberDG.Size = new System.Drawing.Size(1369, 243);
            this.memberDG.TabIndex = 60;
            this.memberDG.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.memberDG_MouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Birth Date";
            this.dob.Name = "dob";
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "Mobile";
            this.mobile.Name = "mobile";
            // 
            // jadate
            // 
            this.jadate.DataPropertyName = "jadate";
            this.jadate.HeaderText = "Join Date";
            this.jadate.Name = "jadate";
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Gym Time";
            this.time.Name = "time";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // mtime
            // 
            this.mtime.DataPropertyName = "mtime";
            this.mtime.HeaderText = "Membership Time";
            this.mtime.Name = "mtime";
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(173, 471);
            this.newBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(120, 33);
            this.newBtn.TabIndex = 69;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(481, 471);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 33);
            this.deleteBtn.TabIndex = 68;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(803, 471);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(120, 33);
            this.exitBtn.TabIndex = 67;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(660, 471);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(120, 33);
            this.updateBtn.TabIndex = 66;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Newmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1367, 764);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.memberDG);
            this.Controls.Add(this.genderCmb);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.jdate);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.membershiptimeCmb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gymtimeCmb);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.mobileTxt);
            this.Controls.Add(this.lastnameTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnameTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Newmember";
            this.Text = "Newmember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Newmember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox membershiptimeCmb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gymtimeCmb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.DateTimePicker jdate;
        private System.Windows.Forms.DateTimePicker bdate;
        private System.Windows.Forms.ComboBox genderCmb;
        private System.Windows.Forms.DataGridView memberDG;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadate;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtime;
    }
}