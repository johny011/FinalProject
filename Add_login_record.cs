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
    public partial class Add_login_record : Form
    {
        string dept;
        int deptid;
        public Add_login_record(string x)
        {
            dept = x;
            InitializeComponent();
            deptid = int.Parse(DB.SelectToGetOneValue("select deptid from dept where deptname='" + dept + "'"));
            combox_room=DB.FillCombo("select roomid from room where deptid ="+deptid+ " and roomid <> (select roomid from patientAdmission where checkoutDate=null)", combox_room);
            combox_doctor = DB.FillCombo("select Sname from TheStaff where typeid=1 and deptid ="+deptid, combox_doctor);
        }

        private void combox_dept_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int panumber = int.Parse(DB.SelectToGetOneValue("select id from TheStaff where Sname='" + combox_doctor.Text + "'"));
            DB.Insert_Update_Delete("" +
                "insert into patientAdmission (DateOfEntry,Notes,panumber,roomid,deptid,SIdd,DownPayment)values(" +
                "convert(date,'" + dateTimePicker1.Value.Day.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Year.ToString() + "',105),'" + txt_Notes.Text + "'," + int.Parse(txt_numberpatient.Text) + "," + int.Parse(combox_room.Text) + ","+deptid+","+panumber+","+int.Parse(txt_payment.Text)+")");
        }

        private void Add_login_record_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'hospitallDataSet.Room' table. You can move, or remove it, as needed.


        }
    }
}
