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
    public partial class Private_reception : Form
    {
        int move;
        int movex;
        int movey;
        string dept;
        public Private_reception(string x)
        {
            InitializeComponent();
            dept = x;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
            { WindowState = FormWindowState.Normal; }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel_title_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }


        private Bunifu.Framework.UI.BunifuFlatButton currentButton;
        public void ChildForm(object child)
        {
            if (this.panel_form.Controls.Count > 0) this.panel_form.Controls.RemoveAt(0);
            Form f = child as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            this.panel_form.Controls.Add(f);
            this.panel_form.Tag = f;

            f.Show();
        }
        public void DisplayBtn(object btnsender)
        {
            foreach (Bunifu.Framework.UI.BunifuFlatButton previousBtn in panel_button.Controls)
            {
                if (previousBtn.GetType() == typeof(Bunifu.Framework.UI.BunifuFlatButton))
                {
                    previousBtn.Normalcolor = Color.FromArgb(51, 51, 76);
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;

                }
            }

        }
        public void ActiveBtn(object btnsender)
        {
            DisplayBtn(btnsender);
            currentButton = (Bunifu.Framework.UI.BunifuFlatButton)btnsender;
            currentButton.Normalcolor = panel_title.BackColor;
            currentButton.BackColor = panel_title.BackColor;
            currentButton.ForeColor = Color.White;
        }
        private void update_entrance_patient_Click_1(object sender, EventArgs e)
        {
            Edit_Graduating_Patient edit_Graduating_Patient = new Edit_Graduating_Patient(dept);
            ActiveBtn(sender);
            ChildForm(edit_Graduating_Patient);
        }

        private void view_info_patient_Click(object sender, EventArgs e)
        {
            View_Patient view_Patient = new View_Patient(dept);
            ActiveBtn(sender);
            ChildForm(view_Patient);
        }

        private void view_entrance_patient_Click(object sender, EventArgs e)
        {
            View_Login_Record view_Login_Record = new View_Login_Record(dept);
            ActiveBtn(sender);
            ChildForm(view_Login_Record);
        }

        private void search_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Search_Patient());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Add_login_record login_Record = new Add_login_record(dept);
             ActiveBtn(sender);
             ChildForm(login_Record);
           
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Request_X_ray());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Result_picture(dept));
        }

        private void search_patientAdmission_Click(object sender, EventArgs e)
        {
            int deptid = int.Parse(DB.SelectToGetOneValue("select deptid from dept where deptname='" + dept + "'"));
            ActiveBtn(sender);
            ChildForm(new Search_Admission(deptid));
        }

        private void btn_request_analyzes_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Request_Analyzes());
        }

        private void btn_result_analyzes_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Result_Analyzes(dept));
        }

        
    }

}
