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
        public Edit_Graduating_Patient(string x)
        {
            x = dept;
            InitializeComponent();
          
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("update patientAdmission set DateOfEntry=convert(date,'" + dateIn.Value.Day.ToString() + "-" + dateIn.Value.Month.ToString() + "-" + dateIn.Value.Year.ToString() + "',105),panumber=" +
                int.Parse(txt_numberpatient.Text) + " rommid="+int.Parse(combox_room.SelectedValue.ToString())+",SIdd="+int.Parse(combox_doctor.SelectedValue.ToString())+ " ,DownPayment="+int.Parse(txt_payment.Text)+"");
        }

        private void btn_graduating_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("update patientAdmission set checkoutDate=convert(date,'" + dateOut.Value.Day.ToString() + "-"
                + dateOut.Value.Month.ToString() + "-" + dateOut.Value.Year.ToString() + "',105)");
            
        }
    }
}
