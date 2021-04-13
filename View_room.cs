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
    public partial class View_room : Form
    {
        public View_room()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.DataTable("select * from Room");
            dataGridView1.Columns[0].HeaderText = "رقم الغرفة";
            dataGridView1.Columns[1].HeaderText = "نوع الغرفة";
            dataGridView1.Columns[2].HeaderText = "رقم القسم";
        }
    }
}
