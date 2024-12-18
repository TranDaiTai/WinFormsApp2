﻿using QuanLySuShi.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuShi.DTO
{
    public class ChiNhanh
    {
        public string MaChiNhanh { get; set; }
        public string TenChiNhanh { get; set; }
        public TimeSpan ThoiGianMoCua { get; set; }
        public TimeSpan ThoiGianDongCua { get; set; }
        public string SoDienThoai { get; set; }
        public bool? BaiDoXeMay { get; set; }
        public bool? BaiDoXeHoi { get; set; }
        public string DiaChi { get; set; }
        public string NhanVienQuanLy { get; set; }

        // Default Constructor
        public ChiNhanh() { }

        // Constructor với tất cả thuộc tính
        public ChiNhanh(string maChiNhanh, string tenChiNhanh, TimeSpan thoiGianMoCua, TimeSpan thoiGianDongCua,
                        string soDienThoai, bool? baiDoXeMay, bool? baiDoXeHoi, string diaChi, string nhanVienQuanLy)
        {
            MaChiNhanh = maChiNhanh;
            TenChiNhanh = tenChiNhanh;
            ThoiGianMoCua = thoiGianMoCua;
            ThoiGianDongCua = thoiGianDongCua;
            SoDienThoai = soDienThoai;
            BaiDoXeMay = baiDoXeMay;
            BaiDoXeHoi = baiDoXeHoi;
            DiaChi = diaChi;
            NhanVienQuanLy = nhanVienQuanLy;
        }

        // Constructor từ DataRow
        public ChiNhanh(DataRow row)
        {
            MaChiNhanh = row["MaChiNhanh"].ToString();
            TenChiNhanh = row["TenChiNhanh"].ToString();
            ThoiGianMoCua = TimeSpan.Parse(row["ThoiGianMoCua"].ToString());
            ThoiGianDongCua = TimeSpan.Parse(row["ThoiGianDongCua"].ToString());
            SoDienThoai = row["SoDienThoai"].ToString();
            BaiDoXeMay = row["BaiDoXeMay"] != DBNull.Value ? (bool?)row["BaiDoXeMay"] : null;
            BaiDoXeHoi = row["BaiDoXeHoi"] != DBNull.Value ? (bool?)row["BaiDoXeHoi"] : null;
            DiaChi = row["DiaChi"].ToString();
            NhanVienQuanLy = row["NhanVienQuanLy"]?.ToString();
        }
        public static void LoadChinhanh(ComboBox cbx)
        {
            List<ChiNhanh> listchinhanhs = ChiNhanhDAO.GetAllChiNhanh();

            foreach (var item in listchinhanhs)
            {
                cbx.Items.Add(item);
                cbx.DisplayMember = "TenChiNhanh";

            }
        }
    }
}
