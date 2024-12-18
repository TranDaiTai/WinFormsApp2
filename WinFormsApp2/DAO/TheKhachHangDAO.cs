using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySuShi.DTO;

namespace QuanLySuShi.DAO
{

    public class TheKhachHangDAO
    {
        // Thêm thẻ khách hàng mới
        public static bool AddTheKhachHang(string maThe, string loaiThe, int diemTichLuy, DateTime ngayLap, string maNhanVien, string maKhachHang)
        {
            string query = @"
            INSERT INTO TheKhachHang (MaThe, LoaiThe, DiemTichLuy, NgayLap, MaNhanVien, MaKhachHang)
            VALUES (@MaThe, @LoaiThe, @DiemTichLuy, @NgayLap, @MaNhanVien, @MaKhachHang)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaThe", maThe },
            { "@LoaiThe", loaiThe },
            { "@DiemTichLuy", diemTichLuy },
            { "@NgayLap", ngayLap },
            { "@MaNhanVien", maNhanVien },
            { "@MaKhachHang", maKhachHang }
        };

            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật thông tin thẻ khách hàng
        public static bool UpdateTheKhachHang(string maThe, string loaiThe, int diemTichLuy, string maNhanVien, string maKhachHang)
        {
            string query = @"
            UPDATE TheKhachHang
            SET LoaiThe = @LoaiThe,
                DiemTichLuy = @DiemTichLuy,
            WHERE MaThe = @MaThe";

            Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaThe", maThe },
            { "@LoaiThe", loaiThe },
            { "@DiemTichLuy", diemTichLuy }
         
        };

            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        // Xóa thẻ khách hàng
        public static bool DeleteTheKhachHang(string maThe)
        {
            string query = "DELETE FROM TheKhachHang WHERE MaThe = @MaThe";

            Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaThe", maThe }
        };

            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        // Lấy thông tin chi tiết thẻ khách hàng theo mã thẻ
        public static TheKhachHang GetTheKhachHangById(string maThe)
        {
            string query = "SELECT * FROM TheKhachHang WHERE MaThe = @MaThe";

            Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaThe", maThe }
        };

            DataTable result = DataProvider.ExecuteSelectQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new TheKhachHang(
                    row["MaThe"].ToString(),
                    row["LoaiThe"].ToString(),
                    Convert.ToInt32(row["DiemTichLuy"]),
                    Convert.ToDateTime(row["NgayLap"]),
                    row["MaNhanVien"].ToString(),
                    row["MaKhachHang"].ToString()
                );
            }

            return null;
        }
    }
}