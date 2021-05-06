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
    public partial class Add_working_period : Form
    {
        SqlConnection con = new SqlConnection(DB.con);
        SqlCommand com;
        public Add_working_period()
        {
            InitializeComponent();
            //لتعبئة الاطباء
            DataTable d1 = DB.DataTable("select Sname from TheStaff where typeid = 1");
            for (int i = 0; i < d1.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(d1.Rows[i]["sname"].ToString());
            }
            //لتعبئة الممرضين
            DataTable d2 = DB.DataTable("select Sname from TheStaff where typeid = 2");
            for (int i = 0; i < d2.Rows.Count; i++)
            {
                checkedListBox2.Items.Add(d2.Rows[i]["sname"].ToString());
            }
            //لتعبئة المستخدمين
            DataTable d3 = DB.DataTable("select Sname from TheStaff where typeid = 3");
            for (int i = 0; i < d3.Rows.Count; i++)
            {
                checkedListBox3.Items.Add(d3.Rows[i]["sname"].ToString());
            }

        }
       

        private void btn_add_Click(object sender, EventArgs e)
        {
            string d = Convert.ToDateTime(dateTimePicker1.Value).ToShortDateString();
            int i;
            for (i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string s = checkedListBox1.CheckedItems[i].ToString();
                com = new SqlCommand("select id from TheStaff where sname='" + s + "' and typeid=1", con);
                con.Open();
                int doo = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
                DB.Insert_Update_Delete("insert into WorkPeriods values(" + int.Parse(combox_situations.SelectedValue.ToString()) + "," + doo + "," + int.Parse(combox_period.SelectedValue.ToString()) + ",'" + d + "')");
            }
            for (i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {
                string s = checkedListBox2.CheckedItems[i].ToString();
                com = new SqlCommand("select id from TheStaff where sname='" + s + "' and typeid=2", con);
                con.Open();
                int doo = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
                DB.Insert_Update_Delete("insert into WorkPeriods values(" + int.Parse(combox_situations.SelectedValue.ToString()) + "," + doo + "," + int.Parse(combox_period.SelectedValue.ToString()) + ",'" + d + "')");
            }
            for (i = 0; i < checkedListBox3.CheckedItems.Count; i++)
            {
                string s = checkedListBox3.CheckedItems[i].ToString();
                com = new SqlCommand("select id from TheStaff where sname='" + s + "' and typeid=3", con);
                con.Open();
                int doo = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
                DB.Insert_Update_Delete("insert into WorkPeriods values(" + int.Parse(combox_situations.SelectedValue.ToString()) + "," + doo + "," + int.Parse(combox_period.SelectedValue.ToString()) + ",'" + d + "')");
            }
            MessageBox.Show("تم بنجاح");
        }

        private void combox_period_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_working_period_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitallDataSet45.TheSituation' table. You can move, or remove it, as needed.
            this.theSituationTableAdapter.Fill(this.hospitallDataSet45.TheSituation);
            // TODO: This line of code loads data into the 'hospitallDataSet44.TimePeriods' table. You can move, or remove it, as needed.
            this.timePeriodsTableAdapter.Fill(this.hospitallDataSet44.TimePeriods);
            // TODO: This line of code loads data into the 'hospitallDataSet43.Typee' table. You can move, or remove it, as needed.
            this.typeeTableAdapter.Fill(this.hospitallDataSet43.Typee);
            

        }
    }
}
