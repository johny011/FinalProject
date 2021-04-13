using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_project
{
    public partial class Add_working_period : Form
    {
        List<string> Doctor = new List<string>();
        List<string> a = new List<string>();
        List<string> b = new List<string>();
        public Add_working_period()
        {
            InitializeComponent();
            Grid();
            DB.Fillcombo("select ThePeriod from TimePeriods", ref combox_period);
            
        }
        private void Grid()
        {
            Doctor = DB.FillList("select Sname from TheStaff where id=1", Doctor);
            a = DB.FillList("select Sname from TheStaff where id=2", a);
            b = DB.FillList("select Sname from TheStaff where id=3", b);
            for (int i = 0; i < Doctor.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Doctor[i];
            }
            for (int i = 0; i < a.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = a[i];
            }
            for (int i = 0; i < b.Count; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = b[i];
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void combox_period_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
