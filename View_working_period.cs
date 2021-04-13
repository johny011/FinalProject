using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class View_working_period : Form
    {
        public View_working_period()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.DataTable("select * from WorkPeriods");
            dataGridView1.DataSource = DB.DataTable("select * from TheStaff");
            dataGridView1.Columns[0].HeaderText = "رقم فترة العمل";
            dataGridView1.Columns[1].HeaderText = "";
            dataGridView1.Columns[2].HeaderText = "";
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
        }
    }
}
