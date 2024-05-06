using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FITNESS_CLUB
{
    class CFile
    {
        public SqlConnection Con;

        public CFile()
        {
            //connection string for database
            Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Fitness Club\FITNESS_CLUB\FITNESS_CLUB\FitnessClube.mdf;Integrated Security=True;User Instance=True");
            Con.Open();
        }


        //GetTableData -save button 
        public DataTable GettableData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            

        }

        public void ExecuteSqlQuery(string sql)
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = Con;
                 cmd.CommandText = sql;
                 cmd.ExecuteNonQuery();

         
             
             }
        public void fillcombo(ComboBox cb, string sql, string dismemb, string val)
        {
            DataTable dt = GettableData(sql);
            cb.ValueMember = val;
            cb.DisplayMember = dismemb;
            cb.DataSource = dt;

        }
        public void fillgriddata(DataGridView dv, string sql)
        {

            DataTable dt = GettableData(sql);
            dv.DataSource = dt;
        }


        //auto id  
        public int GetAutoId(string sql)
        {

            int i = 1;
            try
            {
                DataTable dt = GettableData(sql);
                if (dt.Rows.Count >= 1)
                {
                    i = (int.Parse(dt.Rows[0][0].ToString()) + 1);
                }
                else
                {
                    i = 1;
                }
            }
            catch
            {
                i = 1;
            }
            return i;
        }





    }
}
