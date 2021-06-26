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
    public partial class Add_login_record : Form
    {
        string dept;
        int deptid;
        public Add_login_record(string x)
        {
            dept = x;
            InitializeComponent();
            deptid = int.Parse(DB.SelectToGetOneValue("select deptid from dept where deptname='" + dept + "'"));
            combox_room=DB.FillCombo("select roomid from room where deptid ="+deptid+ " and roomid not in (select roomid from patientAdmission where checkoutDate IS Null and deptid="+deptid+")", combox_room);
            combox_doctor = DB.FillCombo("select Sname from TheStaff where typeid=1 and deptid ="+deptid, combox_doctor);
            
        }

        private void combox_dept_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int SIdd = int.Parse(DB.SelectToGetOneValue("select id from TheStaff where Sname='" + combox_doctor.Text + "'"));
                DB.Insert_Update_Delete("insert into patientAdmission (DateOfEntry,Notes,panumber,roomid,deptid,SIdd,DownPayment)values(@DateOfEntry,@Notes,@panumber,@roomid,@deptid,@SIdd,@DownPayment)",
                    new SqlParameter("@DateOfEntry", Convert.ToDateTime(dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString()).ToShortDateString()),
                    new SqlParameter("@Notes", txt_Notes.Text),
                    new SqlParameter("@panumber", int.Parse(txt_numberpatient.Text)),
                    new SqlParameter("@roomid", int.Parse(combox_room.Text)),
                    new SqlParameter("@deptid", deptid),
                    new SqlParameter("@SIdd", SIdd),
                    new SqlParameter("@DownPayment", int.Parse(txt_payment.Text))
                    );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Add_login_record_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'hospitallDataSet.Room' table. You can move, or remove it, as needed.


        }

        private void txt_numberpatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }

        private void txt_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }
    }
}
