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
    public partial class Add_pation : Form
    {
        public Add_pation()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DB.DataTable("select * from patient where paname='" + txt_name.Text + "' and fathername='" + txt_father_name.Text + "' and mothername='" + txt_mother_name.Text + "'");
            if(dt.Rows.Count==0)
             DB.Insert_Update_Delete("insert into patient (paname,fathername,mothername,birthday,TheIdNumber,PlaceOfResidence) values('"
                 +txt_name.Text+"','"+txt_father_name.Text+"','"+txt_mother_name.Text+"',convert(date,'"+dateTimePicker1.Value.Day.ToString()+"-"+dateTimePicker1.Value.Month.ToString()+"-"+dateTimePicker1.Value.Year.ToString()+"',105),'"+txt_NO_number.Text+"','" +
                 txt_place.Text+"')");
            else
            {
                MessageBox.Show("تمت اضافة هذا المريض مسبقاً");
            }
        }
    }
}
