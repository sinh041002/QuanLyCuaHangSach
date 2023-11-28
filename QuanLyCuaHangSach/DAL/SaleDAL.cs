using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SaleDAL
    {
        public SaleDAL()
        {
                
        }

        /// <summary>
        /// Lấy tất cả danh sách khuyến mại
        /// </summary>
        /// <returns></returns>
        public List<Sale> GetListSale()
        {
            string query = "SELECT * FROM tbl_sale ORDER BY TimeStart DESC";

            List<Sale> sales = new List<Sale>();

            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sales.Add(new Sale
                        (
                            reader.GetInt32(0)
                            , reader.GetString(1)
                            , reader.GetDateTime(2)
                            , reader.GetDateTime(3)
                            , reader.GetInt32(4) 
                        )
                     );
                }

                sqlConn.Close();
            }

            return sales;
        }

        /// <summary>
        /// Lấy danh sách khuyến mãi sale hợp lệ
        /// có ngày kết thúc sau ngày hiện tại.
        /// và ngày bắt đầu trước ngày hiện tại
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        public List<Sale> GetValidListSale(DateTime current)
        {
            string query = string.Format("SELECT * FROM tbl_sale WHERE TimeStart <= '{0}' AND TimeEnd > '{0}' ORDER BY TimeStart DESC", current.ToString("yyyy/MM/dd HH:mm:ss"));

            List<Sale> sales = new List<Sale>();

            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sales.Add(new Sale
                        (
                            reader.GetInt32(0)
                            , reader.GetString(1)
                            , reader.GetDateTime(2)
                            , reader.GetDateTime(3)
                            , reader.GetInt32(4)
                        )
                     );
                }

                sqlConn.Close();
            }

            return sales;
        }

        public bool Them(Sale sale)
        {
            string query = string.Format("INSERT INTO tbl_sale(id, NameSale, TimeStart, TimeEnd, SaleOff) VALUES({0}, N'{1}', '{2}', '{3}', {4})",
                    sale.Id,
                    sale.NameSale,
                    sale.TimeStart.ToString("yyyy/MM/dd HH:mm:ss"),
                    sale.TimeEnd.ToString("yyyy/MM/dd HH:mm:ss"),
                    sale.SaleOff
                );
            
            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                int result = cmd.ExecuteNonQuery();
                sqlConn.Close();
                return result == 1;
            }
        }

        public bool Sua(Sale sale)
        {
            string query = string.Format("UPDATE tbl_sale SET NameSale = N'{0}', TimeStart = '{1}', TimeEnd = '{2}', SaleOff = {3} WHERE Id = {4}",
                   sale.NameSale,
                   sale.TimeStart.ToString("yyyy/MM/dd HH:mm:ss"),
                   sale.TimeEnd.ToString("yyyy/MM/dd HH:mm:ss"),
                   sale.SaleOff,
                   sale.Id
               );

            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                int result = cmd.ExecuteNonQuery();
                sqlConn.Close();
                return result == 1;
            }
        }

        public bool Xoa(int Id)
        {
            string query = string.Format("DELETE FROM tbl_sale WHERE Id = {0}",
                   Id
               );

            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                int result = cmd.ExecuteNonQuery();
                sqlConn.Close();
                return result == 1;
            }
        }

        /// <summary>
        ///  Tìm kiếm theo tên khuyến mãi
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public List<Sale> TimKiem(string w)
        {
            string query = string.Format("SELECT * FROM tbl_sale WHERE NameSale LIKE '%{0}%' ORDER BY TimeStart DESC", w);

            List<Sale> sales = new List<Sale>();

            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sales.Add(new Sale
                        (
                            reader.GetInt32(0)
                            , reader.GetString(1)
                            , reader.GetDateTime(2)
                            , reader.GetDateTime(3)
                            , reader.GetInt32(4)
                        )
                     );
                }

                sqlConn.Close();
            }

            return sales;
        }

        public Sale GetById(int Id)
        {
            string query = string.Format("SELECT * FROM tbl_sale WHERE Id = {0}", Id);

            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    return new Sale
                        (
                            reader.GetInt32(0)
                            , reader.GetString(1)
                            , reader.GetDateTime(2)
                            , reader.GetDateTime(3)
                            , reader.GetInt32(4)
                        );
                }

                sqlConn.Close();
            }

            return null;
        }
    }
}
