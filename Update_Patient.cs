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
    public partial class Update_Patient : Form
    {
        public Update_Patient()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("update patient set paname='" + txt_name.Text + "', fathername='" + txt_father_name.Text + "'," +
                "mothername='" + txt_mother_name.Text + "',birthday=convert(date,'" + dateTimePicker1.Value.Day.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Year.ToString() + "',105),TheIdNumber='" + txt_NO_number.Text + "',placeOfResidence='" + txt_place.Text + "' where panumber="+int.Parse(txt_panumber.Text));
        }
    }
}
