﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TacGiaDAL
    {
        public static DataTable GetAllTacGia()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = "select * from tbl_tacgia";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
        public static void UpdateTacGia(TacGia tacGia)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open ();
                string query = @"update tbl_tacgia set
                                tentacgia = @tentacgia,
                                motatacgia = @motatacgia
                                where matacgia = @matacgia";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@tentacgia", SqlDbType.NVarChar).Value = tacGia.TenTacGia;
                command.Parameters.Add("@motatacgia", SqlDbType.NVarChar).Value = tacGia.MoTaTacGia;
                command.Parameters.Add("@matacgia", SqlDbType.NVarChar).Value = tacGia.MaTacGia;
                command.ExecuteNonQuery();
            }    
        }
        public static void XoaTacGia(string ma)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = "delete from tbl_tacgia where matacgia = @matacgia";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@matacgia", SqlDbType.NVarChar).Value = ma;
                sqlCommand.ExecuteNonQuery ();
            }    
        }
    }
}
