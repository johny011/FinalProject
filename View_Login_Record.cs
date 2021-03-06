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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(dept=="")
            dataGridView1.DataSource = DB.DataTable("select * from patientAdmission where Admissionid=@Admissionid ",
                new SqlParameter("@Admissionid", int.Parse(txt_id_admission.Text)));
            else
            {
                dataGridView1.DataSource = DB.DataTable("select * from patientAdmission where deptid=(select deptid from dept where deptname='" + dept + "') and Admissionid=@ Admissionid",
                    new SqlParameter("@Admissionid", int.Parse(txt_id_admission.Text)));
            }
        }

        private void txt_id_admission_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }
    }
}
