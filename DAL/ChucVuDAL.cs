using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAL
    {

        public ChucVuDAL() { }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<ChuVu> getListChucVu()
        {
            string query = "Select *from dbo.tbl_chucvu";

            List<ChuVu> chucvu = new List<ChuVu>();

            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {

                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    chucvu.Add( new ChuVu(dataReader.GetInt32(0),dataReader.GetString(1)));

                }

                sqlConnection.Close();
            }

            return chucvu;
        }
    }
}
