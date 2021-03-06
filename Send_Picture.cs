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
    public partial class Send_Picture : Form
    {
        public Send_Picture()
        {
            InitializeComponent();
        }

        private void btn_sendpicture_Click(object sender, EventArgs e)
        {
            try
            {
                int Requiredpicturesid = int.Parse(DB.SelectToGetOneValue("select Requiredpicturesid from Requiredpictures where Admissionid=@Admissionid", new SqlParameter("@Admissionid", int.Parse(txt_Admissionid.Text))));

                SqlConnection con = new SqlConnection(DB.con);
                con.Open();
                SqlCommand command = new SqlCommand("insert into celendarRP (Requiredpicturesid,AcalendarP) values( @Requiredpicturesid , @img )", con);
                command.Parameters.AddWithValue("@Requiredpicturesid", Requiredpicturesid);
                command.Parameters.AddWithValue("@img", DB.convertToByte(pictureBox1.Image));
                command.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_ٍSelectpicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files(*.jpg,*.bmp,*.jpeg,*.png,*.gif)|*.jpg;*.bmp;*.jpef;*.png;*.gif ";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
