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
    public partial class Result_Analyzes : Form
    {
        public Result_Analyzes()
        {
            InitializeComponent();
        }

        private void btn_find_result_Click(object sender, EventArgs e)
        {
            int RequiredAnalysisid = int.Parse(DB.SelectToGetOneValue("select RequiredAnalysisid from RequiredAnalysis where Admissionid=" + int.Parse(txt_Admissionid.Text) + ""));
            dataGridView1.DataSource = DB.DataTable("select * from celendarRA where RequiredAnalysisid=" + RequiredAnalysisid + "");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Image|*.jpg;*.gif;*.bmp;" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image.Save(sfd.FileName);
            } 
        }
    }
}
