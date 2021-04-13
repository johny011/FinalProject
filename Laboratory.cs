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
    public partial class Laboratory : Form
    {
        int move;
        int movex;
        int movey;
        public Laboratory()
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

         

        private void btn_add_analyz_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Required_analyzes());
        }

        private void btn_add_result_of_an_analysis_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Add_work_staff());
        }

        private void btn_update_analyz_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Add_work_staff());
        }

        private void btn_show_analyz_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Add_work_staff());
        }

        private void btn_show_required_analyzes_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Add_work_staff());
        }

        private void btn_show_test_results_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender);
            ChildForm(new Add_work_staff());
        }
    }
}
