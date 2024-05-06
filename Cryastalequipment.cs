using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FITNESS_CLUB
{
    public partial class Cryastalequipment : Form
    {
        CFile CF = new CFile();
        public Cryastalequipment()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
             creport1("select * from EquipmentTbl", CF.Con);
        }
        public void creport1(string sql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DSetEquipment ds = new DSetEquipment();
            da.Fill(ds, "EquipmentTbl");
            CrystalReportequipment cr = new CrystalReportequipment();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
       
    }
}
