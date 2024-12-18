﻿using QuanLySuShi.DAO;
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
        public static void LoadThucdon(ComboBox cbbthucdon,string machinhanh)
        {
            List<ThucDon> listtd = ThucDonDAO.GetThucDon(machinhanh);
            foreach (var item in listtd)
            {
                cbbthucdon.Items.Add(item);
                cbbthucdon.DisplayMember = "TenThucDon";

            }
        }


    }
}
