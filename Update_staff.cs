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
    public partial class Update_staff : Form
    {
        public Update_staff()
        {
            InitializeComponent();
            
            Grid();
            
        }
        DataGridViewComboBoxColumn combType=new DataGridViewComboBoxColumn();
        DataGridViewComboBoxColumn combDept = new DataGridViewComboBoxColumn();
        private void Grid()
        {
            dataGridView1.DataSource = DB.DataTable("select id,Sname,Fathername,mothername,TheIdNumber from TheStaff");
            dataGridView1.Columns[0].HeaderText = "رقم العامل";
            dataGridView1.Columns[1].HeaderText = "اسم العامل";
            dataGridView1.Columns[2].HeaderText = "اسم الاب";
            dataGridView1.Columns[3].HeaderText = "اسم الام";
            dataGridView1.Columns[4].HeaderText = "الرقم الوطني";
            combType = new DataGridViewComboBoxColumn();
              combDept = new DataGridViewComboBoxColumn();
             
             foreach(var keyValuePair in DB.DeptId)
             {
                 //Type.Items.Add(keyValuePair.Value);
             }
             foreach (var keyValuePair in DB.TypeId)
             {
                 combType.Items.Add(keyValuePair.Value);
             }
            dataGridView1.Columns[5].HeaderText = "النوع";
           
            
            
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            
                DataGridViewRow gr = dataGridView1.CurrentRow;
            int deptid = DB.GetIDFromDic(gr.Cells[1].Value.ToString(), DB.DeptId);
            int typeid= DB.GetIDFromDic(gr.Cells[0].Value.ToString(), DB.TypeId);

            DB.Insert_Update_Delete("update TheStaff set Sname='" + gr.Cells[1].Value.ToString() + "', Fathername ='" + gr.Cells[2].Value.ToString() + "', mothername ='" + gr.Cells[3].Value.ToString() + "', TheIdNumber ='" + gr.Cells[4].Value.ToString() +
                           "', typeid ="+ typeid + ",  deptid=" + deptid + "where id=" +
                           int.Parse(gr.Cells[2].Value.ToString()) + ";");
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //  DB.Insert_Update_Delete("delete from TheStaff where id="+(int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()))+";");
            
        }

        private void Update_staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet.Dept' table. You can move, or remove it, as needed.
           

        }
    }
}
