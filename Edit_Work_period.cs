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
        int move;
        int movex;
        int movey;


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
                new SqlParameter("@Situationid", Convert.ToInt32(combox_situation.SelectedValue.ToString())),
                new SqlParameter("@DayAndDate", Convert.ToDateTime(dateTimePicker1.Value).ToShortDateString()),
                new SqlParameter("@periodnumber",periodnumber),
                new SqlParameter("@id",id)
                );
            MessageBox.Show("تم التعديل");
            
            
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Edit_Work_period_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet56.TheSituation' table. You can move, or remove it, as needed.
            this.theSituationTableAdapter.Fill(this.hospitallDataSet56.TheSituation);

        }
        

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
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

        private void panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void panel_title_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
    }
}
