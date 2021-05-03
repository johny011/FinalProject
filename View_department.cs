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
    public partial class View_department : Form
    {
        public View_department()
        {
            InitializeComponent();
            
        }

        private void View_department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet33.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet33.Dept);

        }
    }
}
