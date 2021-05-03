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
    public partial class Update_account : Form
    {
        public Update_account()
        {
            InitializeComponent();
            
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow gr in dataGridView1.Rows)
                DB.Insert_Update_Delete("Update users set username='"+gr.Cells[2].Value.ToString()+"' , passeword='"+gr.Cells[1].Value.ToString()+"', form='"+gr.Cells[3].Value.ToString()+"' where userid="+int.Parse(gr.Cells[0].Value.ToString())+"");
                

        }

        private void Update_account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet21.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter1.Fill(this.hospitallDataSet21.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet3.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet3.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet2.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hospitallDataSet2.users);

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("delete from users where userid=" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "");
        }
    }
}
