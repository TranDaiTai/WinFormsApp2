﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DTO
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; } // primary key
        public DateTime NgayLap { get; set; } // NOT NULL
        public decimal TongTien { get; set; } // NOT NULL
        public decimal? SoTienGiamGia { get; set; } // NULL
        public string MaUuDai { get; set; } // NULL
        public string MaPhieu { get; set; } // NOT NULL
        public string MaChiNhanh { get; set; } // NOT NULL

        // Constructor with required properties
        public static HoaDon FromDataRow(DataRow row)
        {
            return new HoaDon
            {
                MaHoaDon = row["MaHoaDon"].ToString(),
                NgayLap = Convert.ToDateTime(row["NgayLap"]),
                TongTien = Convert.ToDecimal(row["TongTien"]),
                SoTienGiamGia = row["SoTienGiamGia"] != DBNull.Value ? (decimal?)Convert.ToDecimal(row["SoTienGiamGia"]) : null,
                MaUuDai = row["MaUuDai"]?.ToString(),
                MaPhieu = row["MaPhieu"].ToString(),
                MaChiNhanh = row["MaChiNhanh"].ToString()
            };
        }
        // Default constructor
        public HoaDon() { }

    }
}
