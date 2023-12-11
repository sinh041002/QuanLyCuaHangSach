using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        //phú

        //private string ConnectionString = "Data Source=DESKTOP-K50G8NB\\CSDL;Initial Catalog=cuahangsach;Integrated Security=True";

    //  private string ConnectionString = "Data Source=DESKTOP-2869SNJ\\MANHPHU;Initial Catalog=CuaHangSach;Integrated Security=True";


        //Sinh
        private  string ConnectionString = "Data Source=DESKTOP-MT4HM91\\SQLEXPRESS;Initial Catalog=cuahangsach1;Integrated Security=True";
        private static DataProvider instance;

       
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            set { instance = value; }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if(parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.Add(para, parameters[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                connection.Close();

            }
                return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int dt = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.Add(para, parameters[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteNonQuery();
               
                connection.Close();

            }
            return dt;
        }
        //query format: USP_Login @username , @password
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object dt = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.Add(para, parameters[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteScalar();

                connection.Close();

            }
            return dt;
        }
    }
}
