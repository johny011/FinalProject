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
    public partial class Required_analyzes : Form
    {
        public Required_analyzes()
        {
            InitializeComponent();
        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.DataTable("select paname,R.Admissionid,Analysisname from patient Pt,RequiredAnalysis R,Analyzes A,patientAdmission PA  where R.Admissionid=" + int.Parse(txt_Admissionid.Text) + " and R.Analysisnumber=A.Analysisnumber and PA.panumber=Pt.panumber"); 
        }
    }
}
