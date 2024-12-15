using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLySuShi.DTO
{
    public class Phieudatmon
    {
        public string MaPhieu { get; set; } //   primary key
        public DateTime? NgayLap { get; set; } // [date] NULL
        public string LoaiPhieu { get; set; } // [nvarchar](50) NULL
        public string NhanVienLap { get; set; } //   NULL
        public string MaKhachHang { get; set; } //   NOT NULL
        public string MaChiNhanh { get; set; } //   NOT NULL

        // Constructor
        public Phieudatmon(string maPhieu, string maKhachHang, string maChiNhanh)
        {
            MaPhieu = maPhieu;
            MaKhachHang = maKhachHang;
            MaChiNhanh = maChiNhanh;
        }

        // Optional constructor with all properties
        public Phieudatmon(string maPhieu, DateTime? ngayLap, string loaiPhieu, string nhanVienLap, string maKhachHang, string maChiNhanh)
        {
            MaPhieu = maPhieu;
            NgayLap = ngayLap;
            LoaiPhieu = loaiPhieu;
            NhanVienLap = nhanVienLap;
            MaKhachHang = maKhachHang;
            MaChiNhanh = maChiNhanh;
        }

        // Default constructor
        public Phieudatmon() { }
    }
}
