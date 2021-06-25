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
    public partial class Update_room : Form
    {
        public Update_room()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             
                 DataGridViewRow gr = dataGridView1.CurrentRow;
                 DB.Insert_Update_Delete("update room set roomtype=@roomtype ,deptid=@deptid  where roomid=@roomid ",
                     new SqlParameter("@roomtype", gr.Cells[1].Value.ToString()),
                     new SqlParameter("@deptid", int.Parse(gr.Cells[2].Value.ToString())),
                     new SqlParameter("@roomid", int.Parse(gr.Cells[0].Value.ToString())));
            MessageBox.Show("تم التعديل");
            Update_room_Load(sender, e);


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow gr = dataGridView1.CurrentRow;
            DB.Insert_Update_Delete("delete from room where roomid=@roomid" ,
                new SqlParameter("@roomid", int.Parse(gr.Cells[0].Value.ToString())));
            MessageBox.Show("تم الحذف");
            Update_room_Load(sender, e);
        }

        private void Update_room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet54.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet54.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet53.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hospitallDataSet53.Room);


        }
    }
}
