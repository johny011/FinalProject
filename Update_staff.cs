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
            try
            {
                DataGridViewRow gr = dataGridView1.CurrentRow;

                DB.Insert_Update_Delete("update TheStaff set Sname=@Sname, Fathername =@Fathername , mothername =@mothername , TheIdNumber =@TheIdNumber, typeid =@typeid ,  deptid=@deptid where id=@id",
                               new SqlParameter("@Sname", gr.Cells[1].Value.ToString()),
                               new SqlParameter("@Fathername", gr.Cells[2].Value.ToString()),
                               new SqlParameter("@mothername", gr.Cells[3].Value.ToString()),
                               new SqlParameter("@TheIdNumber", gr.Cells[4].Value.ToString()),
                               new SqlParameter("@typeid", int.Parse(gr.Cells[5].Value.ToString())),
                               new SqlParameter("@deptid", int.Parse(gr.Cells[6].Value.ToString())),
                               new SqlParameter("@id", int.Parse(gr.Cells[0].Value.ToString())));
                MessageBox.Show("تم التعديل");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Update_staff_Load(sender, e);


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
              DB.Insert_Update_Delete("delete from TheStaff where id=@id",
                  new SqlParameter("@id", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())));
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
