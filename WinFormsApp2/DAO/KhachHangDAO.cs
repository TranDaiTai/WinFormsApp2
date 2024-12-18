using QuanLySuShi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DAO
{
    internal class KhachHangDAO
    {
        public static KhachHang GetKhachHangByTaiKhoan(string taiKhoan)
        {
            string query = "SELECT * FROM KhachHang WHERE TaiKhoan = @TaiKhoan";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@TaiKhoan", taiKhoan },

            };

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return KhachHang.FromDataRow(row);  // Sử dụng phương thức FromDataRow để tạo đối tượng từ DataRow
            }
            return null;
        }
        public static string GetMaxMakhachhang()
        {
            // Câu truy vấn SQL để lấy giá trị lớn nhất của phần số trong mã phiếu
            string query = @"
                SELECT
                    MAX(CAST(SUBSTRING(MaKhachHang, 3, LEN(MaKhachHang)-2) AS INT)) AS MaxNum
                FROM KhachHang
                WHERE MaKhachHang LIKE 'KH%'
            ";

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query);

            if (dataTable != null && dataTable.Rows.Count > 0)  
            {
                int maxNum = Convert.ToInt32(dataTable.Rows[0]["MaxNum"]);

                // Tạo mã phiếu tiếp theo bằng cách tăng giá trị maxNum
                string newPhieu = "KH" + (maxNum + 1); // Đảm bảo định dạng 3 chữ số
                return newPhieu;
            }
            else
            {
                // Nếu không có phiếu nào, trả về mã phiếu đầu tiên là PD001
                return "KH001";
            }
        }
        public static bool CreatKhachHang(KhachHang khachHang)
        {
            string query = "EXEC sp_CreateKhachHang @MaKhachHang,@HoTen,@SoDienThoai,@Email,@CCCD,@GioiTinh,@MatKhau,@TaiKhoan";
            var parameters = new Dictionary<string, object>
            {
                { "@MaKhachHang", khachHang.MaDinhDanh },
                { "@HoTen", (object)khachHang.HoTen ?? DBNull.Value },
                { "@SoDienThoai", (object)khachHang.SoDienThoai?? DBNull.Value },
                { "@Email", (object)khachHang.Email?? DBNull.Value },
                { "@CCCD", (object)khachHang.CCCD ?? DBNull.Value},
                { "@GioiTinh", string.IsNullOrEmpty(khachHang.GioiTinh) ? DBNull.Value : khachHang.GioiTinh },
                { "@TaiKhoan", (object)khachHang.TaiKhoan ?? DBNull.Value},
                { "@MatKhau",(object) khachHang.MatKhau ?? DBNull.Value}
            };

            // Gọi hàm thực thi câu lệnh SQL
            return DataProvider.ExecuteNonQuery(query, parameters);
        }
    }
}
