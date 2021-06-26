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
    public partial class Request_X_ray : Form
    {
        public Request_X_ray()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool requierd = false;
             if (txt_Admissionid.Text != "")
             {
                 foreach (DataGridViewRow row in dataGridView1.Rows)
                 {
                    try
                    {
                        if (row.Cells[4].Value != null)
                        { DB.Insert_Update_Delete("insert into Requiredpictures (picturesid,Admissionid) values(@picturesid,@Admissionid)",
                           new SqlParameter("@picturesid", int.Parse(row.Cells[0].Value.ToString())),
                           new SqlParameter("@Admissionid", int.Parse(txt_Admissionid.Text)));
                            requierd = true;
                        }

                        
                    }
                    catch(Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                 }

             }
             else
             {
                 MessageBox.Show("عليك ادخال رقم دخولية المريض");
             }
             if(requierd==true)
             {
                MessageBox.Show("تم طلب الصور بنجاح");
             }
             else
            {
                MessageBox.Show("لم يتم طلب اي صورة");
            }
        }

        private void Required_X_ray_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet48.pictures' table. You can move, or remove it, as needed.
            this.picturesTableAdapter.Fill(this.hospitallDataSet48.pictures);
           
            

        }

        private void txt_Admissionid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }
    }
}
