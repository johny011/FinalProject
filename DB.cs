using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace Final_project
{
    class DB
    {
        public static string con = "Data Source=DESKTOP-U91N0A8;Initial Catalog=hospitall;Integrated Security=True";
        public static void Insert_Update_Delete(string query, params SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(con);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddRange(parameters);
            connection.Open();
            int count = command.ExecuteNonQuery();
            connection.Close();
        }
        public static string SelectToGetOneValue(string query)
        {
            string res = "";
            SqlConnection connection= new SqlConnection(con);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            var result=command.ExecuteReader();
            if(result.Read())
                res= result[0].ToString();
            connection.Close();
            return res;
        }
        public static string SelectToGetOneValue(string query, params SqlParameter[] parameters)
        {
            string res = "";
            SqlConnection connection = new SqlConnection(con);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            connection.Open();
            var result = command.ExecuteReader();
            if (result.Read())
                res = result[0].ToString();
            connection.Close();
            return res;
        }
        public static DataTable DataTable(string query)
        {
            SqlConnection connection = new SqlConnection(DB.con);
            SqlCommand command = new SqlCommand(query, connection);
            DataTable DT = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(DT);
            return DT;
        }
        public static DataTable DataTable(string query, params SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(DB.con);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            DataTable DT = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(DT);
            return DT;
        }
        public static ComboBox FillCombo(string query,ComboBox combo)
        {
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            var x=command.ExecuteReader();
            while(x.Read())
            {
                combo.Items.Add(x[0].ToString());
            }
            connection.Close();
            return combo;
        }
        public static byte[] convertToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

    }
}
