using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLySuShi.DTO;

namespace QuanLySuShi.DAO
{
    internal class ChitietphieuDAO
    {
        public static bool AddChitietPhieu(string MaPhieu, string MaMonAn, int SoLuong)
        {
            string sql = @"
    BEGIN
        -- Tính giá
        declare @gia money;
        select @gia = cast(@so_luong * MonAn.GiaTien as money)
        from MonAn 
        where MonAn.MaMonAn = @id_mon_an;

        IF EXISTS (SELECT 1 FROM ChiTietPhieuDat as ctpd 
                   JOIN MonAn ON ctpd.MaMonAn = MonAn.MaMonAn 
                   WHERE Maphieu = @id_phieu AND ctpd.Mamonan = @id_mon_an)
        BEGIN
            UPDATE ChiTietPhieuDat
            SET SoLuong = SoLuong + @so_luong, 
                Gia = @gia
            WHERE Maphieu = @id_phieu AND Mamonan = @id_mon_an;

            PRINT N'Cập nhật số lượng món ăn trong phiếu đặt món thành công.';
        END
        ELSE
        BEGIN
            INSERT INTO ChiTietPhieuDat (Maphieu, MaMonAn, SoLuong, Gia)
            VALUES (@id_phieu, @id_mon_an, @so_luong, @gia);

            PRINT N'Thêm món vào phiếu đặt món thành công.';
        END;
    END;
    ";


            // Tạo dictionary chứa các tham số truyền vào stored procedure
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id_phieu", MaPhieu },
                { "@id_mon_an", MaMonAn },
                { "@so_luong", SoLuong }
            };

            // Thực thi stored procedure và trả về kết quả
            return DataProvider.ExecuteNonQuery(sql, parameters);
        }


        public static bool XoaMonAnTheoPhieu(string maMonAn, string maPhieu)
        {
            // Câu lệnh gọi stored procedure với hai tham số
            string query = "EXEC sp_XoaMonAnTheoMaPhieu @MaMonAn, @MaPhieu";

            // Tạo tham số đầu vào cho stored procedure
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaMonAn", maMonAn },
                {"@MaPhieu", maPhieu }
            };

            // Thực thi câu lệnh
            return DataProvider.ExecuteNonQuery(query, parameters);
        }

        public static List<Chitietphieudat> GetChitietPhieuByMaPhieu(string maPhieu)
        {
            if (string.IsNullOrEmpty(maPhieu))
            {
                throw new ArgumentException("maPhieu cannot be null or empty");
            }

            List<Chitietphieudat> list = new List<Chitietphieudat>();
            string query = "SELECT * FROM Chitietphieudat WHERE MaPhieu = @MaPhieu";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaPhieu", maPhieu }
            };

            DataTable data = DataProvider.ExecuteSelectQuery(query, parameters);

            if (data != null)
            {
                foreach (DataRow datarow in data.Rows)
                {
                    Chitietphieudat ctpd = new Chitietphieudat(datarow);
                    list.Add(ctpd);
                }
            }

            return list;
        }


    }
}
