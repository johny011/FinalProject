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
    public partial class Update_staff : Form
    {
        public Update_staff()
        {
            InitializeComponent();
            
        }
        
        
        private void btn_add_Click(object sender, EventArgs e)
        {
                DataGridViewRow gr = dataGridView1.CurrentRow;

                DB.Insert_Update_Delete("update TheStaff set Sname='" + gr.Cells[1].Value.ToString() + "', Fathername ='" + gr.Cells[2].Value.ToString() + "', mothername ='" + gr.Cells[3].Value.ToString() + "', TheIdNumber ='" + gr.Cells[4].Value.ToString() +
                               "', typeid =" + int.Parse(gr.Cells[5].Value.ToString()) + ",  deptid=" + int.Parse(gr.Cells[6].Value.ToString()) + "where id=" +
                               int.Parse(gr.Cells[0].Value.ToString()) + ";");
            MessageBox.Show("تم التعديل");
            Update_staff_Load(sender, e);


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
              DB.Insert_Update_Delete("delete from TheStaff where id="+(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()))+";");
            MessageBox.Show("تم الحذف");
            Update_staff_Load(sender, e);

        }

        private void Update_staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet10.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet10.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet9.Typee' table. You can move, or remove it, as needed.
            this.typeeTableAdapter.Fill(this.hospitallDataSet9.Typee);
            // TODO: This line of code loads data into the 'hospitallDataSet8.TheStaff' table. You can move, or remove it, as needed.
            this.theStaffTableAdapter.Fill(this.hospitallDataSet8.TheStaff);



        }
    }
}
