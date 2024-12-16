using QuanLySuShi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DAO
{
    public class NhanVienDAO
    {
        // Lấy thông tin nhân viên theo mã nhân viên
        public static NhanVien GetNhanVienByMaNhanVien(string maNhanVien)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaNhanVien", maNhanVien }
            };

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return NhanVien.FromDataRow(row);  // Sử dụng phương thức FromDataRow để tạo đối tượng từ DataRow
            }
            return null;
        }

        public static NhanVien GetNhanVienByTaiKhoan(string taiKhoan)
        {
            string query = "SELECT * FROM NhanVien WHERE TaiKhoan = @TaiKhoan";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@TaiKhoan", taiKhoan },
             
            };

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return NhanVien.FromDataRow(row);  // Sử dụng phương thức FromDataRow để tạo đối tượng từ DataRow
            }
            return null;
        }

        public static List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string query = "SELECT * FROM NhanVien";

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query);

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NhanVien nhanVien = NhanVien.FromDataRow(row);  // Sử dụng phương thức FromDataRow để tạo đối tượng từ DataRow
                    nhanViens.Add(nhanVien);
                }
            }

            return nhanViens;
        }
    }
}
