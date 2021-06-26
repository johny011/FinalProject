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
    public partial class Result_Analyzes : Form
    {
        int deptid;
        public Result_Analyzes(string x)
        {
            InitializeComponent();
            deptid = int.Parse(DB.SelectToGetOneValue("select deptid from dept where deptname='" + x + "'"));
        }

        private void btn_find_result_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(DB.SelectToGetOneValue("select deptid from patientAdmission where Admissionid=@Admissionid",
                   new SqlParameter("@Admissionid", int.Parse(txt_Admissionid.Text))));
            
                if (value == deptid)
                {
                    int RequiredAnalysisid = int.Parse(DB.SelectToGetOneValue("select RequiredAnalysisid from RequiredAnalysis where Admissionid=@Admissionid",
                        new SqlParameter("@Admissionid", int.Parse(txt_Admissionid.Text))));
                    dataGridView1.DataSource = DB.DataTable("select * from celendarRA where RequiredAnalysisid=@RequiredAnalysisid", new SqlParameter("@RequiredAnalysisid", RequiredAnalysisid));
                }
                else
                {
                    MessageBox.Show("تحقق من رقم الدخولية");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Image files(*.jpg,*.bmp,*.jpeg,*.png,*.gif)|*.jpg;*.bmp;*.jpef;*.png;*.gif " })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image.Save(sfd.FileName);
            } 
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
