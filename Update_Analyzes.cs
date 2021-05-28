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
    public partial class Update_Analyzes : Form
    {
        public Update_Analyzes()
        {
            InitializeComponent();
        }

        private void Update_Analyzes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet51.Analyzes' table. You can move, or remove it, as needed.
            this.analyzesTableAdapter.Fill(this.hospitallDataSet51.Analyzes);
            

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow gr = dataGridView1.CurrentRow;
                DB.Insert_Update_Delete("update Analyzes set Analysisname=@Analysisname,price=@price ,processing =@processing  where Analysisnumber=@Analysisnumber",
                    new SqlParameter("@Analysisname", gr.Cells[1].Value.ToString()),
                    new SqlParameter("@price", int.Parse(gr.Cells[2].Value.ToString())),
                    new SqlParameter("@processing", gr.Cells[3].Value.ToString()),
                    new SqlParameter("@Analysisnumber", int.Parse(gr.Cells[0].Value.ToString())));
            MessageBox.Show("تم التعديل");
            Update_Analyzes_Load(sender, e);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow gr = dataGridView1.CurrentRow;
            DB.Insert_Update_Delete("delet from Analyzes where  Analysisnumber=@Analysisnumber" ,
                new SqlParameter("@Analysisnumber", int.Parse(gr.Cells[0].Value.ToString())));
            MessageBox.Show("تم الحذف");
            Update_Analyzes_Load(sender, e);
        }
    }
}
