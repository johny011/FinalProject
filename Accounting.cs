using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;


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

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar)  && e.KeyChar!='.')
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!DB.Isnumber(e.KeyChar))
            {
                MessageBox.Show("يجب ادخال ارقام فقط");
                e.Handled = true;
            }
        }
        Bitmap bt;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
                    //ارسال المعلومات للجدول
                    string s = Convert.ToDateTime(dateTimePicker1.Value).ToShortDateString();
                    DB.Insert_Update_Delete("insert into Accounting values ('" + s + "'," + t + "," + da + "," + label16.Text + "," + textBox2.Text + "," + textBox1.Text + "," + (AP + t) + ")");
                    //كود الارسال للطابعة
                    MessageBox.Show("تم بنجاح");
                    Graphics graphics = this.CreateGraphics();
                    bt = new Bitmap(this.Size.Width, this.Size.Height, graphics);
                    Graphics mg = Graphics.FromImage(bt);
                    mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                    printPreviewDialog1.ShowDialog();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bt, 0, 0);
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
