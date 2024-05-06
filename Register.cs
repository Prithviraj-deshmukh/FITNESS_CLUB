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
    public partial class Register : Form
    {
        CFile C = new CFile();
        public Register()
        {
            InitializeComponent();
        }


        void GetMaxId()
        {
            idtxt.Text = C.GetAutoId("Select MAX(id)From RegisterTbl").ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            fullnameTxt.Focus();
            GetMaxId();
            clrdata();
            saveBtn.Enabled = true;
        }
        void clrdata()
        {

            fullnameTxt.Clear();
            passwordTxt.Clear();
            genderCmb.SelectedIndex = -1;
            mobileTxt.Clear();
            addressTxt.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if ( idtxt.Text != "" && fullnameTxt.Text != "" && passwordTxt.Text != "" && genderCmb.Text != "" &&  mobileTxt.Text != "" && addressTxt.Text != "" )
            {

                C.ExecuteSqlQuery("insert into RegisterTbl(id,name,pass,gender,mobile,address,Rdate)values('" + idtxt.Text + "','" + fullnameTxt.Text + "','" + passwordTxt.Text + "','" + genderCmb.Text + "','" + mobileTxt.Text + "','" + addressTxt.Text + "','" + date.Value.ToString("MM/dd/yyyy") + "')");
                C.fillgriddata(registerdtgv, "Select * from RegisterTbl");

                MessageBox.Show("data saved succeessfully");



            }
            else
            {
                MessageBox.Show("First Fill All The Fields");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            C.fillgriddata(registerdtgv, "Select * from RegisterTbl");

        }
    }
}
