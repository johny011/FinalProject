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
    public partial class Update_period : Form
    {
        public Update_period()
        {
            InitializeComponent();
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        { 
                DataGridViewRow gr = dataGridView1.CurrentRow;
                DB.Insert_Update_Delete("update TimePeriods set ThePeriod='" + gr.Cells[1].Value.ToString() + "" +
                    "where id=" + int.Parse(gr.Cells[0].Value.ToString()) );
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("delete from TimePeriods where id=" +int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString())+"");
        }

        private void Update_period_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet5.TimePeriods' table. You can move, or remove it, as needed.
            this.timePeriodsTableAdapter.Fill(this.hospitallDataSet5.TimePeriods);

        }
    }
}
