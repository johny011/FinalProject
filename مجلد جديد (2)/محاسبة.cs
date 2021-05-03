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
using System.Data;

namespace تخرجججججج
{
    public partial class محاسبة : Form
    {
        public محاسبة()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(DB.con);
        SqlCommand com;
        double t,AP,da,ma,q;
        private void محاسبة_Load(object sender, EventArgs e)
        {
            label1.Text = label8.Text = label10.Text = label15.Text = label16.Text = "  ";
            try
            {
                //جلب رقم الفاتورة يلي بدي دخله معلوماتها
                DataTable d = (DB.DataTable("select * from Accounting "));
                con.Open();
                int R = d.Rows.Count;
                label1.Text = (R + 1).ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DB.DataTable("select celendarRAid,price, Analysisname from Analyzes A,celendarRA CRA ,RequiredAnalysis RA where A.Analysisnumber = RA.Analysisnumber and RA.RequiredAnalysisid = CRA.RequiredAnalysisid and RA.Admissionid = '" + textBox1.Text + "' ");
                dataGridView2.DataSource = DB.DataTable("select celendarRPid,price,picturesname from pictures P,Requiredpictures RP,celendarRP CRP where P.picturesid=RP.picturesid and RP.Requiredpicturesid=CRP.Requiredpicturesid and RP.Admissionid='" + textBox1.Text + "' ");
                //جلب مجموع اسعار التحاليل
                com = new SqlCommand("select sum(price) from Analyzes A,celendarRA CRA ,RequiredAnalysis RA where A.Analysisnumber = RA.Analysisnumber and RA.RequiredAnalysisid = CRA.RequiredAnalysisid and RA.Admissionid = '" + textBox1.Text + "' ", con);
                //لجلب مجموع اسعار الصور
                SqlCommand comm = new SqlCommand("select sum(price) from pictures P,Requiredpictures RP,celendarRP CRP where P.picturesid=RP.picturesid and RP.Requiredpicturesid=CRP.Requiredpicturesid and RP.Admissionid='" + textBox1.Text + "' ", con);
                con.Open();
                int A = Convert.ToInt32(com.ExecuteScalar());
                int P = Convert.ToInt32(comm.ExecuteScalar());
                //لجمع حق الصور والتحاليل وتكاليف المتربة 
               AP = A + P + (Convert.ToDouble(textBox2.Text));
                label8.Text = AP.ToString();
                con.Close();
                //لجلب الدفعة الاولية
                SqlCommand ccom = new SqlCommand("select DownPayment from patientAdmission where Admissionid='" + textBox1.Text + "' ", con);
                con.Open();
                 q = Convert.ToDouble(ccom.ExecuteScalar());
                label10.Text = q.ToString();
                con.Close();
                //التأمين
                t = AP * (Convert.ToDouble(textBox3.Text) / 100);
                //الضرائب
                 da = (Convert.ToDouble(textBox4.Text));
                //مجموع الاخير 
                AP = AP - t;
                //شرائح نسبة الحسم
                if (AP < 15000) { ma = (AP + da) - (q); label15.Text = ma.ToString();label16.Text = "0"; return; }
                if (AP >= 15000 && AP <= 20000) { ma = (AP + da) - (q + 1000); label15.Text = ma.ToString(); label16.Text = "1000"; return; }
                if (AP > 20000 && AP <= 30000) { ma = (AP + da) - (q + 2000); label15.Text = ma.ToString(); label16.Text = "2000"; return; }
                if (AP > 30000 && AP <= 50000) { ma = (AP + da) - (q + 4000); label15.Text = ma.ToString(); label16.Text = "4000"; return; }
                else { ma = (AP + da) - (q + 5000);
                    label15.Text = ma.ToString(); label16.Text = "5000"; return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                //ارسال المعلومات للجدول
                string s = Convert.ToDateTime(dateTimePicker1.Value).ToShortDateString();
                DB.Insert_Update_Delete("insert into Accounting values ('"+s+"'," + t + "," + da + "," + label16.Text + "," + textBox2.Text + "," + textBox1.Text + "," + (AP+t) + ")");
                //كود الارسال للطابعة
                MessageBox.Show("تم بنجاح");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
}
