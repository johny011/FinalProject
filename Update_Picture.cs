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
    public partial class Update_Picture : Form
    {
        public Update_Picture()
        {
            InitializeComponent();
        }

        private void Update_Picture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet39.pictures' table. You can move, or remove it, as needed.
            this.picturesTableAdapter.Fill(this.hospitallDataSet39.pictures);

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow gr = dataGridView1.CurrentRow;
           
                DB.Insert_Update_Delete("update pictures set picturesname='" + gr.Cells[1].Value.ToString() + "',price=" + int.Parse(gr.Cells[2].Value.ToString()) + " ,processing ='" + gr.Cells[3].Value.ToString() + "' where picturesid=" + int.Parse(gr.Cells[0].Value.ToString()) + "");
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow gr = dataGridView1.CurrentRow;
            DB.Insert_Update_Delete("delete from pictures where picturesid=" + int.Parse(gr.Cells[0].Value.ToString()) + "");
        }
    }
}
