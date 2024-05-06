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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newmember obj = new Newmember();
            obj.Show();
            this.Hide();

        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newstaff obj = new Newstaff();
            obj.Show();
            this.Hide();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment obj = new Equipment();
            obj.Show();
            this.Hide();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void equipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cryastalequipment obj = new Cryastalequipment();
            obj.Show();
            this.Hide();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalBilling obj = new CrystalBilling();
            obj.Show();
            this.Hide();

        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalMember obj = new CrystalMember();
            obj.Show();
            this.Hide();

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrystalStaff obj = new CrystalStaff();
            obj.Show();
            this.Hide();
        }
    }
}
