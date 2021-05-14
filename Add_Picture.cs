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
    public partial class Add_Picture : Form
    {
        public Add_Picture()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DB.Insert_Update_Delete("insert into pictures (picturesname,price,processing) values ('" + txt_name_picture.Text + "','" + int.Parse(txt_price_picture.Text) + "','" + txt_processing.Text + "')");
        }
    }
}
