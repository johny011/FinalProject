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
    public partial class Add_Picture : Form
    {
        public Add_Picture()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("insert into pictures (picturesname,price,processing) values (@picturesname,@price,@processing)",
                new SqlParameter("@picturesname", txt_name_picture.Text),
                new SqlParameter("@price", int.Parse(txt_price_picture.Text)),
                new SqlParameter("@processing",txt_processing.Text));
        }

        private void txt_price_picture_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }
    }
}
