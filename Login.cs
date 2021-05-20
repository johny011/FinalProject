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
    public partial class Login : Form
    {
        int move;
        int movex;
        int movey;
        public Login()
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
        private string Select(string txt)
        {
            SqlConnection connection = new SqlConnection(DB.con);
            SqlCommand command = new SqlCommand(txt, connection);
            connection.Open();
            var query = command.ExecuteReader();
            string resquery = "";
            if (query.Read())
            {
                resquery = query[0].ToString();
                return resquery;
            }
            return "";
            
        }
        private bool validate(string textbox)
        {
            if(textbox.IndexOf("--")!=-1|| textbox.IndexOf(" or ")!=-1|| textbox.IndexOf("'")!=-1|| textbox.IndexOf(";")!=-1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        private void btn_login_Click(object sender, EventArgs e)
        {

               bool user= validate(txt_user_name.Text);
               bool pass = validate(txt_password.Text);
               if (user==true && pass==true)
               {
                    int login= DB.DataTable("select * from users where username='" + txt_user_name.Text + "' and passeword='" + txt_password.Text + "';").Rows.Count;
                   if (login == 1)
                   {

                       string resquery = Select("select form from users where username='" + txt_user_name.Text + "' and passeword='" + txt_password.Text + "';");
                       if (resquery == "IT")
                       {
                           Main_admin admin = new Main_admin();
                           this.Hide();
                           admin.ShowDialog();
                           this.Close();
                       }
                       else if (resquery == "MainResiption")
                       {
                           General_reception general_Reception = new General_reception();
                           this.Hide();
                           general_Reception.ShowDialog();
                           this.Close();
                       }
                       else if (resquery == "xray")
                       {
                           X_Ray x_Ray = new X_Ray();
                           this.Hide();
                           x_Ray.ShowDialog();
                           this.Close();
                       }
                       else if (resquery == "analyze")
                       {
                           Laboratory x_Ray = new Laboratory();
                           this.Hide();
                           x_Ray.ShowDialog();
                           this.Close();
                       }
                       else 
                       {
                           Private_reception private_Reception;
                           private_Reception = new Private_reception(resquery);
                           this.Hide();
                           private_Reception.ShowDialog();
                           this.Close();
                       }
                   }
                   else
                       MessageBox.Show("تحقق من اسم المستخدم وكلمة المرور");   
               }
               else
               {
                   MessageBox.Show("لقد قمت باستخدام بعض الرموز التي لا يمكن استخدامها");
                   txt_password.Text = "كلمة المرور";
                   txt_user_name.Text = "اسم المستخدم";
               }
            
        }
        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
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

        private void txt_user_name_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_user_name_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void panel_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Enter(object sender, EventArgs e)
        {

        }
    }
}
