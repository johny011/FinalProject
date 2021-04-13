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
    public partial class View_staff : Form
    {
        public View_staff()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.DataTable("select * from TheStaff");
            dataGridView1.Columns[0].HeaderText = "رقم العامل";
            dataGridView1.Columns[1].HeaderText = "اسم العامل";
            dataGridView1.Columns[2].HeaderText = "اسم الاب";
            dataGridView1.Columns[3].HeaderText = "اسم الام";
            dataGridView1.Columns[4].HeaderText = "الرقم الوطني";
            dataGridView1.Columns[5].HeaderText = "رقم النوع";
            dataGridView1.Columns[6].HeaderText = "رقم القسم";
        }
    }
}
