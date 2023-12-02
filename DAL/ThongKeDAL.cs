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
    public class ThongKeDAL
    {
        public ThongKeDAL() { }

        public List<TKDoanhThuViewModel> LayDoanhThu(DateTime from, DateTime to)
        {
            List<TKDoanhThuViewModel> ds = new List<TKDoanhThuViewModel>();
            
            if (from > to)
                return ds;

            string query = string.Format(@"SELECT CAST(NgayXuat AS DATE) AS Ngay, COUNT(DISTINCT tbl_hoadon.MaHoaDon) AS SLDonHang, SUM(ThanhTien) AS DoanhThu
                                            FROM tbl_hoadon INNER JOIN tbl_chitiethoadon ON tbl_chitiethoadon.MaHoaDon = tbl_hoadon.MaHoaDon 
                                            WHERE CAST(NgayXuat AS DATE) >= '{0}' AND CAST(NgayXuat AS DATE) <= '{1}'
                                            GROUP BY CAST(NgayXuat AS DATE)
                                            ORDER BY CAST(NgayXuat AS DATE) ASC"
                            , from.ToString("yyyy/MM/dd")
                            , to.ToString("yyyy/MM/dd"));

            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new TKDoanhThuViewModel(
                        reader.GetDateTime(0),
                        reader.GetInt32(1),
                        reader.GetDouble(2) 
                        )
                     );
                }

                sqlConn.Close();
            }

            return ds;
        }

        public List<TKSPBanChayViewModel> LaySPBanChay(DateTime from, DateTime to)
        {
            List<TKSPBanChayViewModel> ds = new List<TKSPBanChayViewModel>();
            
            if (from > to)
                return ds;
            
            string query = string.Format(@"SELECT tbl_sach.MaSach, tbl_sach.TenSach , SUM(tbl_sach.SoLuong) AS SLBan FROM tbl_sach INNER JOIN tbl_chitiethoadon
                                        ON tbl_chitiethoadon.MaSach = tbl_sach.MaSach
                                        INNER JOIN tbl_hoadon 
                                        ON tbl_hoadon.MaHoaDon = tbl_chitiethoadon.MaHoaDon
                                        WHERE CAST(NgayXuat AS DATE) >= '{0}' AND CAST(NgayXuat AS DATE) <= '{1}'
                                        GROUP BY tbl_sach.MaSach, tbl_sach.TenSach
                                        ORDER BY SLBan desc"
                            , from.ToString("yyyy/MM/dd")
                            , to.ToString("yyyy/MM/dd"));

            using (SqlConnection sqlConn = SqlConnectionData.Connect())
            {

                sqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ds.Add(new TKSPBanChayViewModel(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetDouble(2)
                        )
                     );
                }

                sqlConn.Close();
            }

            return ds;
        }
    }
}
