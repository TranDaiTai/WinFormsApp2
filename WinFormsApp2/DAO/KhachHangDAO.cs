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

    }
}
