using QuanLySuShi.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DAO
{
    public class ThucDonDAO
    {
        // Hàm lấy tất cả các thực đơn
        public static List<ThucDon> GetAllThucDon()
        {
            List<ThucDon> thucDons = new List<ThucDon>();

            try
            {
                // Câu truy vấn SQL
                string query = "SELECT * FROM ThucDon";

                // Thực hiện truy vấn và lấy dữ liệu
                DataTable result = DataProvider.ExecuteSelectQuery(query);

                // Nếu có dữ liệu, chuyển đổi từng dòng thành đối tượng ThucDon
                foreach (DataRow row in result.Rows)
                {
                    ThucDon thucDon = new ThucDon(
                        row["MaThucDon"].ToString(),
                        row["TenThucDon"].ToString(),
                        row["KhuVuc"].ToString()
                    );
                    thucDons.Add(thucDon);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return thucDons;
        }

        // Hàm lấy thực đơn theo mã thực đơn
        public static ThucDon GetThucDonByMaThucDon(string maThucDon)
        {
            ThucDon thucDon = null;

            try
            {
                // Câu truy vấn SQL
                string query = "SELECT * FROM ThucDon WHERE MaThucDon = @MaThucDon";

                // Tạo tham số cho câu truy vấn
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaThucDon", maThucDon);

                // Thực hiện truy vấn và lấy dữ liệu
                DataTable result = DataProvider.ExecuteSelectQuery(query, parameters);

                // Nếu có dữ liệu, chuyển đổi dòng đầu tiên thành đối tượng ThucDon
                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    thucDon = new ThucDon(
                        row["MaThucDon"].ToString(),
                        row["TenThucDon"].ToString(),
                        row["KhuVuc"].ToString()
                    );
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return thucDon;
        }
    }
}
