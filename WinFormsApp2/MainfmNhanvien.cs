using QuanLySuShi.DAO;
using QuanLySuShi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuShi
{
    public partial class MainfmNhanvien : Form
    {
        private Button selected_table = null; // Lưu button đang chọn
        private string current_maphieu = null; // Lưu button đang chọn

        public MainfmNhanvien()
        {
            InitializeComponent();
            Loadtable();
            ThucDon.LoadThucdon(cbbthucdon, (Dangnhap.user as NhanVien).MaChiNhanh);
            PhanQuyen();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap loginForm = new Dangnhap();
            loginForm.Show();
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminfm adminfm = new adminfm();
            adminfm.Show();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (selected_table == null)
            {
                MessageBox.Show("Vui lòng chọn Bàn.", "Thông báo");
                return;
            }


            if (cbbmonan.SelectedItem == null || string.IsNullOrEmpty(soluong.Text))
            {
                MessageBox.Show("Vui lòng chọn món ăn và nhập số lượng hợp lệ.", "Thông báo");
                return;
            }

            // Lấy thông tin món ăn từ combobox
            MonAn selectedMonAn = (MonAn)cbbmonan.SelectedItem;

            // Lấy số lượng từ textbox
            int soLuong;
            int.TryParse(soluong.Text, out soLuong);
            Table selectTable = (selected_table.Tag as Table);



            bool isSuccess = false;
            string mamonan = selectedMonAn.MaMonAn;
            if (string.IsNullOrEmpty(current_maphieu))
            {

                //// Hỏi người dùng xem có phải khách hàng thân thiết không
                //DialogResult result = MessageBox.Show("Khách hàng có phải là khách hàng thân thiết không?",
                //                                      "Xác nhận khách hàng",
                //                                      MessageBoxButtons.YesNo,
                //                                      MessageBoxIcon.Question);

                //if (result == DialogResult.Yes)
                //{
                //    // Mở input để nhập thông tin khách hàng thân thiết
                //    string maKhachHang = Microsoft.VisualBasic.Interaction.InputBox(
                //                          "Vui lòng nhập mã khách hàng:",
                //                          "Nhập mã khách hàng thân thiết",
                //                          "");

                //    if (string.IsNullOrEmpty(maKhachHang))
                //    {
                //        MessageBox.Show("Mã khách hàng không được để trống!", "Lỗi");
                //        return;
                //    }

                //    // Thêm logic xử lý khách hàng thân thiết ở đây (ví dụ: kiểm tra mã khách hàng)
                //    MessageBox.Show($"Khách hàng thân thiết: {maKhachHang}", "Thông báo");
                //}


                string maPhieuMoi = PhieudatmonDAO.GetMaxPhieuDatMon(); // Hoặc có thể là chuỗi tự tạo, tùy vào quy tắc trong hệ thống của bạn.
                string makhachhang = KhachHangDAO.GetMaxMakhachhang();
                KhachHang kh = new KhachHang() { MaDinhDanh = makhachhang };
                KhachHangDAO.CreatKhachHang(kh);


                isSuccess = PhieudatmonDAO.CreatePhieuDatMon(Dangnhap.user.MaDinhDanh, makhachhang, (Dangnhap.user as NhanVien).MaChiNhanh, maPhieuMoi);
                if (isSuccess)
                {
                    current_maphieu = maPhieuMoi;
                    if (PhieudatmontructiepDAO.CreatePhieuDatMonTrucTiep(maPhieuMoi, selectTable.TableID) && ChitietphieuDAO.AddChitietPhieu(maPhieuMoi, mamonan, soLuong))
                        MessageBox.Show("Tạo Phiếu và Thêm món ăn vào phiếu thành công!", "Thông báo");
                    selectTable.Status = Table.GetTableStatus(selectTable.TableID);
                    Loadtable();
                    showPhieudat(selectTable.TableID);
                }

            }
            else
            {

                // Thêm vào cơ sở dữ liệu
                isSuccess = ChitietphieuDAO.AddChitietPhieu(current_maphieu, mamonan, soLuong);

                // Thông báo kết quả

                MessageBox.Show("Thêm món ăn vào phiếu thành công!", "Thông báo");

                // Cập nhật lại danh sách chi tiết phiếu
                showPhieudat(selectTable.TableID);

            }
        }

        void Loadtable()
        {
            flpTable.Controls.Clear();
            foreach (var table in Table.Tables)
            {
                Button btn = new Button()
                {
                    Width = Table.btnWidth,
                    Height = Table.btnHeight
                };
                btn.Click += Btn_Click;
                btn.Tag = table;
                flpTable.Controls.Add(btn);
                btn.Text = table.TableName + Environment.NewLine + table.Status;
                switch (table.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default: btn.BackColor = Color.Red; break;
                }

            }

        }

        void showPhieudat(string id_table)
        {
            listchitiet.Items.Clear();
            listchitiet.Columns.Clear();
            listchitiet.Columns.Add("Mã Món Ăn", 150); // Cột 1: Mã món ăn.
            listchitiet.Columns.Add("Tên Món", 100); // Cột 2: Giá.
            listchitiet.Columns.Add("Giá", 100); // Cột 2: Giá.
            listchitiet.Columns.Add("Số lượng", 100); // Cột 2: Giá.


            decimal totalprice = 0;

            CultureInfo culture = new CultureInfo("vi-VN");


            if (!string.IsNullOrEmpty(current_maphieu))
            {
                List<Chitietphieudat> list = ChitietphieuDAO.GetChitietPhieuByMaPhieu(current_maphieu);
                foreach (Chitietphieudat item in list)
                {
                    ListViewItem lsitem = new ListViewItem(item.MaMonAn.ToString());
                    MonAn monan = MonAnDAO.GetMonAn(maMonAn: item.MaMonAn)[0];
                    lsitem.SubItems.Add(monan.TenMonAn.ToString());
                    lsitem.SubItems.Add(monan.GiaTien.ToString("c", culture));
                    lsitem.SubItems.Add(item.SoLuong.ToString());
                    lsitem.SubItems.Add((monan.GiaTien * item.SoLuong).ToString("c", culture));
                    listchitiet.Items.Add(lsitem);
                    totalprice += monan.GiaTien * item.SoLuong;
                }
                tbtongtien.Text = totalprice.ToString("c", culture);

            }

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            selected_table = (sender as Button);
            string id_table = ((sender as Button).Tag as Table).TableID;
            current_maphieu = PhieudatmonDAO.GetPhieuDatMonByTableId(id_table);
            showPhieudat(id_table);
        }

        private void cbbthucdon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng thay đổi thực đơn, tải lại các mục theo thực đơn đã chọn
            Muc.LoadMucByThucdon(cbbmuc, cbbthucdon);
        }

        private void cbbMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng thay đổi mục, tải lại các món ăn theo mục đã chọn
            MonAn.LoadMonAnByMuc(cbbmuc, cbbmonan);
        }


        private void btXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (listchitiet.SelectedItems.Count > 0)
            {
                // Lấy mục đã chọn
                ListViewItem selectedItem = listchitiet.SelectedItems[0];

                // Lấy các thông tin cần thiết từ mục đã chọn
                string maMonAn = selectedItem.SubItems[0].Text;

                // Thực hiện hành động xóa (ví dụ: xóa khỏi cơ sở dữ liệu hoặc danh sách)
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa món ăn {maMonAn}?", "Xóa món ăn", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = false;

                    // Thực hiện xóa trong cơ sở dữ liệu hoặc danh sách (nếu có)
                    isDeleted = ChitietphieuDAO.XoaMonAnTheoPhieu(maMonAn, current_maphieu); // Đây là ví dụ, thay đổi tùy theo DAO của bạn
                    if (isDeleted)
                    {
                        MessageBox.Show("Món ăn đã được xóa thành công.");
                        showPhieudat((selected_table.Tag as Table).TableID);
                    }

                    else
                        MessageBox.Show("Xoá thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn để xóa.");
            }
        }
        private void PhanQuyen()
        {
            NhanVien nhanvien = Dangnhap.user as NhanVien;

            if (nhanvien.QuanlyChiNhanh)
            {
                btn_admin.Enabled = true;
            }
            else { btn_admin.Enabled = false; }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            Table selectTable = (selected_table.Tag as Table);


            if (current_maphieu != null)
            {

                CultureInfo culture = new CultureInfo("vi-VN");
                string mahoadon = HoaDonDAO.GetMaxHoaDon();
                decimal totalprice = Decimal.Parse(tbtongtien.Text, NumberStyles.Currency, culture);
                HoaDonDAO.AddHoaDon(mahoadon, (Dangnhap.user as NhanVien).MaChiNhanh, current_maphieu, totalprice, null);


                selectTable.Status = Table.GetTableStatus(selectTable.TableID);
                Loadtable();
                showPhieudat(selectTable.TableID);

                MessageBox.Show($"Tổng hoá đơn của quý khách là {totalprice}", "thông báo");
                current_maphieu = null;
                selected_table = null;
                listchitiet.Items.Clear();
            }
            else
            {
                MessageBox.Show("vui lòng chọn bàn khác để thanh toán", "thông báo");
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu trong các textbox
            if (string.IsNullOrWhiteSpace(tbHoVaTen_taothe.Text))
            {
                MessageBox.Show("Họ và tên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbHoVaTen_taothe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbSDT_taothe.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSDT_taothe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbEmail_taothe.Text))
            {
                MessageBox.Show("Email không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail_taothe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbCCCD_taothe.Text))
            {
                MessageBox.Show("CCCD không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCCCD_taothe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbbGioitinh_taothe.Text))
            {
                MessageBox.Show("Giới tính không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbGioitinh_taothe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbTaiKhoan_taothe.Text))
            {
                MessageBox.Show("Tài khoản không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTaiKhoan_taothe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbMatKhau_taothe.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMatKhau_taothe.Focus();
                return;
            }

            try
            {
                // Lấy mã khách hàng mới (tự động tăng)
                string maKhachHang = KhachHangDAO.GetMaxMakhachhang();

                // Tạo đối tượng KhachHang
                KhachHang newCustomer = new KhachHang
                {
                    MaDinhDanh = maKhachHang,
                    HoTen = tbHoVaTen_taothe.Text,
                    SoDienThoai = tbSDT_taothe.Text,
                    Email = tbEmail_taothe.Text,
                    CCCD = tbCCCD_taothe.Text,
                    GioiTinh = cbbGioitinh_taothe.Text,
                    TaiKhoan = tbTaiKhoan_taothe.Text,
                    MatKhau = tbMatKhau_taothe.Text
                };

                // Gọi DAO để thêm tài khoản
                bool result = KhachHangDAO.CreatKhachHang(newCustomer);

                if (result)
                {
                    MessageBox.Show("Tạo tài khoản khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reset form
                    tbHoVaTen_taothe.Clear();
                    tbSDT_taothe.Clear();
                    tbEmail_taothe.Clear();
                    tbCCCD_taothe.Clear();
                    cbbGioitinh_taothe.SelectedIndex = -1;
                    tbTaiKhoan_taothe.Clear();
                    tbMatKhau_taothe.Clear();
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
