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
    public partial class Add_work_staff : Form
    {
        
        public Add_work_staff()
        {
            InitializeComponent();
            DB.Fillcombo("select * from Typee", ref DB.TypeId, ref combox_typeid);
            DB.Fillcombo("select * from Dept where deptid<>0 ", ref DB.DeptId, ref combox_deptid);
        }

        private void btn_add_Click(object sender, EventArgs e)
        { 
            int Type = GetId(DB.TypeId, combox_typeid);
           int Dept= GetId(DB.DeptId, combox_deptid);
             DB.Insert_Update_Delete("insert into TheStaff (Sname,Fathername,mothername,TheIdNumber,typeid,deptid)values('"+txt_name.Text+"','" +
                 txt_father_name.Text+"','"+txt_mother_name.Text+"','"+txt_NO_number.Text+"',"+Type+","+Dept+")");
        }
        private int GetId(Dictionary<int,string> dic,ComboBox combo)
        {
            int ID=0;
            foreach (var x in dic)
            {
                if (x.Value == combo.Text)
                {
                    ID = x.Key;
                }
            }
            return ID;
        }
        
    }
}
