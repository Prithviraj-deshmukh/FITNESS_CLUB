using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FITNESS_CLUB
{
    public partial class Newstaff : Form
    {
        CFile C = new CFile();
        public Newstaff()
        {
            InitializeComponent();
        }


        void GetMaxId()
        {
            idtxt.Text = C.GetAutoId("Select MAX(id)From NstaffTbl").ToString();

        }
        private void Newstaff_Load(object sender, EventArgs e)
        {
            C.fillgriddata(staffDG, "Select * from NstaffTbl");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            firstnameTxt.Focus();
            GetMaxId();
            clrdata();
            saveBtn.Enabled = true;
        }
        void clrdata()
        {

            firstnameTxt.Clear();
            lastnameTxt.Clear();
            genderCmb.SelectedIndex = -1;
            mobileTxt.Clear();
            cityTxt.Clear();
            



        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            if (idtxt.Text != "" && idtxt.Text != "" && firstnameTxt.Text!= "" && lastnameTxt.Text != "" && genderCmb.Text!= ""&& jdate.Text !="" && mobileTxt.Text !=""&& bdate.Text !="" && cityTxt.Text!="" && mobileTxt.Text != "" )
            {

                C.ExecuteSqlQuery("insert into NstaffTbl(id,fname,lname,gender,jodate,bidate,city,mobile)values('" + idtxt.Text + "','" + firstnameTxt.Text + "','" + lastnameTxt.Text + "','" + genderCmb.Text + "','" + jdate.Value.ToString("MM/dd/yyyy") + "','" + bdate.Value.ToString("MM/dd/yyyy") + "','" + cityTxt.Text + "','" + mobileTxt.Text + "')");
                C.fillgriddata(staffDG, "Select * from NstaffTbl");

                MessageBox.Show("data saved succeessfully");


               
            }
            else
            {
                MessageBox.Show("First Fill All The Fields");
            }
           
        }


        public void DisplayGrid()
        {
            try
            {
                idtxt.Text = staffDG.SelectedRows[0].Cells["id"].Value.ToString();
                firstnameTxt.Text = staffDG.SelectedRows[0].Cells["fname"].Value.ToString();
                lastnameTxt.Text = staffDG.SelectedRows[0].Cells["lname"].Value.ToString();
                genderCmb.Text = staffDG.SelectedRows[0].Cells["gender"].Value.ToString();
                jdate.Value = DateTime.Parse(staffDG.SelectedRows[0].Cells["jodate"].Value.ToString());
                bdate.Value = DateTime.Parse(staffDG.SelectedRows[0].Cells["bidate"].Value.ToString());
                cityTxt.Text = staffDG.SelectedRows[0].Cells["city"].Value.ToString();
                mobileTxt.Text = staffDG.SelectedRows[0].Cells["mobile"].Value.ToString();
                
                
                
            }
            catch
            { 
            }
        
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                C.ExecuteSqlQuery("Delete from NstaffTbl where id='" + idtxt.Text + "'");


                C.fillgriddata(staffDG, "select * from NstaffTbl");

                MessageBox.Show("Data Deleted Successefully......!");


            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            C.ExecuteSqlQuery("Update NstaffTbl SET fname='" + firstnameTxt.Text + "',lname='" + lastnameTxt.Text + "',gender='" + genderCmb.Text + "',jodate='" + jdate.Value.ToString("MM/dd/yyyy") + "',bidate='" + bdate.Value.ToString("MM/dd/yyyy") + "',city='" + cityTxt.Text + "',mobile='" + mobileTxt.Text + "'where id='" + idtxt.Text + "'");
            C.fillgriddata(staffDG, "select * from NstaffTbl");
            MessageBox.Show("update successfully");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staffDG_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisplayGrid();
        }

    }
}

