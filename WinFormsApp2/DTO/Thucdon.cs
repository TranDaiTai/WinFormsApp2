using System;

namespace QuanLySuShi.DTO
{
    public class ThucDon
    {
        public string MaThucDon { get; set; }
        public string TenThucDon { get; set; }
        public string KhuVuc { get; set; }

        // Constructor để khởi tạo đối tượng ThucDon từ các giá trị
        public ThucDon(string maThucDon, string tenThucDon, string khuVuc)
        {
            MaThucDon = maThucDon;
            TenThucDon = tenThucDon;
            KhuVuc = khuVuc;
        }
    }
}
