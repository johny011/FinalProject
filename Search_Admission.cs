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
    public partial class Search_Admission : Form
    {
        int deptid;
        public Search_Admission(int dept)
        {
            InitializeComponent();
            deptid=deptid;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.DataTable("select * from patientAdmission where Admissionid =" + int.Parse(txt_id_admission.Text) + " and deptid="+deptid+"");
        }
    }
}
