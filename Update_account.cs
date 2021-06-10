﻿using System;
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
    public partial class Update_account : Form
    {
        public Update_account()
        {
            InitializeComponent();
            
            
        }

        

        private void Update_account_Load(object sender, EventArgs e)
        {
            Refresh();
           

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("delete from users where userid=@userid",
                new SqlParameter("@userid", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())));
            MessageBox.Show("تم الحذف");
            Refresh();
            

        }
        private void Refresh()
        {
            this.usersTableAdapter1.Fill(this.hospitallDataSet49.users);
            // TODO: This line of code loads data into the 'hospitallDataSet46.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hospitallDataSet46.users);
            // TODO: This line of code loads data into the 'hospitallDataSet21.Dept' table. You can move, or remove it, as needed.
        }
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow gr = dataGridView1.CurrentRow;
            int countuser = DB.DataTable("select * from users where username=@username and userid <> @userid",
                new SqlParameter("@username", gr.Cells[2].Value.ToString()),
                new SqlParameter("@userid", int.Parse(gr.Cells[0].Value.ToString()))).Rows.Count;
            if (countuser == 0)
            {
                DB.Insert_Update_Delete("Update users set username=@username   , passeword=@passeword, form=@form  where userid=@userid",
                    new SqlParameter("@username", gr.Cells[2].Value.ToString()),
                    new SqlParameter("@passeword", gr.Cells[1].Value.ToString()),
                    new SqlParameter("@form", gr.Cells[3].Value.ToString()),
                    new SqlParameter("@userid", int.Parse(gr.Cells[0].Value.ToString())));
                MessageBox.Show("تم التعديل");

            }
            else
            {
                MessageBox.Show("اسم المستخدم هذا موجود");
            }
            Refresh();

        }
    }
}
