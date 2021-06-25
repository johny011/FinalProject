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
    public partial class Send_Analyzes : Form
    {
        public Send_Analyzes()
        {
            InitializeComponent();
        }

        private void btn_sendpicture_Click(object sender, EventArgs e)
        {
            try
            {
                int RequiredAnalyzes = int.Parse(DB.SelectToGetOneValue("select RequiredAnalysisid from RequiredAnalysis where Admissionid=@Admissionid",
                    new SqlParameter("@Admissionid", int.Parse(txt_Admissionid.Text))));

                SqlConnection con = new SqlConnection(DB.con);
                con.Open();
                SqlCommand command = new SqlCommand("insert into celendarRA (RequiredAnalysisid,Acalendar) values( @RequiredAnalysisid , @img )", con);
                command.Parameters.AddWithValue("@RequiredAnalysisid", RequiredAnalyzes);
                command.Parameters.AddWithValue("@img", DB.convertToByte(pictureBox1.Image));
                command.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception exp)
            {
               
                MessageBox.Show(exp.Message);
            }
        }

        private void btn_ٍSelectpicture_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opf = new OpenFileDialog() { Filter = "Image files(*.jpg,*.bmp,*.jpeg,*.png,*.gif)|*.jpg;*.bmp;*.jpef;*.png;*.gif " })
                {
                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = Image.FromFile(opf.FileName);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
