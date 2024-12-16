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

            try
            {
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return monAn;
        }
        // Hàm lấy món ăn theo MaMuc
        public static List<MonAn> GetMonAnByMuc(string maMuc)
        {
            List<MonAn> monAns = new List<MonAn>();

            try
            {
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return monAns;
        }
    }
}
