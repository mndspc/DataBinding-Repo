using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee> 
            {
                new Employee {EmpCode=100,EmpName="Scott" },
                new Employee{EmpCode=101,EmpName="Tiger" },
                new Employee{EmpCode=102,EmpName="Smith" }
            };
            var data = employees;
            dataGridView1.DataSource = data;
        }
    }
}
