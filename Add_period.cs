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
    public partial class Add_period : Form
    {
        public Add_period()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow gr = dataGridView1.CurrentRow;
                int id = -1;
                id = int.Parse(DB.SelectToGetOneValue("select periodnumber from TimePeriods where ThePeriod=@theperiod", new SqlParameter("@theperiod", gr.Cells[1].Value.ToString())));
                if (id == -1)
                    DB.Insert_Update_Delete("insert into TimePeriods (ThePeriod) values (@ThePeriod);", new SqlParameter("@ThePeriod", gr.Cells[1].Value.ToString()));
                else
                {
                    MessageBox.Show("هذه الفترة موجودة");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }
    }
}
