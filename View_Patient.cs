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
    public partial class View_Patient : Form
    {
        string dept="";
        
        public View_Patient(string x)
        {
            InitializeComponent();
            dept = x;
            dataGridView1.DataSource = DB.DataTable("select * from patient where panumber in(select panumber from patientAdmission where deptid=(select deptid from dept where deptname='"+dept+"'))");

        }
        public View_Patient()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = DB.DataTable("select * from patient");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Patient_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dept == "")
                    dataGridView1.DataSource = DB.DataTable("select * from patient where paname='" + txt_name.Text + "'");
                else
                {
                    dataGridView1.DataSource = DB.DataTable("select p.* from patient p,patientAdmission pa where p.paname='" + txt_name.Text + "' and " +
                        "pa.panumber=p.panumber and pa.deptid =(select deptid from dept where deptname='" + dept + "')");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
    
}
