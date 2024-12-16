using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using QuanLySuShi.DTO;

namespace QuanLySuShi.DAO
{
    internal class PhieudatmonDAO
    {
        public static string GetPhieuDatMonByTableId(string id)
        {
            var query = "SELECT pdm.maphieu " +
                        "FROM PhieuDatMon pdm " +
                        "LEFT JOIN HoaDon hd ON pdm.MaPhieu = hd.MaPhieu " +
                        "JOIN PhieuDatMonTrucTiep tt ON pdm.MaPhieu = tt.MaPhieu " +
                        "WHERE hd.MaHoaDon IS NULL AND tt.maban = @TableId";

            var parameters = new Dictionary<string, object>
            {
                { "@TableId", id }
            };

            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["maphieu"]?.ToString(); // Sử dụng ?.ToString() để tránh lỗi null.
            }

            return null; // Trả về null nếu không có dữ liệu.
        }

    }
} 

