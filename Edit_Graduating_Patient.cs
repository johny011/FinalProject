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
    public partial class Edit_Graduating_Patient : Form
    {
        string dept = "";
        int deptid;
        public Edit_Graduating_Patient(string x)
        {
            InitializeComponent();
            dept = x;
            deptid = int.Parse(DB.SelectToGetOneValue("select deptid from dept where deptname='" + dept + "'"));
            combox_room = DB.FillCombo("select roomid from room where deptid =" + deptid + " and roomid not in (select roomid from patientAdmission where checkoutDate IS Null and deptid=" + deptid + ")", combox_room);
            combox_doctor = DB.FillCombo("select Sname from TheStaff where typeid=1 and deptid =" + deptid, combox_doctor);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             if (editRadio.Checked)
             {
                int SIdd =int.Parse( DB.SelectToGetOneValue("select id from TheStaff where Sname='" + combox_doctor.SelectedItem.ToString() + "'"));
                 DB.Insert_Update_Delete("update patientAdmission set DateOfEntry=@DateOfEntry,panumber=@panumber ,roomid=@roomid ,SIdd=@SIdd ,DownPayment=@DownPayment where panumber=@panumber",
                     new SqlParameter("@DateOfEntry", Convert.ToDateTime(dateIn.Value).ToShortDateString()),
                     new SqlParameter("@panumber", int.Parse(txt_numberpatient.Text)),
                     new SqlParameter("@roomid", int.Parse(combox_room.SelectedItem.ToString())),
                     new SqlParameter("@SIdd", SIdd),
                     new SqlParameter("@DownPayment",int.Parse(txt_payment.Text)),
                     new SqlParameter("@panumber", int.Parse(txt_numberpatient.Text))
                     );
             }
             else if(GraduatingRadio.Checked)
             {

                 if (validate(int.Parse(txt_numberpatient.Text)))
                     DB.Insert_Update_Delete("update patientAdmission set checkoutDate=@checkoutDate where Admissionid=@Admissionid",
                         new SqlParameter("@checkoutDate", Convert.ToDateTime(dateIn.Value).ToShortDateString()),
                         new SqlParameter("@", int.Parse(txt_numberpatient.Text)));
                 else
                 {
                     MessageBox.Show("error");
                 }
             }
        }

        private bool validate(int admissionid)
        {
            int value=int.Parse(DB.SelectToGetOneValue("select deptid from patientAdmission where Admissionid=" + admissionid + ""));
            if (value == deptid)
                return true;
            else
                return false;
        }
        private void lockControl(bool x)
        {
            if (x)
            {
                txt_place.Enabled = false;
                txt_payment.Enabled = false;
                combox_doctor.Enabled = false;
                combox_room.Enabled = false;
                dateIn.Enabled = false;
            }
            else
            {
                txt_place.Enabled = true;
                txt_payment.Enabled = true;
                combox_doctor.Enabled = true;
                combox_room.Enabled = true;
                dateIn.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(editRadio.Checked)
            {
                lockControl(false);
            }
            else
            {
                lockControl(true);
            }
        }
    }
}
