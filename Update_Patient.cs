using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            try
            {
                DB.Insert_Update_Delete("update patient set paname=@paname ,fathername=@fathername ,mothername=@mothername ,birthday=@birthday ,TheIdNumber=@TheIdNumber ,placeOfResidence=@placeOfResidence where panumber=@panumber",
                    new SqlParameter("@paname", txt_name.Text),
                    new SqlParameter("@fathername", txt_father_name.Text),
                    new SqlParameter("@mothername", txt_mother_name.Text),
                    new SqlParameter("@birthday", Convert.ToDateTime(dateTimePicker1.Value).ToShortDateString()),
                    new SqlParameter("@TheIdNumber", txt_NO_number.Text),
                    new SqlParameter("@placeOfResidence", txt_place.Text),
                    new SqlParameter("@panumber", int.Parse(txt_panumber.Text))); ;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void txt_panumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }

        private void txt_NO_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }
    }
}
