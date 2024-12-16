using QuanLySuShi.DAO;
using QuanLySuShi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuShi
{
    public partial class Mainfmkhachhang : Form
    {
        public Mainfmkhachhang()
        {
            InitializeComponent();
            LoadThucdon();

        }

        private void btdathang_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap loginForm = new Dangnhap();
            loginForm.Show();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat chuong trinh", "Canh Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khachhang_donhang kh = new Khachhang_donhang();
            kh.Show();
            this.Hide();
        }

        private void btuudai_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

    }
}
