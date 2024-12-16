using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using QuanLySuShi.DTO;

namespace QuanLySuShi.DAO
{
    internal class PhieudatmonDAO
    {
        public static string GetPhieuDatMonByTableId(string id)
        {
            var query = "SELECT pdm.maphieu " +
                        "FROM PhieuDatMon pdm " +
                        "LEFT JOIN HoaDon hd ON pdm.MaPhieu = hd.MaPhieu " +
                        "JOIN PhieuDatMonTrucTiep tt ON pdm.MaPhieu = tt.MaPhieu " +
                        "WHERE hd.MaHoaDon IS NULL AND tt.maban = @TableId";

            var parameters = new Dictionary<string, object>
            {
                { "@TableId", id }
            };

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["maphieu"]?.ToString(); // Sử dụng ?.ToString() để tránh lỗi null.
            }

            return null; // Trả về null nếu không có dữ liệu.
        }
        // Hàm tạo phiếu đặt món mới
        public static bool CreatePhieuDatMon(string maNhanVien, string machinhanh,string maPhieuMoi)
        {
            var query = "INSERT INTO PhieuDatMon (MaPhieu, NhanVienLap, NgayLap, MaChiNhanh, LoaiPhieu) " +
                        "VALUES (@MaPhieu, @NhanVienLap, @NgayLap, @MaChiNhanh, @LoaiPhieu);";

            DateTime ngayDat = DateTime.Now;

            string hinhThuc = "Trực Tiếp";  // Giả sử đây là giá trị cố định cho hình thức trực tiếp

            var parameters = new Dictionary<string, object>
            {
                { "@MaPhieu", maPhieuMoi },
                { "@NhanVienLap", maNhanVien },
                { "@NgayLap", ngayDat },
                { "@MaChiNhanh", machinhanh },
                { "@LoaiPhieu", hinhThuc }
            };

            // Thực thi câu lệnh SQL và trả về kết quả
            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        public static string GetMaxPhieuDatMon()
        {
            // Câu truy vấn SQL để lấy giá trị lớn nhất của phần số trong mã phiếu
            string query = @"
        SELECT TOP 1 
            MAX(CAST(SUBSTRING(MaPhieu, 3, LEN(MaPhieu)) AS INT)) AS MaxNum
        FROM PhieuDatMon
        WHERE MaPhieu LIKE 'PD%'
        GROUP BY MaPhieu
        ORDER BY MaxNum DESC;
    ";

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                int maxNum = Convert.ToInt32(dataTable.Rows[0]["MaxNum"]);

                // Tạo mã phiếu tiếp theo bằng cách tăng giá trị maxNum
                string newPhieu = "PD" + (maxNum + 1); // Đảm bảo định dạng 3 chữ số
                return newPhieu;
            }
            else
            {
                // Nếu không có phiếu nào, trả về mã phiếu đầu tiên là PD001
                return "PD001";
            }
        }

    }


} 

