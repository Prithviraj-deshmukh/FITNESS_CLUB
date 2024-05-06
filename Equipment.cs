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
    public partial class Equipment : Form
    {
    

        CFile C=new CFile();
        public Equipment()
        {
            InitializeComponent();
        }

        void GetMaxId()
        {
            idtxt.Text = C.GetAutoId("Select MAX(id)From EquipmentTbl").ToString();

        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idtxt.Text!= "" && nametxt.Text != "" && descriptionTxtb.Text != "" && musetxt.Text != "" && costTxtb.Text != "" )
            {

                C.ExecuteSqlQuery("insert into EquipmentTbl(id,name,description,muse,cost)values('" + idtxt.Text + "','" + nametxt.Text + "','" + descriptionTxtb.Text + "','" + musetxt.Text + "','"+costTxtb.Text+"')");
                C.fillgriddata(equiDG, "Select * from EquipmentTbl");

                MessageBox.Show("data saved succeessfully");

              
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
                idtxt.Text = equiDG.SelectedRows[0].Cells["id"].Value.ToString();
                nametxt.Text = equiDG.SelectedRows[0].Cells["name"].Value.ToString();
                descriptionTxtb.Text = equiDG.SelectedRows[0].Cells["description"].Value.ToString();
                musetxt.Text = equiDG.SelectedRows[0].Cells["muse"].Value.ToString();
                costTxtb.Text = equiDG.SelectedRows[0].Cells["cost"].Value.ToString();

            }
            catch
            {



            }
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Do you want to delete record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                C.ExecuteSqlQuery("Delete from EquipmentTbl where id='" + idtxt.Text + "'");


                C.fillgriddata(equiDG, "select * from EquipmentTbl");
                
                MessageBox.Show("Data Deleted Successefully......!");


            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            C.ExecuteSqlQuery("Update EquipmentTbl SET name='" + nametxt.Text + "',description='" + descriptionTxtb.Text + "',muse='" + musetxt.Text + "',cost='" + costTxtb.Text + "'where id='" + idtxt.Text + "'");
            C.fillgriddata(equiDG, "select * from EquipmentTbl");
            MessageBox.Show("update successfully");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void equiDG_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisplayGrid();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            C.fillgriddata(equiDG, "Select * from EquipmentTbl");

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            nametxt.Focus();
            GetMaxId();
            clrdata();
            saveBtn.Enabled = true;
          
        }
        void clrdata()
        {
            
            nametxt.Clear();
            descriptionTxtb.Clear();
            musetxt.Clear();
            costTxtb.Clear();

        }
    }
}

