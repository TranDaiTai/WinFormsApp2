using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySuShi.DTO;

namespace QuanLySuShi.DAO
{
    internal class ChitietphieuDAO
    {
        public bool AddChitietPhieu(Chitietphieudat chitietPhieu)
        {
            string procedureName = "sp_ThemMonVaoPhieuDatMon";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_phieu", chitietPhieu.MaPhieu },
                { "@id_mon_an", chitietPhieu.MaMonAn },
                { "@so_luong", chitietPhieu.SoLuong }
            };

            
            return DataProvider.ExecuteNonQuery(procedureName, parameters);
        }


        public DataTable GetChitietPhieuByMaPhieu(string maPhieu)
        {
            string query = "SELECT * FROM Chitietphieudat WHERE MaPhieu = @MaPhieu";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaPhieu", maPhieu }
            };

            return DataProvider.ExecuteSelectQuery(query, parameters);
        }

    }
}
