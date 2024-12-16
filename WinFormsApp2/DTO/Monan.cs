using System;

namespace QuanLySuShi.DTO
{
    public class MonAn
    {
        public string MaMonAn { get; set; }  // Mã món ăn
        public string TenMonAn { get; set; } // Tên món ăn
        public decimal GiaTien { get; set; } // Giá tiền
        public bool HoTroGiao { get; set; }  // Hỗ trợ giao
        public string MaMuc { get; set; }    // Mã mức (Liên kết với bảng mức nếu có)

        // Constructor mặc định
        public MonAn() { }

        // Constructor có tham số để khởi tạo từ dữ liệu
        public MonAn(string maMonAn, string tenMonAn, decimal giaTien, bool hoTroGiao, string maMuc)
        {
            MaMonAn = maMonAn;
            TenMonAn = tenMonAn;
            GiaTien = giaTien;
            HoTroGiao = hoTroGiao;
            MaMuc = maMuc;
        }

        // Phương thức khởi tạo từ DataRow (có thể sử dụng để chuyển dữ liệu từ DataTable thành đối tượng)
        public MonAn(System.Data.DataRow row)
        {
            MaMonAn = row["MaMonAn"].ToString();
            TenMonAn = row["TenMonAn"].ToString();
            GiaTien = Convert.ToDecimal(row["GiaTien"]);
            HoTroGiao = Convert.ToBoolean(row["HoTroGiao"]);
            MaMuc = row["MaMuc"].ToString();
        }
    }
}
