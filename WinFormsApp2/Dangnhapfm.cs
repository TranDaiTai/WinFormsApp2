using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySuShi.DAO;
using QuanLySuShi.DTO;

namespace QuanLySuShi

{
    public partial class Dangnhap : Form
    {
        public static NhanVien nv = null;
        //public static Khachhang kh = null;


        public Dangnhap()
        {
            InitializeComponent();
        }


        private void btdangnhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = tbtaikhoan.Text;
            string matkhau = tbmatkhau.Text;
            int loai = cbbloai.SelectedIndex;
            if (!kiemtranhap())
            {
                return;
            }
            bool isFound = false;
            List<DangNhap> listdn = null;
            if (loai == 1)
            {
                isFound = DangNhapDAO.TryDangNhapKH(tendangnhap, matkhau);
            }
            else if (loai == 0)
            {
                isFound = DangNhapDAO.TryDangNhapNV(tendangnhap, matkhau);
            }
            if (isFound)
            {
                if (loai == 0)
                {
                    MainfmNhanvien f = new MainfmNhanvien();
                    Dangnhap.nv = NhanVienDAO.GetNhanVienByTaiKhoan(tendangnhap);
                    f.Show();

                }
                else
                {
                    Mainfmkhachhang f = new Mainfmkhachhang();
                    //Dangnhap.kh = KhachHangDAO.GetKhachHangByTaiKhoan(tendangnhap);
                    f.Show();

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai Ten tai khoan hoac mat khau ");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool kiemtranhap()
        {
            if (tbtaikhoan.Text == "")
            {
                MessageBox.Show("vui long nhap tai khoan ");
                tbtaikhoan.Focus();
                return false;
            }
            if (tbmatkhau.Text == "")
            {
                MessageBox.Show("vui long nhap mat khau");
                tbmatkhau.Focus();
                return false;
            }
            if (cbbloai.SelectedIndex == -1)
            {
                MessageBox.Show("vui long chon loai tai khoan ");
                cbbloai.Focus();
                return false;
            }


            return true;
        }

        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat chuong trinh", "Canh Bao", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloai.SelectedIndex == 0)
               { tbmatkhau.Text = "password456";
                tbtaikhoan.Text = "tranthib";
            }
            else
              {  tbmatkhau.Text = "password789";
                tbtaikhoan.Text = "nguyenvanc";
            }
           
        }
    }
}
