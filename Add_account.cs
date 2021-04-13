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
    public partial class Add_account : Form
    {
        Dictionary<int, string> Dept = new Dictionary<int, string>();
        public Add_account()
        {
            InitializeComponent();
            DB.Fillcombo("select * from Dept where deptid<>0", ref Dept, ref combox_deptid);
        }
        
        private int GetId(Dictionary<int, string> dic, ComboBox combo)
        {
            int ID = 0;
            foreach (var x in dic)
            {
                if (x.Value == combo.Text)
                {
                    ID = x.Key;
                }
            }
            return ID;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            int count = DB.DataTable("select * from المستخدمين where username='" + txt_user_name.Text + "'").Rows.Count;
            if(count==0)
            {
                DB.Insert_Update_Delete("insert into المستخدمين (username,passeword,deptid)values ('" + txt_user_name.Text + "','" + txt_password.Text + "'," + GetId(Dept, combox_deptid) + ")");
            }
            else
            {
                MessageBox.Show("قم بتغيير اسم المستخدم");
            }
            
        }
        
    }
}
