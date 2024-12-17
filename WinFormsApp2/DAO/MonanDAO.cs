using System;
using System.Data;
using System.Data.SqlClient;
using QuanLySuShi.DTO;

namespace QuanLySuShi
{
    public class MonAnDAO
    {
        // Hàm lấy món ăn theo mã món ăn
        public static MonAn GetMonAnByMaMonAn(string maMonAn)
        {
            MonAn monAn = null;

            // Câu truy vấn SQL
            string query = "SELECT * FROM MonAn WHERE MaMonAn = @MaMonAn";

            // Tạo tham số cho câu truy vấn
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@MaMonAn", maMonAn);

            // Thực hiện truy vấn và lấy dữ liệu
            DataTable result = DataProvider.ExecuteSelectQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                // Lấy thông tin từ DataRow và tạo đối tượng MonAn
                DataRow row = result.Rows[0];
                monAn = new MonAn(row["MaMonAn"].ToString(),
                                    row["TenMonAn"].ToString(),
                                    Convert.ToDecimal(row["GiaTien"]),
                                    Convert.ToBoolean(row["HoTroGiao"]),
                                    row["MaMuc"].ToString());
            }
           
            return monAn;
        }
        // Hàm lấy món ăn theo MaMuc
        public static List<MonAn> GetMonAnByMuc(string maMuc)
        {
            List<MonAn> monAns = new List<MonAn>();

            // Câu truy vấn SQL để lấy món ăn theo MaMuc
            string query = "SELECT * FROM MonAn WHERE MaMuc = @MaMuc";

            // Tạo tham số cho câu truy vấn
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@MaMuc", maMuc);

            // Thực hiện truy vấn và lấy dữ liệu
            DataTable result = DataProvider.ExecuteSelectQuery(query, parameters);

            // Nếu có dữ liệu, chuyển đổi từng dòng thành đối tượng MonAn
            foreach (DataRow row in result.Rows)
            {
                MonAn monAn = new MonAn(
                    row["MaMonAn"].ToString(),
                    row["TenMonAn"].ToString(),
                    decimal.Parse(row["GiaTien"].ToString()),
                    Convert.ToBoolean(row["HoTroGiao"]),
                    row["MaMuc"].ToString()
                );
                monAns.Add(monAn);
            }
          
            return monAns;
        }
        public static DataTable GetMonAnDaBanFromTo(DateTime from, DateTime to, string chinhanh, string tenmonan = null)
        {
            string query = @"
            SELECT DISTINCT 
            MA.MaMonAn, 
            MA.TenMonAn, 
            (
                SELECT COUNT(*)
                FROM ChiTietPhieuDat AS ctpdtemp
                INNER JOIN HoaDon hdtemp ON hdtemp.MaPhieu = ctpdtemp.MaPhieu
                INNER JOIN MonAn matemp ON matemp.MaMonAn = ctpdtemp.MaMonAn
                WHERE 
                    hdtemp.NgayLap BETWEEN @FromDate AND @ToDate
                    AND hdtemp.MaChiNhanh = @MaChiNhanh
                    AND matemp.MaMonAn = MA.MaMonAn 
            ) AS SoLuong,
            m.tenmuc AS TenMuc,
            td.tenthucdon AS TenThucDon
        FROM 
            HoaDon HD
            INNER JOIN ChiTietPhieuDat CT ON HD.MaPhieu = CT.MaPhieu
            INNER JOIN MonAn MA ON CT.MaMonAn = MA.MaMonAn
            INNER JOIN Muc m ON m.Mamuc = MA.MaMuc
            INNER JOIN thucdon td ON td.mathucdon = m.Mathucdon
        WHERE 
            HD.NgayLap BETWEEN @FromDate AND @ToDate
            AND HD.MaChiNhanh = @MaChiNhanh
        ";

             Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@FromDate", from },
                { "@ToDate", to },
                { "@MaChiNhanh", chinhanh }
               
            };
            if (!string.IsNullOrEmpty(tenmonan))
            {
                query += " And MA.TenMonAn LIKE @TenMonAn";
                parameters.Add("@TenMonAn", $"%{tenmonan}%");
            }

            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

    }
}
