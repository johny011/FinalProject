using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Final_project
{
    public partial class Accounting : Form
    {
        SqlConnection con = new SqlConnection(DB.con);
        SqlCommand com;
        double t, AP, da, ma, q;
        public Accounting()
        {
            InitializeComponent();
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
        int move;
        int movex;
        int movey;
        private void minBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
            { WindowState = FormWindowState.Normal; }
        }

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void panel_title_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int RowAnalyzes = DB.DataTable("select celendarRAid,price, Analysisname from Analyzes A,celendarRA CRA ,RequiredAnalysis RA where A.Analysisnumber = RA.Analysisnumber and RA.RequiredAnalysisid = CRA.RequiredAnalysisid and RA.Admissionid = @Admissionid ",
                    new SqlParameter("@Admissionid", int.Parse(textBox1.Text))).Rows.Count;
                int RowPictures = DB.DataTable("select celendarRPid,price,picturesname from pictures P,Requiredpictures RP,celendarRP CRP where P.picturesid=RP.picturesid and RP.Requiredpicturesid=CRP.Requiredpicturesid and RP.Admissionid=@Admissionid " ,
                    new SqlParameter("@Admissionid", int.Parse(textBox1.Text))).Rows.Count;
                if (RowAnalyzes != 0)
                    dataGridView1.DataSource = DB.DataTable("select celendarRAid,price, Analysisname from Analyzes A,celendarRA CRA ,RequiredAnalysis RA where A.Analysisnumber = RA.Analysisnumber and RA.RequiredAnalysisid = CRA.RequiredAnalysisid and RA.Admissionid = @Admissionid ",
                      new SqlParameter("@Admissionid", int.Parse(textBox1.Text)));
                if (RowPictures != 0)
                    dataGridView2.DataSource = DB.DataTable("select celendarRPid,price,picturesname from pictures P,Requiredpictures RP,celendarRP CRP where P.picturesid=RP.picturesid and RP.Requiredpicturesid=CRP.Requiredpicturesid and RP.Admissionid=@Admissionid ",
                      new SqlParameter("@Admissionid", int.Parse(textBox1.Text)));
                //جلب مجموع اسعار التحاليل
                com = new SqlCommand("select sum(price) from Analyzes A,celendarRA CRA ,RequiredAnalysis RA where A.Analysisnumber = RA.Analysisnumber and RA.RequiredAnalysisid = CRA.RequiredAnalysisid and RA.Admissionid = @Admissionid ", con);
                com.Parameters.AddWithValue("@Admissionid", int.Parse(textBox1.Text));
                //لجلب مجموع اسعار الصور
                SqlCommand comm = new SqlCommand("select sum(price) from pictures P,Requiredpictures RP,celendarRP CRP where P.picturesid=RP.picturesid and RP.Requiredpicturesid=CRP.Requiredpicturesid and RP.Admissionid=@Admissionid ", con);
                comm.Parameters.AddWithValue("@Admissionid", int.Parse(textBox1.Text));
                con.Open();
                int A = 0;
                if (RowAnalyzes != 0)
                    A = Convert.ToInt32(com.ExecuteScalar());
                int P = 0;
                if (RowPictures != 0)
                    P = Convert.ToInt32(comm.ExecuteScalar());
                //لجمع حق الصور والتحاليل وتكاليف المتربة 
                AP = A + P + (Convert.ToDouble(textBox2.Text));
                label8.Text = AP.ToString();
                con.Close();
                //لجلب الدفعة الاولية
                SqlCommand ccom = new SqlCommand("select DownPayment from patientAdmission where Admissionid=@Admissionid ", con);
                ccom.Parameters.AddWithValue("@Admissionid", int.Parse(textBox1.Text));
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
                if (AP < 15000) { ma = (AP + da) - (q); label15.Text = ma.ToString(); label16.Text = "0"; return; }
                if (AP >= 15000 && AP <= 20000) { ma = (AP + da) - (q + 1000); label15.Text = ma.ToString(); label16.Text = "1000"; return; }
                if (AP > 20000 && AP <= 30000) { ma = (AP + da) - (q + 2000); label15.Text = ma.ToString(); label16.Text = "2000"; return; }
                if (AP > 30000 && AP <= 50000) { ma = (AP + da) - (q + 4000); label15.Text = ma.ToString(); label16.Text = "4000"; return; }
                else
                {
                    ma = (AP + da) - (q + 5000);
                    label15.Text = ma.ToString(); label16.Text = "5000"; return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
