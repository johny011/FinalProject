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
    public partial class Add_Analyze : Form
    {
        public Add_Analyze()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("insert into Analyzes (Analysisname,price,processing) values (@Analysisname,@price, @processing)",
                new SqlParameter("@Analysisname", txt_name_analyze.Text),
                new SqlParameter("@price", int.Parse(txt_price_analyze.Text)),
                new SqlParameter("@processing", txt_processing.Text));
        }
    }
}
