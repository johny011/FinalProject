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

        }
    }
}
