using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DTO
{
    public class DangNhap
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public DangNhap() { }
        public DangNhap(string taikhoan, string matkhau)
        {
            TaiKhoan = taikhoan;
            MatKhau = matkhau;
        }
    }
}
