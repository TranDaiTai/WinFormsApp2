using QuanLySuShi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DAO
{
    public class UuDaiDAO
    {
        // Thêm ưu đãi vào cơ sở dữ liệu
        public bool AddUuDai(UuDai uuDai)
        {
            string query = "INSERT INTO UuDai (MaUuDai, GiamGia, ChuongTrinh, TangSanPham, UuDaiChietKhau, LoaiTheApDung, NgayBatDau, NgayKetThuc) " +
                           "VALUES (@MaUuDai, @GiamGia, @ChuongTrinh, @TangSanPham, @UuDaiChietKhau, @LoaiTheApDung, @NgayBatDau, @NgayKetThuc)";

            // Định nghĩa tham số cho truy vấn
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaUuDai", uuDai.MaUuDai },
                { "@GiamGia", uuDai.GiamGia ?? (object)DBNull.Value },
                { "@ChuongTrinh", uuDai.ChuongTrinh ?? (object)DBNull.Value },
                { "@LoaiTheApDung", uuDai.LoaiTheApDung ?? (object)DBNull.Value },
                { "@NgayBatDau", uuDai.NgayBatDau },
                { "@NgayKetThuc", uuDai.NgayKetThuc }
            };

            // Thực thi truy vấn và trả về kết quả
            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        // Lấy ưu đãi theo mã ưu đãi
        public UuDai GetUuDaiById(string maUuDai)
        {
            string query = "SELECT * FROM UuDai WHERE MaUuDai = @MaUuDai";

            // Định nghĩa tham số cho truy vấn
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaUuDai", maUuDai }
            };

            // Thực thi truy vấn và lấy dữ liệu
            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            // Nếu tìm thấy dữ liệu, trả về đối tượng UuDai
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return UuDai.FromDataRow(dataTable.Rows[0]);
            }

            return null; // Nếu không tìm thấy, trả về null
        }

        // Lấy tất cả ưu đãi
        public List<UuDai> GetAllUuDais()
        {
            string query = "SELECT * FROM UuDai";
            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, null);

            List<UuDai> uuDais = new List<UuDai>();

            // Nếu có dữ liệu, chuyển đổi thành danh sách các đối tượng UuDai
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    uuDais.Add(UuDai.FromDataRow(row));
                }
            }

            return uuDais;
        }
    }
}
