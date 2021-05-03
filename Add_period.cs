using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace Final_project
{
    public partial class Add_period : Form
    {
        public Add_period()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            for(int i=0 ; i < dataGridView1.RowCount-1;i++)
            {
                DataGridViewRow gr = dataGridView1.Rows[i];       
                        DB.Insert_Update_Delete("insert into TimePeriods (ThePeriod) values ('" + gr.Cells[1].Value.ToString() + "');");
            }
        }
    }
}
