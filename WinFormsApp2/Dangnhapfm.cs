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
            if (loai == 0)
            {
                listdn = DataProvider.DangNhap_NVs;
            }
            else if (loai == 1)
            {
                listdn = DataProvider.DangNhap_KHs;
            }
            foreach (var dn in listdn)
            {
                if (dn.TaiKhoan == tendangnhap && dn.MatKhau == matkhau)
                {
                    isFound = true; break;
                }

            }
            if (isFound)
            {
                if (loai == 0)
                {
                    MainfmNhanvien f = new MainfmNhanvien();
                    f.Show();

                }
                else
                {
                    Mainfmkhachhang f = new Mainfmkhachhang();
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

        private void Dangnhap_LoadALL(object sender, EventArgs e)
        {
            DataProvider.GetAllDangNhap_NV();
            DataProvider.GetAllDangNhap_KH();
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
