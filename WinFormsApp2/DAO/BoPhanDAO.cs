using QuanLySuShi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DAO
{
    public class BoPhanDAO
    {
        // Lấy tất cả bộ phận
        public static List<BoPhan> GetAllBoPhan()
        {
            List<BoPhan> boPhans = new List<BoPhan>();
            string query = "SELECT * FROM BoPhan";

            // Thực hiện truy vấn và lấy kết quả
            DataTable dataTable = DataProvider.ExecuteSelectQuery(query);

            // Chuyển đổi các dòng dữ liệu thành danh sách đối tượng BoPhan
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    BoPhan boPhan = BoPhan.FromDataRow(row);
                    boPhans.Add(boPhan);
                }
            }

            return boPhans;
        }

        // Lấy thông tin bộ phận theo Mã Bộ Phận
        public static BoPhan GetBoPhanByMaBoPhan(string maBoPhan)
        {
            string query = "SELECT * FROM BoPhan WHERE MaBoPhan = @MaBoPhan";

            // Định nghĩa tham số
            Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaBoPhan", maBoPhan }
        };

            // Thực hiện truy vấn và lấy kết quả
            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return BoPhan.FromDataRow(dataTable.Rows[0]);  // Trả về bộ phận tìm thấy
            }

            return null; // Trả về null nếu không tìm thấy
        }

        // Thêm mới một bộ phận
        public static bool InsertBoPhan(BoPhan boPhan)
        {
            string query = "INSERT INTO BoPhan (MaBoPhan, TenBoPhan, Luong) VALUES (@MaBoPhan, @TenBoPhan, @Luong)";

            // Định nghĩa tham số
            Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaBoPhan", boPhan.MaBoPhan },
            { "@TenBoPhan", boPhan.TenBoPhan },
            { "@Luong", boPhan.Luong }
        };

            // Thực hiện câu lệnh INSERT
            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật thông tin bộ phận
        public static bool UpdateBoPhan(BoPhan boPhan)
        {
            string query = "UPDATE BoPhan SET TenBoPhan = @TenBoPhan, Luong = @Luong WHERE MaBoPhan = @MaBoPhan";

            // Định nghĩa tham số
            Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "@MaBoPhan", boPhan.MaBoPhan },
            { "@TenBoPhan", boPhan.TenBoPhan },
            { "@Luong", boPhan.Luong }
        };

            // Thực hiện câu lệnh UPDATE
            return DataProvider.ExecuteNonQuery(query, parameters);
        }


    }
}
