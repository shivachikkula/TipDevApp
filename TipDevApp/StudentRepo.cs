using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TipDevApp
{
    public class StudentRepo
    {
        public DataTable GetStudentData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            SqlDataAdapter sqda = new SqlDataAdapter();
            using (SqlConnection sqlcon = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DHWDBConnection"].ConnectionString))
            {
                sqda.SelectCommand = new SqlCommand("SELECT * FROM dbo.Student",sqlcon);
                sqda.Fill(ds);
            }
            return ds.Tables[0];
        }

    }
}