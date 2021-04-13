using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Final_project
{
    class DB
    {
        
        public static Dictionary<int, string> DeptId = new Dictionary<int, string>();
        public static Dictionary<int, string> TypeId = new Dictionary<int, string>();
        public static string con = "Data Source=DESKTOP-U91N0A8;Initial Catalog=hospitall;Integrated Security=True";
        public static void Insert_Update_Delete(string query)
        {
            SqlConnection connection = new SqlConnection(con);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void Fillcombo(string query, ref Dictionary<int, string> dic, ref ComboBox combo)
        {
           
                SqlConnection connection = new SqlConnection(DB.con);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                var x = command.ExecuteReader();
                while (x.Read())
                {
                     if(!dic.ContainsKey(int.Parse(x[0].ToString())))
                    dic.Add(int.Parse(x[0].ToString()), x[1].ToString());
                    combo.Items.Add(x[1].ToString());
                }
                connection.Close();
            
            
        }
        public static void Fillcombo(string query, ref ComboBox combo)
        {

            SqlConnection connection = new SqlConnection(DB.con);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            var x = command.ExecuteReader();
            while (x.Read())
            { 
                combo.Items.Add(x[1].ToString());
            }
            connection.Close();


        }
        public static void FillDic(string query, ref Dictionary<int, string> dic)
        {

            SqlConnection connection = new SqlConnection(DB.con);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            var x = command.ExecuteReader();
            while (x.Read())
            {
                if (!dic.ContainsKey(int.Parse(x[0].ToString())))
                    dic.Add(int.Parse(x[0].ToString()), x[1].ToString());
                
            }
            connection.Close();


        }
        public static int GetId(Dictionary<int, string> dic, ComboBox combo)
        {
            int ID = 0;
            foreach (var x in dic)
            {
                if (x.Value == combo.Text)
                {
                    ID = x.Key;
                }
            }
            return ID;
        }
        public static string GetStringFromDic(int value)
        {
            foreach(var str in DB.DeptId )
            {
                if (value == str.Key)
                    return str.Value;
            }
            return null;
        }
        public static int GetIDFromDic(string value,Dictionary<int,string> dic)
        {
            foreach (var str in dic)
            {
                if (value == str.Value)
                    return str.Key;
            }
            return -1;
        }
        public static string SelectToGetOneValue(string query)
        {
            SqlConnection connection= new SqlConnection(con);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            var result=command.ExecuteReader();
            connection.Close();
            return result[0].ToString();
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
        public static List<string> FillList(string query,List<string> ls )
        {
            SqlConnection connection = new SqlConnection(DB.con);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            var result = command.ExecuteReader();
            while(result.Read())
            {
                ls.Add(result[0].ToString());
            }
            connection.Close();
            return ls;
        }
    }
}
