using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DTO
{
    internal class Phieudatmongiaodi
    {
        public string MaPhieu { get; set; } //   primary key
        public DateTime? NgayGio { get; set; } // [datetime] NULL
        public string TinhTrang { get; set; } // [nvarchar](10) NOT NULL
        public int? Phi { get; set; } // [int] NULL
        public string DiaChi { get; set; } // [nvarchar](100) NOT NULL

        // Constructor
        public Phieudatmongiaodi(string maPhieu, string tinhTrang, string diaChi)
        {
            MaPhieu = maPhieu;
            TinhTrang = tinhTrang;
            DiaChi = diaChi;
        }

        // Optional constructor with all properties
        public Phieudatmongiaodi(string maPhieu, DateTime? ngayGio, string tinhTrang, int? phi, string diaChi)
        {
            MaPhieu = maPhieu;
            NgayGio = ngayGio;
            TinhTrang = tinhTrang;
            Phi = phi;
            DiaChi = diaChi;
        }

        // Default constructor
        public Phieudatmongiaodi() { }
    }
}
