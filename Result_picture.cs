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
        public Result_picture()
        {
            InitializeComponent();
        }

        

        private void btn_find_result_Click(object sender, EventArgs e)
        {
            int Requiredpicturesid = int.Parse(DB.SelectToGetOneValue("select Requiredpicturesid from Requiredpictures where Admissionid=" + int.Parse(txt_Admissionid.Text) + ""));
            dataGridView1.DataSource = DB.DataTable("select * from celendarRP where Requiredpicturesid=" + Requiredpicturesid + "");
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
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox1.Image = convert((byte[])row["AcalendarP"]);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd=new SaveFileDialog() { Filter="Image|*.jpg;*.gif;*.bmp;"})
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                pictureBox1.Image.Save(sfd.FileName);
            }
        }
    }
}
