using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DTO
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }       // Mã nhân viên (PK)
        public string HoTen { get; set; }           // Họ tên nhân viên
        public DateTime? NgaySinh { get; set; }     // Ngày sinh (cho phép null)
        public string GioiTinh { get; set; }        // Giới tính (cho phép null)
        public DateTime NgayVaoLam { get; set; }    // Ngày vào làm
        public DateTime? NgayKetThuc { get; set; }  // Ngày kết thúc làm việc (cho phép null)
        public string MaBoPhan { get; set; }        // Mã bộ phận (FK)
        public string MaChiNhanh { get; set; }      // Mã chi nhánh (FK)
        public string DiaChi { get; set; }          // Địa chỉ (cho phép null)
        public string TaiKhoan { get; set; }        // Tài khoản (unique)
        public string MatKhau { get; set; }         // Mật khẩu

        // Constructor không tham số
        public NhanVien() { }

        // Constructor với tham số
        public NhanVien(string maNhanVien, string hoTen, DateTime? ngaySinh, string gioiTinh,
                        DateTime ngayVaoLam, DateTime? ngayKetThuc, string maBoPhan,
                        string maChiNhanh, string diaChi, string taiKhoan, string matKhau)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            NgayVaoLam = ngayVaoLam;
            NgayKetThuc = ngayKetThuc;
            MaBoPhan = maBoPhan;
            MaChiNhanh = maChiNhanh;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }
        public static NhanVien FromDataRow(DataRow row)
        {
            return new NhanVien
            {
                MaNhanVien = row["MaNhanVien"].ToString(),
                HoTen = row["HoTen"].ToString(),
                NgaySinh = row["NgaySinh"] as DateTime?,
                GioiTinh = row["GioiTinh"].ToString(),
                NgayVaoLam = Convert.ToDateTime(row["NgayVaoLam"]),
                NgayKetThuc = row["NgayKetThuc"] as DateTime?,
                MaBoPhan = row["MaBoPhan"].ToString(),
                MaChiNhanh = row["MaChiNhanh"].ToString(),
                DiaChi = row["DiaChi"].ToString(),
                TaiKhoan = row["TaiKhoan"].ToString(),
                MatKhau = row["MatKhau"].ToString()
            };
        }
    }
}
