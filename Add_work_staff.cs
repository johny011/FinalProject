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
    public partial class Add_work_staff : Form
    {
        
        public Add_work_staff()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

             DB.Insert_Update_Delete("insert into TheStaff (Sname,Fathername,mothername,TheIdNumber,typeid,deptid)values('"+txt_name.Text+"','" +
                 txt_father_name.Text+"','"+txt_mother_name.Text+"','"+txt_NO_number.Text+"',"+int.Parse(combox_typeid.SelectedValue.ToString())+","+int.Parse(combox_deptid.SelectedValue.ToString())+")");
            
            
        }

        private void combox_deptid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_work_staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet18.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet18.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet17.Typee' table. You can move, or remove it, as needed.
            this.typeeTableAdapter.Fill(this.hospitallDataSet17.Typee);
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
