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
    public partial class Add_pation : Form
    {
        public Add_pation()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DB.DataTable("select * from patient where paname=@paname and fathername=@fathername and mothername=@mothername",
                new SqlParameter("@paname", txt_name.Text),
                new SqlParameter("@fathername",txt_father_name.Text),
                new SqlParameter("@mothername",txt_mother_name.Text));
            if (dt.Rows.Count==0)
             DB.Insert_Update_Delete("insert into patient (paname,fathername,mothername,birthday,TheIdNumber,PlaceOfResidence) values(@paname," +
                 "@fathername,@mothername,@birthday,@TheIdNumber,@PlaceOfResidence)",
                 new SqlParameter("@paname",txt_name.Text),
                 new SqlParameter("@fathername",txt_father_name.Text),
                 new SqlParameter("@mothername",txt_mother_name.Text),
                 new SqlParameter("@birthday", Convert.ToDateTime(dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString()).ToShortDateString()),
                 new SqlParameter("@TheIdNumber", txt_NO_number.Text),
                 new SqlParameter("@PlaceOfResidence", txt_place.Text)
                 );
            else
            {
                MessageBox.Show("تمت اضافة هذا المريض مسبقاً");
            }
        }
    }
}
