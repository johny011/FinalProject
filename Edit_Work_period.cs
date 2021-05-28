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
    public partial class Edit_Work_period : Form
    {
        int periodnumber;
        int id;
        public Edit_Work_period(int pn,int I)
        {
            InitializeComponent();
            id = I;
            periodnumber = pn;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("Update WorkPeriods set Situationid=@Situationid,DayAndDate=@DayAndDate where periodnumber=@periodnumber and id=@id",
                new SqlParameter("@Situationid", Convert.ToInt32(txt_Situationid.Text)),
                new SqlParameter("@DayAndDate", Convert.ToDateTime(dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString()).ToShortDateString()),
                new SqlParameter("@periodnumber",periodnumber),
                new SqlParameter("@id",id)
                );
            MessageBox.Show("تم التعديل");
            
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
