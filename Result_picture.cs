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
using System.IO;

namespace Final_project
{
    public partial class Result_picture : Form
    {
        int deptid;
        public Result_picture(string x)
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
                    int Requiredpicturesid = int.Parse(DB.SelectToGetOneValue("select Requiredpicturesid from Requiredpictures where Admissionid=@Admissionid",new SqlParameter("@", int.Parse(txt_Admissionid.Text))));
                    dataGridView1.DataSource = DB.DataTable("select * from celendarRP where Requiredpicturesid=@Requiredpicturesid",new SqlParameter("@Requiredpicturesid", Requiredpicturesid));
                }
                else
                {
                    MessageBox.Show("تحقق من رقم دخولية المريض");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void Result_picture_Load(object sender, EventArgs e)
        {
           

        }
        Image convert(byte[] img)
        {
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if(dt!=null)
            {
                try
                {
                    DataRow row = dt.Rows[e.RowIndex];
                    pictureBox1.Image = convert((byte[])row["AcalendarP"]);
                }
                catch(Exception masseage)
                {
                    MessageBox.Show(masseage.Message);
                }
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() {Filter= "Image files(*.jpg,*.bmp,*.jpeg,*.png,*.gif)|*.jpg;*.bmp;*.jpef;*.png;*.gif " })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image.Save(sfd.FileName);
                }
            }
            catch
            {
                MessageBox.Show("اضغط على الصورة من الجدول ");
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
