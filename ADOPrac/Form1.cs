using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeProgramms.ADOPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.empInfo' table. You can move, or remove it, as needed.
            this.empInfoTableAdapter.Fill(this.employeeDataSet.empInfo);

        }

        string constr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                
                string command = @"select * from empInfo";
                DataSet dataset = new DataSet();
                SqlDataAdapter adr = new SqlDataAdapter();
                adr.SelectCommand = new SqlCommand(command, con);
                adr.Fill(dataset);
                dataGridView1.DataSource = dataset;
            }
        }
    }
}
