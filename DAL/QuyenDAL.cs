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
            string query = "INSERT INTO  tbl_quyen(MaQuyen,TenQuyen,QLKhachHang,QLNhanVien,QLQuyen,QLKhuyenMai,QLSach,QLHoaDon,BanHang,QLThongKe) VALUES('"+quyen.MaQuyen+"', N'"+quyen.TenQuyen+"', 1, 1, 1, 1, 1, 1, 1, 1);\r\n\r\n";
            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {

                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                ktra = true;
                sqlConnection.Close();

            }

            return ktra;
        }

    }
}
