﻿using System;
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
    public partial class Update_room : Form
    {
        public Update_room()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             for(int i=0;i<dataGridView1.RowCount;i++)
             {
                 DataGridViewRow gr = dataGridView1.Rows[i];
                 DB.Insert_Update_Delete("update room set roomtype='" + gr.Cells[1].Value.ToString() + "',deptid=" + int.Parse(gr.Cells[2].Value.ToString()) + " where roomid="+int.Parse(gr.Cells[0].Value.ToString())+"");
             }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("delete from room where id=" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "");
        }

        private void Update_room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet7.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet7.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet6.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hospitallDataSet6.Room);

        }
    }
}
