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
    public class MucDAO
    {
        // Hàm lấy tất cả các mục theo mã thực đơn
        public static List<Muc> GetMucsByMaThucDon(string maThucDon)
        {
            List<Muc> mucs = new List<Muc>();

            try
            {
                // Câu truy vấn SQL
                string query = "SELECT * FROM Muc WHERE MaThucDon = @MaThucDon";

                // Tạo tham số cho câu truy vấn
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaThucDon", maThucDon);

                // Thực hiện truy vấn và lấy dữ liệu
                DataTable result = DataProvider.ExecuteSelectQuery(query, parameters);

                // Nếu có dữ liệu, chuyển đổi từng dòng thành đối tượng Muc
                foreach (DataRow row in result.Rows)
                {
                    Muc muc = new Muc(row["MaMuc"].ToString(),
                                      row["TenMuc"].ToString(),
                                      row["MaThucDon"].ToString());
                    mucs.Add(muc);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mucs;
        }

        // Hàm lấy mục theo mã mục
        public static Muc GetMucByMaMuc(string maMuc)
        {
            Muc muc = null;

            try
            {
                // Câu truy vấn SQL
                string query = "SELECT * FROM Muc WHERE MaMuc = @MaMuc";

                // Tạo tham số cho câu truy vấn
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaMuc", maMuc);

                // Thực hiện truy vấn và lấy dữ liệu
                DataTable result = DataProvider.ExecuteSelectQuery(query, parameters);

                // Nếu có dữ liệu, chuyển đổi dòng đầu tiên thành đối tượng Muc
                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    muc = new Muc(row["MaMuc"].ToString(),
                                  row["TenMuc"].ToString(),
                                  row["MaThucDon"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return muc;
        }
    }
}
