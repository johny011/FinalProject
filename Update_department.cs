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
    public partial class Update_department : Form
    {
        public Update_department()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount ; i++)
            {
                DataGridViewRow gr = dataGridView1.Rows[i];
                DB.Insert_Update_Delete("update dept set deptname='" + gr.Cells[1].Value.ToString() + "where id =" + int.Parse(
                    gr.Cells[0].Value.ToString()) + "");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("delete from dept where id =" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "");
        }

        private void Update_department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet4.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet4.Dept);

        }
    }
}
