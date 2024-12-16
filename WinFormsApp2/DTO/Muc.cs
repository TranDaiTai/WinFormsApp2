using System;

namespace QuanLySuShi.DTO
{
    public class Muc
    {
        public string MaMuc { get; set; }
        public string TenMuc { get; set; }
        public string MaThucDon { get; set; }

        // Constructor để khởi tạo đối tượng Muc từ các giá trị
        public Muc(string maMuc, string tenMuc, string maThucDon)
        {
            MaMuc = maMuc;
            TenMuc = tenMuc;
            MaThucDon = maThucDon;
        }
    }
}
