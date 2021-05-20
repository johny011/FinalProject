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
    public partial class Update_working_period : Form
    {
        public Update_working_period()
        {
            InitializeComponent();
        }

        private void Update_working_period_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet11.WorkPeriods' table. You can move, or remove it, as needed.
            this.workPeriodsTableAdapter.Fill(this.hospitallDataSet11.WorkPeriods);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataGridViewRow t = dataGridView1.CurrentRow;
            DB.Insert_Update_Delete("Update WorkPeriods set id=" + Convert.ToInt32(t.Cells[1].Value.ToString()) + ",Situationid=" + Convert.ToInt32(t.Cells[2].Value.ToString()) + ",DayAndDate='" + Convert.ToDateTime(t.Cells[3].Value.ToString()).ToShortDateString() + "' where periodnumber=" + Convert.ToInt32(t.Cells[0].Value.ToString()) + " ");
            MessageBox.Show("تم التعديل");
            Update_working_period_Load(sender, e);


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("delete from WorkPeriods where  periodnumber=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + " ");
            MessageBox.Show("تم الحذف");
            Update_working_period_Load(sender, e);
        }
    }
}
