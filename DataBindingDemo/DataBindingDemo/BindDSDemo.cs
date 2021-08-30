using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DataBindingDemo
{
    public partial class BindDSDemo : Form
    {
        #region Database Objects
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        #endregion
        public BindDSDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  How to bind dataset to gridview control
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select * from EmpMaster";
            sqlDataAdapter.SelectCommand = sqlCommand;
            if(ds.Tables.Contains("Emp"))
            {
                ds.Tables["Emp"].Clear();
            }
            sqlDataAdapter.Fill(ds, "Emp");
            dataGridView1.DataSource = ds.Tables["Emp"];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //  How to bind dataset to combobox
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select distinct(DeptName) from DeptMaster";
            sqlDataAdapter.SelectCommand = sqlCommand;
            if (ds.Tables.Contains("Dept"))
            {
                ds.Tables["Dept"].Clear();
            }
            sqlDataAdapter.Fill(ds, "Dept");
            comboBox1.DataSource = ds.Tables["Dept"];
            comboBox1.ValueMember = "DeptName";
        }
    }
}
