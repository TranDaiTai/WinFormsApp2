using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DTO
{
    internal class Chitietphieudat
    {
        public string MaMonAn { get; set; } // Primary key (part 1)
        public string MaPhieu { get; set; } // Primary key (part 2)
        public int SoLuong { get; set; } // NOT NULL
        public decimal Gia { get; set; } // NOT NULL (money in SQL)

        // Constructor
        public Chitietphieudat(string maMonAn, string maPhieu, int soLuong, decimal gia)
        {
            MaMonAn = maMonAn;
            MaPhieu = maPhieu;
            SoLuong = soLuong;
            Gia = gia;
        }

        // Default constructor
        public Chitietphieudat() { }
    }
}
