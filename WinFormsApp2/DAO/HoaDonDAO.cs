using QuanLySuShi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DAO
{
    public class HoaDonDAO
    {
        // Thêm hóa đơn mới vào cơ sở dữ liệu
        public static bool AddHoaDon(string mahoadon , string machinhanh,string maphieu,decimal tongtien,UuDai uuDai)
        {
            string query = "INSERT INTO HoaDon (MaHoaDon, NgayLap, TongTien, SoTienGiamGia, MaUuDai, MaPhieu, MaChiNhanh) " +
                           "VALUES (@MaHoaDon, @NgayLap, @TongTien, @SoTienGiamGia, @MaUuDai, @MaPhieu, @MaChiNhanh)";
            DateTime NgayLap = DateTime.Now;
            // Định nghĩa tham số cho truy vấn
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaHoaDon", mahoadon },
                { "@NgayLap", NgayLap },
                { "@TongTien", tongtien },
                { "@SoTienGiamGia", uuDai?.GiamGia ?? (object)DBNull.Value },  // Kiểm tra uuDai có null không
                { "@MaUuDai", uuDai?.MaUuDai ?? (object)DBNull.Value },  // Kiểm tra uuDai có null không
                { "@MaPhieu", maphieu },
                { "@MaChiNhanh", machinhanh }
            };

            // Thực thi truy vấn và trả về kết quả
            return DataProvider.ExecuteNonQuery(query, parameters);
        }


        // Lấy hóa đơn theo mã hóa đơn
        public HoaDon GetHoaDonById(string maHoaDon)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHoaDon = @MaHoaDon";

            // Định nghĩa tham số cho truy vấn
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaHoaDon", maHoaDon }
            };

            // Thực thi truy vấn và lấy dữ liệu
            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            // Nếu tìm thấy dữ liệu, trả về đối tượng HoaDon
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return HoaDon.FromDataRow(dataTable.Rows[0]);
            }

            return null; // Nếu không tìm thấy, trả về null
        }

        // Lấy tất cả hóa đơn
        public List<HoaDon> GetAllHoaDons()
        {
            string query = "SELECT * FROM HoaDon";
            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, null);

            List<HoaDon> hoaDons = new List<HoaDon>();

            // Nếu có dữ liệu, chuyển đổi thành danh sách các đối tượng HoaDon
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    hoaDons.Add(HoaDon.FromDataRow(row));
                }
            }

            return hoaDons;
        }
        public static string GetMaxHoaDon()
        {
            // Câu truy vấn SQL để lấy giá trị lớn nhất của phần số trong mã phiếu
            string query = @"
                SELECT TOP 1 
                    MAX(CAST(SUBSTRING(mahoadon, 3, LEN(mahoadon)) AS INT)) AS MaxNum
                FROM hoadon
                WHERE mahoadon LIKE 'HD%'
                GROUP BY mahoadon
                ORDER BY MaxNum DESC;
            ";

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                int maxNum = Convert.ToInt32(dataTable.Rows[0]["MaxNum"]);

                // Tạo mã phiếu tiếp theo bằng cách tăng giá trị maxNum
                string newPhieu = "HD" + (maxNum + 1); // Đảm bảo định dạng 3 chữ số
                return newPhieu;
            }
            else
            {
                // Nếu không có phiếu nào, trả về mã phiếu đầu tiên là PD001
                return "HD001";
            }
        }
        public static List<HoaDon> GetHoaDonFromTo(DateTime fromDate, DateTime toDate,string machinhanh)
        {
            string query = @"SELECT Mahoadon, NgayLap,TongTien,SoTienGiamGia,MaUuDai,MaPhieu,machinhanh
                             FROM HoaDon
                             WHERE NgayLap BETWEEN @FromDate AND @ToDate and Hoadon.machinhanh = @machinhanh";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@FromDate", fromDate },
                { "@ToDate", toDate },
                { "@machinhanh", machinhanh }

            };

            // Thực thi truy vấn và lấy kết quả
            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            // Danh sách kết quả trả về
            List<HoaDon> hoaDonList = new List<HoaDon>();

            // Chuyển đổi từng hàng trong DataTable thành đối tượng HoaDon
            foreach (DataRow row in dataTable.Rows)
            {
                HoaDon hoaDon = HoaDon.FromDataRow(row);
                hoaDonList.Add(hoaDon);
            }

            return hoaDonList;
        }

    }
}
