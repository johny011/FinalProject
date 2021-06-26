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
    public partial class Requierd_X_Ray : Form
    {
        public Requierd_X_Ray()
        {
            InitializeComponent();
        }

        private void Requierd_X_Ray_Load(object sender, EventArgs e)
        {
            

        } 

        

        private void btn_Request_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.DataTable("select paname,R.Admissionid,picturesname from patient Pt,Requiredpictures R,pictures P,patientAdmission PA  where R.Admissionid=@Admissionid and R.picturesid=P.picturesid and PA.panumber=Pt.panumber and R.Admissionid=PA.Admissionid",
                new SqlParameter("@Admissionid", int.Parse(txt_Admissionid.Text)));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
