using System;
using System.Collections.Generic;
using System.Data;
using QuanLySuShi.DTO;

namespace QuanLySuShi.DAO
{
    internal class PhieudatmonDAO
    {
        public static List<Phieudatmontructiep> GetPhieuDatMonList()
{
    var phieuDatMonList = new List<Phieudatmontructiep>();
    string query = "SELECT MaPhieu, MaBan FROM PhieuDatMonTrucTiep";

    try
    {
        // Thực thi truy vấn và lấy dữ liệu
        DataTable dataTable = DataProvider.ExecuteSelectQuery(query);

        // Duyệt qua từng dòng dữ liệu và ánh xạ vào danh sách đối tượng
        foreach (DataRow row in dataTable.Rows)
        {
            var phieuDatMon = new Phieudatmontructiep
            {
                MaPhieu = row["MaPhieu"]?.ToString(),
                MaBan = row["MaBan"]?.ToString()
            };
            phieuDatMonList.Add(phieuDatMon);
        }
    }
    catch (Exception ex)
    {
        // Xử lý ngoại lệ khi có lỗi
        Console.WriteLine($"Lỗi khi lấy dữ liệu PhieuDatMon: {ex.Message}");
    }

    return phieuDatMonList;
}

    }
}
