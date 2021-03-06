using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Final_project
{
    
    public partial class Main_admin : Form
    {
        int move;
        int movex;
        int movey;
        bool checkClick = false;
       
        public Main_admin()
        {
            InitializeComponent();
            
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
            foreach (Bunifu.Framework.UI.BunifuFlatButton previousBtn in panel.Controls)
            {
                if (previousBtn.GetType() == typeof(Bunifu.Framework.UI.BunifuFlatButton))
                {
                    previousBtn.Normalcolor = Color.FromArgb(51, 51, 76);
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;

                }
            }

        }
        public void DisplayBtn(object btnsender,Panel p)
        {
           if(panel2.Visible==true)
            {
                foreach (Bunifu.Framework.UI.BunifuFlatButton previousBtn in panel2.Controls)
                {
                    if (previousBtn.GetType() == typeof(Bunifu.Framework.UI.BunifuFlatButton))
                    {
                        previousBtn.Normalcolor = Color.FromArgb(51, 51, 76);
                        previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                        previousBtn.ForeColor = Color.Gainsboro;

                    }
                }

            }
           if(panel.Visible)
            {
                foreach (Bunifu.Framework.UI.BunifuFlatButton previousBtn in panel.Controls)
                {
                    if (previousBtn.GetType() == typeof(Bunifu.Framework.UI.BunifuFlatButton))
                    {
                        previousBtn.Normalcolor = Color.FromArgb(51, 51, 76);
                        previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                        previousBtn.ForeColor = Color.Gainsboro;

                    }
                }

            }
            foreach (Bunifu.Framework.UI.BunifuFlatButton previousBtn in p.Controls)
            {
                if (previousBtn.GetType() == typeof(Bunifu.Framework.UI.BunifuFlatButton))
                {
                    previousBtn.Normalcolor = Color.FromArgb(51, 51, 76);
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;

                }
            }

        }
       
        public void ActiveBtn(object btnsender,Panel p )
        {
            DisplayBtn(btnsender,p);
            currentButton = (Bunifu.Framework.UI.BunifuFlatButton)btnsender;
            currentButton.Normalcolor = panel_title.BackColor;
            currentButton.BackColor = panel_title.BackColor;
            currentButton.ForeColor = Color.White;
        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel2);
            ChildForm(new Add_work_staff());
        }

        private void btn_add_acount_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel2);
            ChildForm(new Add_account());
        }

        private void btn_add_interval_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel2);
            ChildForm(new Add_period ());
        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel2);
            ChildForm(new Add_room());
        }

        

        private void btn_add_working_period_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel2);
            ChildForm(new Add_working_period());
        }

        private void btn_update_emp_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel);
            ChildForm(new Update_staff());
        }

        private void btn_update_acount_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel);
            ChildForm(new Update_account());
        }

        private void btn_update_interval_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel);
            ChildForm(new Update_period());
        }

        private void btn_update_room_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel);
            ChildForm(new Update_room());
        }

        private void btn_update_working_period_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel);
            ChildForm(new Update_working_period());
        }

        

        private void btn_show_department_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender,panel);
            ChildForm(new View_department());
        }

        

        private void panel_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewPanle_btn_Click(object sender, EventArgs e)
        {

            viewPanle_btn.Normalcolor = Color.FromArgb(119, 119, 132);
            addPanel_btn.Normalcolor = panel1.BackColor;
            if (panel.Visible == true) { panel.Visible = false; }
            else { panel.Visible = true; }
            DisplayBtn(sender, panel);
            panel2.Visible = false;
        }

        private void addPanel_btn_Click(object sender, EventArgs e)
        {
           addPanel_btn.Normalcolor= Color.FromArgb(119, 119, 132);
            viewPanle_btn.Normalcolor = panel1.BackColor;
            if (panel2.Visible == true) { panel2.Visible = false;  }
            else panel2.Visible = true;
            DisplayBtn(sender, panel2);
            panel.Visible = false;
        }
    }
}
