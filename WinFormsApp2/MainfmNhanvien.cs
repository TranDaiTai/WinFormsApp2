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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuShi
{
    public partial class MainfmNhanvien : Form
    {
        private Button selectedButton = null; // Lưu button đang chọn

        public MainfmNhanvien()
        {
            InitializeComponent();
            Loadtable();
            LoadThucdon();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminfm adminfm = new adminfm();
            adminfm.Show();

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tạoThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem đã chọn món ăn và nhập số lượng chưa
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

            string maphieu = PhieudatmonDAO.GetPhieuDatMonByTableId((selectedButton.Tag as Table).TableID);
            bool isSuccess = false;
            string mamonan = selectedMonAn.MaMonAn;
            if (string.IsNullOrEmpty(maphieu))
            {

            }
            else
            {
                
                // Thêm vào cơ sở dữ liệu
                isSuccess = ChitietphieuDAO.AddChitietPhieu(maphieu, mamonan, soLuong);

                // Thông báo kết quả
                if (isSuccess)
                {
                    MessageBox.Show("Thêm món ăn vào phiếu thành công!", "Thông báo");

                    // Cập nhật lại danh sách chi tiết phiếu
                    showPhieudat((selectedButton.Tag as Table).TableID);
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại. Vui lòng thử lại.", "Thông báo");
                }
            }
        }

        void Loadtable()
        {
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

            string maPhieu = PhieudatmonDAO.GetPhieuDatMonByTableId(id_table);
            if (!string.IsNullOrEmpty(maPhieu))
            {
                List<Chitietphieudat> list = ChitietphieuDAO.GetChitietPhieuByMaPhieu(maPhieu);
                foreach (Chitietphieudat item in list)
                {
                    ListViewItem lsitem = new ListViewItem(item.MaMonAn.ToString());
                    MonAn monan = MonAnDAO.GetMonAnByMaMonAn(item.MaMonAn);
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
            selectedButton = (sender as Button);
            string id_table = ((sender as Button).Tag as Table).TableID;
            showPhieudat(id_table);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        void LoadThucdon()
        {
            List<ThucDon> listtd = ThucDonDAO.GetAllThucDon();
            cbbthucdon.DataSource = listtd;
            cbbthucdon.DisplayMember = "TenThucDon";
        }
        void LoadMucByThucdon()
        {
            // Lấy MaThucDon của thực đơn đã chọn
            string maThucDon = ((ThucDon)cbbthucdon.SelectedItem).MaThucDon;

            // Lấy danh sách các mục (mục thực đơn) theo MaThucDon
            List<Muc> listMuc = MucDAO.GetMucsByMaThucDon(maThucDon);

            // Hiển thị các mục vào combobox hoặc danh sách mục
            cbbmuc.DataSource = listMuc;
            cbbmuc.DisplayMember = "TenMuc"; // Hiển thị tên mục
        }

        void LoadMonAnByMuc()
        {
            // Lấy MaMuc của mục thực đơn đã chọn
            string maMuc = ((Muc)cbbmuc.SelectedItem).MaMuc;

            // Lấy danh sách món ăn theo MaMuc
            List<MonAn> listMonAn = MonAnDAO.GetMonAnByMuc(maMuc);

            // Hiển thị danh sách món ăn vào combobox hoặc danh sách món ăn
            cbbmonan.DataSource = listMonAn;
            cbbmonan.DisplayMember = "TenMonAn"; // Hiển thị tên món ăn
        }

        private void cbbthucdon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng thay đổi thực đơn, tải lại các mục theo thực đơn đã chọn
            LoadMucByThucdon();
        }

        private void cbbMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng thay đổi mục, tải lại các món ăn theo mục đã chọn
            LoadMonAnByMuc();
        }

        private void listchitiet_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
           
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
                string maphieu = PhieudatmonDAO.GetPhieuDatMonByTableId((selectedButton.Tag as Table).TableID);

                // Thực hiện hành động xóa (ví dụ: xóa khỏi cơ sở dữ liệu hoặc danh sách)
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa món ăn {maMonAn}?", "Xóa món ăn", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = false;

                    // Thực hiện xóa trong cơ sở dữ liệu hoặc danh sách (nếu có)
                    isDeleted= ChitietphieuDAO.XoaMonAnTheoPhieu(maMonAn,maphieu); // Đây là ví dụ, thay đổi tùy theo DAO của bạn
                    if (isDeleted)
                    {
                        MessageBox.Show("Món ăn đã được xóa thành công.");
                        showPhieudat((selectedButton.Tag as Table).TableID);
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
    }
}
