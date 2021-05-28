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
    public partial class Add_account : Form
    {
        
        public Add_account()
        {
            InitializeComponent();
            
        }
        
        
        private void btn_add_Click(object sender, EventArgs e)
        {
             int count = DB.DataTable("select * from users where username=@username'",
                 new SqlParameter("@username", txt_user_name.Text)).Rows.Count;
             int dept = DB.DataTable("select * from users where form =@form",
                 new SqlParameter("@form", combox_deptid.Text.ToString())).Rows.Count;
             if (count==0)
             {
                 if(dept==0)
                 DB.Insert_Update_Delete("insert into users (username,passeword,form)values (@username,@passeword,@form)",
                     new SqlParameter("@username", txt_user_name.Text),
                     new SqlParameter("@passeword", txt_password.Text),
                     new SqlParameter("@form", combox_deptid.SelectedValue.ToString()));
                 else
                 {
                     MessageBox.Show("تم إنشاء حساب خاص بهذا القسم مسبقاً");
                 }
             }
             else
             {
                 MessageBox.Show("قم بتغيير اسم المستخدم");
             }
             
            
            
        }

        private void Add_account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet20.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet20.Dept);
            // TODO: This line of code loads data into the 'hospitallDataSet19.Dept' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'hospitallDataSet14.Dept' table. You can move, or remove it, as needed.
            

        }

        
    }
}
