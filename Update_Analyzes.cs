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
    public partial class Update_Analyzes : Form
    {
        public Update_Analyzes()
        {
            InitializeComponent();
        }

        private void Update_Analyzes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet38.Analyzes' table. You can move, or remove it, as needed.
            this.analyzesTableAdapter.Fill(this.hospitallDataSet38.Analyzes);

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow gr in dataGridView1.Rows)
            {
                DB.Insert_Update_Delete("update Analyzes set Analysisname='" + gr.Cells[1].Value.ToString() + "',price=" + int.Parse(gr.Cells[2].Value.ToString()) + " ,processing ='" + gr.Cells[3].Value.ToString() + "' where Analysisnumber=" + int.Parse(gr.Cells[0].Value.ToString()) + "");
            }
        }
    }
}
