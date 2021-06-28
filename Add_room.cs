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
    public partial class Add_room : Form
    {
        
        public Add_room()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (combox_room_type.Text != "")
            {
                int deptId =int.Parse(combox_section.SelectedValue.ToString());
                DB.Insert_Update_Delete("insert into Room (roomtype,deptid) values (@roomtype,@deptid)",
                    new SqlParameter("@roomtype", combox_room_type.Text),
                    new SqlParameter("@deptid",deptId));
            }
            else
            {
                MessageBox.Show("يجب ادخال نوع الغرفة"); 
            }
        }

        private void Add_room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet15.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.hospitallDataSet15.Dept);

        }
    }
}
