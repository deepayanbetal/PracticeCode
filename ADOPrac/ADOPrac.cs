using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PracticeProgramms.ADOPrac
{
    public class ADOPrac1
    {
        string constr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        string command = @"select * from empInfo";
        public void connectionDB()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adr = new SqlDataAdapter();
                adr.SelectCommand = new SqlCommand(command,con);
                adr.Fill(dataset);
            }
        }
       
      
        
        
    }
}
