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
    public partial class Newmember : Form
    {
        CFile C = new CFile();
        public Newmember()
        {
            InitializeComponent();
        }

        void GetMaxId()
        {
            idtxt.Text = C.GetAutoId("Select MAX(id)From NmemberTbl").ToString();

        }

        private void Newmember_Load(object sender, EventArgs e)
        {
            C.fillgriddata(memberDG, "Select * from NmemberTbl");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idtxt.Text != "" && idtxt.Text != "" && firstnameTxt.Text!= "" && lastnameTxt.Text != "" && genderCmb.Text!= ""&& bdate.Text !="" && mobileTxt.Text !=""&& jdate.Text !="" && gymtimeCmb.Text !="" && addressTxt.Text !=""&& membershiptimeCmb.Text != "" )
            {

                C.ExecuteSqlQuery("insert into NmemberTbl(id,fname,lname,gender,dob,mobile,jadate,time,address,mtime)values('" + idtxt.Text + "','" + firstnameTxt.Text + "','" + lastnameTxt.Text + "','" + genderCmb.Text + "','" + bdate.Value.ToString("MM/dd/yyyy") + "','" + mobileTxt.Text + "','" + jdate.Value.ToString("MM/dd/yyyy") + "','"+gymtimeCmb.Text+"','"+addressTxt.Text+"','"+membershiptimeCmb.Text+"')");
                C.fillgriddata(memberDG, "Select * from NmemberTbl");

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
                idtxt.Text = memberDG.SelectedRows[0].Cells["id"].Value.ToString();
                firstnameTxt.Text = memberDG.SelectedRows[0].Cells["fname"].Value.ToString();
                lastnameTxt.Text = memberDG.SelectedRows[0].Cells["lname"].Value.ToString();
               genderCmb.Text = memberDG.SelectedRows[0].Cells["gender"].Value.ToString();
               bdate.Value = DateTime.Parse(memberDG.SelectedRows[0].Cells["dob"].Value.ToString());
                mobileTxt.Text = memberDG.SelectedRows[0].Cells["mobile"].Value.ToString();
                jdate.Value = DateTime.Parse(memberDG.SelectedRows[0].Cells["jadate"].Value.ToString());
                gymtimeCmb.Text = memberDG.SelectedRows[0].Cells["time"].Value.ToString();
               addressTxt.Text = memberDG.SelectedRows[0].Cells["address"].Value.ToString();
                memberDG.Text = memberDG.SelectedRows[0].Cells["mtime"].Value.ToString();
            }
            catch
            { 
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void resetBtn_Click(object sender, EventArgs e)
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
            gymtimeCmb.SelectedIndex = -1;
            addressTxt.Clear();
            membershiptimeCmb.SelectedIndex = -1;

          

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                C.ExecuteSqlQuery("Delete from NmemberTbl where id='" + idtxt.Text + "'");


                C.fillgriddata(memberDG, "select * from NmemberTbl");

                MessageBox.Show("Data Deleted Successefully......!");


            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            C.ExecuteSqlQuery("Update NmemberTbl SET fname='" + firstnameTxt.Text + "',lname='" + lastnameTxt.Text + "',gender='" + genderCmb.Text + "',dob='" + bdate.Value.ToString("MM/dd/yyyy") + "',mobile='"+mobileTxt.Text+"',jadate='"+jdate.Value.ToString("MM/dd/yyyy") +"',time='"+gymtimeCmb.Text+"',address='"+addressTxt.Text+"',mtime='"+membershiptimeCmb.Text+"'where id='" + idtxt.Text + "'");
            C.fillgriddata(memberDG, "select * from NmemberTbl");
            MessageBox.Show("update successfully");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void memberDG_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisplayGrid();
        }
    }
}
