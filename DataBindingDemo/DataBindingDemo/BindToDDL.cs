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
    public partial class BindToDDL : Form
    {
        public BindToDDL()
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

            comboBox1.DataSource = employees;
            comboBox1.ValueMember = "EmpName";
        }
    }
}
