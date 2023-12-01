using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuyenDAL
    {
        public QuyenDAL() { }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<QuyenDTO> getListQuyen()
        {
            string query = "Select *from dbo.tbl_quyen";

            List<QuyenDTO> Quyens = new List<QuyenDTO>();

            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {

                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Quyens.Add(new QuyenDTO(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetInt32(3), dataReader.GetInt32(4), dataReader.GetInt32(5), dataReader.GetInt32(6), dataReader.GetInt32(7), dataReader.GetInt32(8), dataReader.GetInt32(9)));
                   
                }

                sqlConnection.Close();
            }

            return Quyens;
        }
        public Boolean themQuyen(QuyenDTO quyen)
        {
            Boolean ktra = false;
            try
            {
                
                string query = "INSERT INTO  tbl_quyen(MaQuyen,TenQuyen,QLKhachHang,QLNhanVien,QLQuyen,QLKhuyenMai,QLSach,QLHoaDon,BanHang,QLThongKe) VALUES('" + quyen.MaQuyen + "', N'" + quyen.TenQuyen + "'" +
               ", " + quyen.QLKhachHang + "," + quyen.QLNhanVien + "," + quyen.QLQuyen + "," + quyen.QLKhuyenMai + ", " + quyen.QLSach + ", " + quyen.QLHoaDon + ", " + quyen.BanHang + ", " + quyen.QLThongKe + ");\r\n\r\n";
                using (SqlConnection sqlConnection = SqlConnectionData.Connect())
                {

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();

                    ktra = true;
                    sqlConnection.Close();

                }
            }catch (Exception ex)
            {
                return false;
            }

            return ktra;
        }

        public Boolean suaQuyen(QuyenDTO quyen)
        {
            Boolean ktra = false;
            try
            {

                //string query1 = "UPDATE tbl_quyen\r\n" +
                //    "SET TenQuyen = N'" + quyen.TenQuyen + "', QLKhachHang= " + quyen.QLKhachHang + ",QLNhanVien=" + quyen.QLNhanVien + "" +
                //    ",QLQuyen= " + quyen.QLQuyen + ",QLKhuyenMai=" + quyen.QLKhuyenMai + ",QLSach=" + quyen.QLSach + ",QLHoaDon=" + quyen.QLHoaDon + "," +
                //    "BanHang= " + quyen.BanHang + ",QLThongKe=" + quyen.QLThongKe + "\r\n" +
                //    "WHERE MaQuyen = 4;";


                string query = "UPDATE tbl_quyen\r\n" +
                 "SET TenQuyen = N'" + quyen.TenQuyen + "',QLKhachHang = " + quyen.QLKhachHang + ",QLNhanVien = " + quyen.QLNhanVien + "," +
                 "QLQuyen = " + quyen.QLQuyen + ",QLKhuyenMai = " + quyen.QLKhuyenMai + ",QLSach = " + quyen.QLSach + ",QLHoaDon = " + quyen.QLHoaDon + "," +
                 "BanHang = " + quyen.BanHang + ", " + "QLThongKe = " + quyen.QLThongKe + " "+
                 "\r\nWHERE MaQuyen = " + quyen.MaQuyen + ";";




                using (SqlConnection sqlConnection = SqlConnectionData.Connect())
                {

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();

                    ktra = true;
                    sqlConnection.Close();

                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return ktra;
        }


        public Boolean xoaQuyen(int maQuyen)
        {
            Boolean ktra = false;
            try
            {
                string query = "DELETE FROM dbo.tbl_quyen WHERE MaQuyen = '" + maQuyen + "' ;";
                using (SqlConnection sqlConnection = SqlConnectionData.Connect())
                {

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();

                    ktra = true;
                    sqlConnection.Close();

                }
            }
            catch 
            {
                ktra = false;
            }
            return ktra;
        }

    }
}
