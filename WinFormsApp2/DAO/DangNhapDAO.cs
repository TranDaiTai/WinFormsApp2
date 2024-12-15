using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLySuShi.DTO;

namespace QuanLySuShi.DAO
{
    public class DangNhapDAO
    {
     
        public static List<DangNhap> GetAllDangNhapKH()
        {
            List<DangNhap> dangNhapKHs = new List<DangNhap>();
            try
            {
                DataProvider.OpenConnection();
                string query = "SELECT taikhoan, matkhau FROM khachhang";

                SqlCommand command = new SqlCommand(query, DataProvider.connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DangNhap dangNhap = new DangNhap
                    {
                        TaiKhoan = reader["taikhoan"].ToString(),
                        MatKhau = reader["matkhau"].ToString()
                    };
                    dangNhapKHs.Add(dangNhap);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataProvider.CloseConnection();
            }

            return dangNhapKHs;
        }

        public static List<DangNhap> GetAllDangNhapNV()
        {
            List<DangNhap> dangNhapNVs = new List<DangNhap>();
            try
            {
                DataProvider.OpenConnection();
                string query = "SELECT taikhoan, matkhau FROM nhanvien";

                SqlCommand command = new SqlCommand(query, DataProvider.connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DangNhap dangNhap = new DangNhap
                    {
                        TaiKhoan = reader["taikhoan"].ToString(),
                        MatKhau = reader["matkhau"].ToString()
                    };
                    dangNhapNVs.Add(dangNhap);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataProvider.CloseConnection();
            }

            return dangNhapNVs;
        }
    }
}
