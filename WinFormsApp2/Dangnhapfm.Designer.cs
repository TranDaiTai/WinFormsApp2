﻿namespace QuanLySuShi
{
    partial class Dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbtaikhoan = new Label();
            lbmatkhau = new Label();
            tbtaikhoan = new TextBox();
            tbmatkhau = new TextBox();
            button1 = new Button();
            button2 = new Button();
            cbbloai = new ComboBox();
            label1 = new Label();
            btndangky = new Button();
            SuspendLayout();
            // 
            // lbtaikhoan
            // 
            lbtaikhoan.AutoSize = true;
            lbtaikhoan.Location = new Point(32, 24);
            lbtaikhoan.Name = "lbtaikhoan";
            lbtaikhoan.Size = new Size(71, 20);
            lbtaikhoan.TabIndex = 0;
            lbtaikhoan.Text = "Tài khoản";
            // 
            // lbmatkhau
            // 
            lbmatkhau.AutoSize = true;
            lbmatkhau.Location = new Point(33, 77);
            lbmatkhau.Name = "lbmatkhau";
            lbmatkhau.Size = new Size(70, 20);
            lbmatkhau.TabIndex = 1;
            lbmatkhau.Text = "Mật khẩu";
            // 
            // tbtaikhoan
            // 
            tbtaikhoan.Location = new Point(109, 24);
            tbtaikhoan.Name = "tbtaikhoan";
            tbtaikhoan.Size = new Size(222, 27);
            tbtaikhoan.TabIndex = 2;
            // 
            // tbmatkhau
            // 
            tbmatkhau.Location = new Point(109, 74);
            tbmatkhau.Name = "tbmatkhau";
            tbmatkhau.Size = new Size(222, 27);
            tbmatkhau.TabIndex = 3;
            tbmatkhau.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(207, 107);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btdangnhap_Click;
            // 
            // button2
            // 
            button2.Location = new Point(307, 107);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btthoat_Click;
            // 
            // cbbloai
            // 
            cbbloai.FormattingEnabled = true;
            cbbloai.Items.AddRange(new object[] { "Nhân viên", "Khách hàng" });
            cbbloai.Location = new Point(64, 126);
            cbbloai.Name = "cbbloai";
            cbbloai.Size = new Size(100, 28);
            cbbloai.TabIndex = 6;
            cbbloai.SelectedIndexChanged += cbbloai_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 129);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 7;
            label1.Text = "Loại";
            // 
            // btndangky
            // 
            btndangky.Location = new Point(207, 138);
            btndangky.Name = "btndangky";
            btndangky.Size = new Size(94, 29);
            btndangky.TabIndex = 4;
            btndangky.Text = "Đăng ký";
            btndangky.UseVisualStyleBackColor = true;
            btndangky.Click += btdangnhap_Click;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 179);
            Controls.Add(label1);
            Controls.Add(cbbloai);
            Controls.Add(button2);
            Controls.Add(btndangky);
            Controls.Add(button1);
            Controls.Add(tbmatkhau);
            Controls.Add(tbtaikhoan);
            Controls.Add(lbmatkhau);
            Controls.Add(lbtaikhoan);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Dangnhap_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtaikhoan;
        private Label lbmatkhau;
        private TextBox tbtaikhoan;
        private TextBox tbmatkhau;
        private Button button1;
        private Button button2;
        private ComboBox cbbloai;
        private Label label1;
        private Button btndangky;
    }
}
