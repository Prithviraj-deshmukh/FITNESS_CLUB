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
    public partial class CrystalStaff : Form
    {
        CFile CF = new CFile();
        public CrystalStaff()
        {
            InitializeComponent();
        }

        private void crystalReportViewer4_Load(object sender, EventArgs e)
        {
              creport1("select * from NstaffTbl", CF.Con);
        }
        public void creport1(string sql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DSetStaff ds = new DSetStaff();
            da.Fill(ds, "NstaffTbl");
            CrystalReportStaff cr = new CrystalReportStaff();
            cr.SetDataSource(ds);
            crystalReportViewer4.ReportSource = cr;

        
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
    }
}
