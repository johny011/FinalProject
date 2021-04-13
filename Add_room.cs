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
    public partial class Add_room : Form
    {
        
        public Add_room()
        {
            InitializeComponent();
            DB.Fillcombo("select * from dept where deptid<>0", ref DB.DeptId, ref combox_section);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int deptId = DB.GetId(DB.DeptId, combox_section);
            DB.Insert_Update_Delete("insert into Room (roomtype,deptid) values ('" + combox_room_type.Text + "'," + deptId + ")");
        }
    }
}
