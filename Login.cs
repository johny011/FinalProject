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
using System.Data;


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
            DB.FillDic("select * from dept where deptid<>0",ref DB.DeptId);
            DB.FillDic("select * from Typee" ,ref DB.TypeId);
        }
        Main_admin admin = new Main_admin();
        
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DB.con);
            SqlCommand command = new SqlCommand("select deptid from users where username='" + txt_user_name.Text+"' and passeword='"+txt_password.Text+"';",connection);
            connection.Open();
            var query = command.ExecuteReader();
            string resquery="";
            if (query.Read())
            {
                resquery = query[0].ToString();
            }
            if (resquery == "0")
            {
                
                admin.ShowDialog();
                
               
            }
            else if(resquery=="")
            {
                MessageBox.Show("تحقق من اسم المستخدم وكلمة المرور وأعد المحاولة ثانية");
            }
            else 
            {
                MessageBox.Show("user");
            }
            connection.Close();
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
    }
}
