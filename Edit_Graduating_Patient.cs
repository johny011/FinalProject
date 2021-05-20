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
                 DB.Insert_Update_Delete("update patientAdmission set DateOfEntry=convert(date,'" + dateIn.Value.Day.ToString() + "-" + dateIn.Value.Month.ToString() + "-" + dateIn.Value.Year.ToString() + "',105),panumber=" +
                     int.Parse(txt_numberpatient.Text) + " ,roomid=" + int.Parse(combox_room.SelectedItem.ToString()) + ",SIdd=" + SIdd + " ,DownPayment=" + int.Parse(txt_payment.Text) + " where panumber="+int.Parse(txt_numberpatient.Text)+"");
             }
             else if(GraduatingRadio.Checked)
             {

                 if (validate(int.Parse(txt_numberpatient.Text)))
                     DB.Insert_Update_Delete("update patientAdmission set checkoutDate=convert(date,'" + dateOut.Value.Day.ToString() + "-"
                         + dateOut.Value.Month.ToString() + "-" + dateOut.Value.Year.ToString() + "',105) where Admissionid=" + int.Parse(txt_numberpatient.Text) + "");
                 else
                 {
                     MessageBox.Show("error");
                 }
             }
        }

        private void btn_graduating_Click(object sender, EventArgs e)
        {
            if(validate(int.Parse(txt_numberpatient.Text)))
            DB.Insert_Update_Delete("update patientAdmission set checkoutDate=convert(date,'" + dateOut.Value.Day.ToString() + "-"
                + dateOut.Value.Month.ToString() + "-" + dateOut.Value.Year.ToString() + "',105) where Admissionid="+int.Parse(txt_numberpatient.Text)+"");
            else
            {
                MessageBox.Show("error");
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
