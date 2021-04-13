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
    public partial class View_department : Form
    {
        public View_department()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.DataTable("select * from dept");
            dataGridView1.Columns[0].HeaderText = "رقم القسم";
            dataGridView1.Columns[1].HeaderText = "اسم القسم";
        }
    }
}
