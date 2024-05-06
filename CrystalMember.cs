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
    public partial class CrystalMember : Form
    {
        CFile CF = new CFile();
        public CrystalMember()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
              creport1("select * from NmemberTbl", CF.Con);
        }
        public void creport1(string sql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            DSetMember ds = new DSetMember();
            da.Fill(ds, "NmemberTbl");
            CrystalReportmember cr = new CrystalReportmember();
            cr.SetDataSource(ds);
            crystalReportViewer3.ReportSource = cr;

        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
    }
}
