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
    public partial class Required_analyzes : Form
    {
        public Required_analyzes()
        {
            InitializeComponent();
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.DataTable("select paname,R.Admissionid,Analysisname from patient Pt,RequiredAnalysis R,Analyzes A,patientAdmission PA  where R.Admissionid=@Admissionid and R.Analysisnumber=A.Analysisnumber and PA.panumber=Pt.panumber " +
                "and R.Admissionid=PA.Admissionid",
                new SqlParameter("@Admissionid", int.Parse(txt_Admissionid.Text))); 
        }

        private void txt_Admissionid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }
    }
}
