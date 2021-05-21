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
    public partial class Search_Patient : Form
    {
        string dept;
        public Search_Patient()
        {
            InitializeComponent();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.DataTable("select * from patient where paname='" + txt_name.Text + "'");
        }

        private void txt_name_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
