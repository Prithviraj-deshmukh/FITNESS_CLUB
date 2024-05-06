using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FITNESS_CLUB
{
    public partial class Billing : Form
    {
        CFile CF = new CFile();
        public Billing()
        {
            InitializeComponent();
        }
        void GetMaxId()
        {
            billnoTxt.Text = CF.GetAutoId("Select MAX(Bid)From BillTbl").ToString();

        }

        void clrdata()
        {

            billnoTxt.Clear();
            monthtxt.Clear();
            priceTxt.Clear();
            discountTxt.Clear();
            finelTxt.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (billnoTxt.Text != ""&& priceTxt.Text != "" && finelTxt.Text != "")
            {
                CF.ExecuteSqlQuery("Insert into BillTbl(Bid,month,Bprice,discount,famount)values('" + billnoTxt.Text + "','"+monthtxt.Text+"','" + priceTxt.Text + "','" + discountTxt.Text + "','" + finelTxt.Text + "')");
                CF.fillgriddata(billdt, "Select * from BillTbl");

                MessageBox.Show("data saved succeessfully");

                clrdata();
                newBtn.Focus();

            }
            else
            {
                MessageBox.Show("First Fill All The Fields");
            }

        }
        void DisplayGrid()
        {
            try
            {

                billnoTxt.Text = billdt.SelectedRows[0].Cells["Bid"].Value.ToString();
                monthtxt.Text = billdt.SelectedRows[0].Cells["month"].Value.ToString();
                priceTxt.Text = billdt.SelectedRows[0].Cells["Bprice"].Value.ToString();
                discountTxt.Text = billdt.SelectedRows[0].Cells["discount"].Value.ToString();
                finelTxt.Text = billdt.SelectedRows[0].Cells["famount"].Value.ToString();
            }
            catch
            {

            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            CF.ExecuteSqlQuery("Update BillTbl SET month='"+monthtxt.Text+"',Bprice='" + priceTxt.Text + "',discount='" + discountTxt.Text + "',famount='" + finelTxt.Text + "'where bill_no='" + billnoTxt.Text + "'");
            CF.fillgriddata(billdt, "select * from BillTbl");
            MessageBox.Show("Update Successfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CF.ExecuteSqlQuery("Delete from BillTbl where Bid='" + billnoTxt.Text + "'");

                CF.fillgriddata(billdt, "select * from BillTbl");
                clrdata();
                MessageBox.Show("Data Deleted Successefully......!");

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
           monthtxt.Focus();
            GetMaxId();
            saveBtn.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            CF.fillgriddata(billdt, "Select * from BillTbl");
        }

        private void billdt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisplayGrid();
        }
    }
}
