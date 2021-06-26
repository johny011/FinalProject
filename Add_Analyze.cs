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
            if (txt_name_analyze.Text != "" && txt_price_analyze.Text != "" && txt_processing.Text != "")
            {
                
                 try
                 {
                     DB.Insert_Update_Delete("insert into Analyzes (Analysisname,price,processing) values (@Analysisname,@price, @processing)",
                            new SqlParameter("@Analysisname", txt_name_analyze.Text),
                            new SqlParameter("@price", int.Parse(txt_price_analyze.Text)),
                            new SqlParameter("@processing", txt_processing.Text));
                        MessageBox.Show("تمت الإضافة بنجاح");
                    txt_name_analyze.Text = "";
                    txt_price_analyze.Text = "";
                    txt_processing.Text = "";

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                
            }
            else
            {
                MessageBox.Show("يجب ادخال جميع المعلومات");
            }
        }

        private void txt_price_analyze_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }
    }
}
