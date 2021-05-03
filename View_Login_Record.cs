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
    public partial class View_Login_Record : Form
    {
        string dept="";
        public View_Login_Record()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.DataTable("select * from patientAdmission");
        }
        public View_Login_Record(string x)
        {
            dept = x;
            InitializeComponent();
            dataGridView1.DataSource = DB.DataTable("select * from patientAdmission where deptid=(select deptid from dept where deptname='"+dept+"')");
        }

        private void View_Login_Record_Load(object sender, EventArgs e)
        {
           

        }
    }
}
