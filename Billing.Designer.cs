namespace FITNESS_CLUB
{
    partial class Billing
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
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.finelTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.billnoTxt = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.billdt = new System.Windows.Forms.DataGridView();
            this.Bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billdt)).BeginInit();
            this.SuspendLayout();
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(878, 154);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(272, 30);
            this.priceTxt.TabIndex = 226;
            // 
            // finelTxt
            // 
            this.finelTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finelTxt.Location = new System.Drawing.Point(200, 238);
            this.finelTxt.Name = "finelTxt";
            this.finelTxt.Size = new System.Drawing.Size(272, 30);
            this.finelTxt.TabIndex = 225;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 72);
            this.label2.TabIndex = 224;
            this.label2.Text = "Finel Amount";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 39);
            this.label4.TabIndex = 218;
            this.label4.Text = "Bill No";
            // 
            // discountTxt
            // 
            this.discountTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(789, 238);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(272, 30);
            this.discountTxt.TabIndex = 223;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(594, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 42);
            this.label5.TabIndex = 222;
            this.label5.Text = "Discount";
            // 
            // billnoTxt
            // 
            this.billnoTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billnoTxt.Location = new System.Drawing.Point(81, 175);
            this.billnoTxt.Name = "billnoTxt";
            this.billnoTxt.Size = new System.Drawing.Size(272, 30);
            this.billnoTxt.TabIndex = 219;
            // 
            // priceLbl
            // 
            this.priceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(785, 154);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(156, 39);
            this.priceLbl.TabIndex = 217;
            this.priceLbl.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 111);
            this.panel1.TabIndex = 229;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Maroon;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(1286, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 34);
            this.label12.TabIndex = 44;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(578, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 59);
            this.label11.TabIndex = 43;
            this.label11.Text = "Billing";
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(221, 316);
            this.newBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(120, 33);
            this.newBtn.TabIndex = 234;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(529, 316);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 33);
            this.deleteBtn.TabIndex = 233;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(851, 316);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(120, 33);
            this.exitBtn.TabIndex = 232;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(708, 316);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(120, 33);
            this.updateBtn.TabIndex = 231;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(385, 316);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(108, 42);
            this.saveBtn.TabIndex = 230;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // billdt
            // 
            this.billdt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bid,
            this.month,
            this.Bprice,
            this.discount,
            this.famount});
            this.billdt.Location = new System.Drawing.Point(6, 369);
            this.billdt.Name = "billdt";
            this.billdt.RowTemplate.Height = 24;
            this.billdt.Size = new System.Drawing.Size(1315, 251);
            this.billdt.TabIndex = 235;
            this.billdt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.billdt_MouseDoubleClick);
            // 
            // Bid
            // 
            this.Bid.DataPropertyName = "Bid";
            this.Bid.HeaderText = "Id";
            this.Bid.Name = "Bid";
            // 
            // month
            // 
            this.month.DataPropertyName = "month";
            this.month.HeaderText = "Months";
            this.month.Name = "month";
            // 
            // Bprice
            // 
            this.Bprice.DataPropertyName = "Bprice";
            this.Bprice.HeaderText = "Price";
            this.Bprice.Name = "Bprice";
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            // 
            // famount
            // 
            this.famount.DataPropertyName = "famount";
            this.famount.HeaderText = "Amount";
            this.famount.Name = "famount";
            // 
            // monthtxt
            // 
            this.monthtxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthtxt.Location = new System.Drawing.Point(500, 171);
            this.monthtxt.Name = "monthtxt";
            this.monthtxt.Size = new System.Drawing.Size(272, 30);
            this.monthtxt.TabIndex = 237;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 39);
            this.label1.TabIndex = 236;
            this.label1.Text = "Month";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 632);
            this.Controls.Add(this.monthtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billdt);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.finelTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discountTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.billnoTxt);
            this.Controls.Add(this.priceLbl);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox finelTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox billnoTxt;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView billdt;
        private System.Windows.Forms.TextBox monthtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn famount;
    }
}