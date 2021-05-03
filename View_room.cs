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
            
        }
        public View_room(string dept)
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.DataTable("select * from Room where deptid=(select deptid from dept where deptname='"+dept+"')");

        }
    }
}
