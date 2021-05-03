﻿using System;
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
    public partial class Request_Analyzes : Form
    {
        public Request_Analyzes()
        {
            InitializeComponent();
        }

        private void Request_Analyzes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet31.Analyzes' table. You can move, or remove it, as needed.
            this.analyzesTableAdapter.Fill(this.hospitallDataSet31.Analyzes);

        }

        private void btn_Request_Click(object sender, EventArgs e)
        {
            bool requierd = false;
            if (txt_Admissionid.Text != "")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        if (row.Cells[5].Value != null)
                        {
                            DB.Insert_Update_Delete("insert into RequiredAnalysis (Analysisnumber,Admissionid) values(" + int.Parse(row.Cells[0].Value.ToString()) + " ," + int.Parse(txt_Admissionid.Text) + ")");
                            requierd = true;
                        }


                    }
                    catch (Exception exp)
                    {

                    }
                }

            }
            else
            {
                MessageBox.Show("عليك ادخال رقم دخولية المريض");
            }
            if (requierd == true)
            {
                MessageBox.Show("تم طلب التحليل بنجاح");
            }
            else
            {
                MessageBox.Show("لم يتم طلب اي تحليل");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}