using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DTO
{
    internal class Phieudatmontaiquan
    {
        public string MaPhieu { get; set; } // primary key
        public int? SoLuongKhach { get; set; } // [int] NULL
        public string MaBan { get; set; } // [char](10) NULL
        public DateTime? NgayDat { get; set; } // [date] NULL

        // Constructor
        public Phieudatmontaiquan(string maPhieu)
        {
            MaPhieu = maPhieu;
        }

        // Optional constructor with all properties
        public Phieudatmontaiquan(string maPhieu, int? soLuongKhach, string maBan, DateTime? ngayDat)
        {
            MaPhieu = maPhieu;
            SoLuongKhach = soLuongKhach;
            MaBan = maBan;
            NgayDat = ngayDat;
        }

        // Default constructor
        public Phieudatmontaiquan() { }
    }
}
