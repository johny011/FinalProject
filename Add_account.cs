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
using System.Data;


namespace Final_project
{
    public partial class Add_account : Form
    {
        
        public Add_account()
        {
            InitializeComponent();
            
        }
        
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            int count = DB.DataTable("select * from المستخدمين where username='" + txt_user_name.Text + "'").Rows.Count;
            if(count==0)
            {
                DB.Insert_Update_Delete("insert into المستخدمين (username,passeword,form)values ('" + txt_user_name.Text + "','" + txt_password.Text + "','" + combox_deptid.SelectedValue.ToString() + "')");
            }
            else
            {
                MessageBox.Show("قم بتغيير اسم المستخدم");
            }
            
            
        }

        private void Add_account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet20.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet20.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet19.Dept' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'hospitallDataSet14.Dept' table. You can move, or remove it, as needed.
            

        }

        
    }
}
