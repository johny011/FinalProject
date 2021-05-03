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
    public partial class View_staff : Form
    {
        public View_staff()
        {
            InitializeComponent();
           
        }

        private void View_staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet23.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet23.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet22.TheStaff' table. You can move, or remove it, as needed.
            this.theStaffTableAdapter.Fill(this.hospitallDataSet22.TheStaff);

        }
    }
}
