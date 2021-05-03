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
    public partial class View_working_period : Form
    {
        public View_working_period()
        {
            InitializeComponent();
            
        }

        private void View_working_period_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet24.WorkPeriods' table. You can move, or remove it, as needed.
            this.workPeriodsTableAdapter.Fill(this.hospitallDataSet24.WorkPeriods);

        }
    }
}
