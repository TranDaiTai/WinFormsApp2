namespace QuanLySuShi
{
    partial class Mainfmkhachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            btdanhgia = new Button();
            groupBox4 = new GroupBox();
            btTimkiem = new Button();
            label1 = new Label();
            tbtinhtrang = new ComboBox();
            btquaylai = new Button();
            bthuydon = new Button();
            groupBox5 = new GroupBox();
            listView1 = new ListView();
            groupBox6 = new GroupBox();
            listView3 = new ListView();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            tbDiaChi = new TextBox();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            btdatban = new Button();
            btdathang = new Button();
            cbbchinhanh = new ComboBox();
            groupBox2 = new GroupBox();
            tbghichu = new TextBox();
            cbbmuc = new ComboBox();
            btXoa = new Button();
            numericUpDown1 = new NumericUpDown();
            btThem = new Button();
            cbbmonan = new ComboBox();
            cbbthucdon = new ComboBox();
            btuudai = new Button();
            tabPage3 = new TabPage();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(160, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(160, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 397);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(btdanhgia);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(btquaylai);
            tabPage1.Controls.Add(bthuydon);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 364);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Đơn Hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 67);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(465, 254);
            dataGridView2.TabIndex = 47;
            dataGridView2.RowHeaderMouseClick += dataGridView2_RowHeaderMouseClick;
            // 
            // btdanhgia
            // 
            btdanhgia.Location = new Point(129, 327);
            btdanhgia.Name = "btdanhgia";
            btdanhgia.Size = new Size(94, 29);
            btdanhgia.TabIndex = 41;
            btdanhgia.Text = "Đánh Giá";
            btdanhgia.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btTimkiem);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(tbtinhtrang);
            groupBox4.Location = new Point(6, -14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(468, 75);
            groupBox4.TabIndex = 43;
            groupBox4.TabStop = false;
            // 
            // btTimkiem
            // 
            btTimkiem.Location = new Point(282, 17);
            btTimkiem.Name = "btTimkiem";
            btTimkiem.Size = new Size(94, 29);
            btTimkiem.TabIndex = 2;
            btTimkiem.Text = "Tìm kiếm";
            btTimkiem.UseVisualStyleBackColor = true;
            btTimkiem.Click += btTimkiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Tình trạng";
            // 
            // tbtinhtrang
            // 
            tbtinhtrang.FormattingEnabled = true;
            tbtinhtrang.Location = new Point(85, 18);
            tbtinhtrang.Name = "tbtinhtrang";
            tbtinhtrang.Size = new Size(167, 28);
            tbtinhtrang.TabIndex = 0;
            // 
            // btquaylai
            // 
            btquaylai.Location = new Point(658, 329);
            btquaylai.Name = "btquaylai";
            btquaylai.Size = new Size(94, 29);
            btquaylai.TabIndex = 44;
            btquaylai.Text = "Quay lại";
            btquaylai.UseVisualStyleBackColor = true;
            // 
            // bthuydon
            // 
            bthuydon.AutoSize = true;
            bthuydon.Location = new Point(9, 327);
            bthuydon.Name = "bthuydon";
            bthuydon.Size = new Size(114, 30);
            bthuydon.TabIndex = 40;
            bthuydon.Text = "Huỷ Đơn";
            bthuydon.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(listView1);
            groupBox5.Location = new Point(473, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(311, 196);
            groupBox5.TabIndex = 45;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chi tiết đơn hàng";
            // 
            // listView1
            // 
            listView1.Location = new Point(11, 26);
            listView1.Name = "listView1";
            listView1.Size = new Size(300, 170);
            listView1.TabIndex = 23;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(listView3);
            groupBox6.Location = new Point(484, 208);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(300, 115);
            groupBox6.TabIndex = 46;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ghi chú";
            // 
            // listView3
            // 
            listView3.Location = new Point(0, 26);
            listView3.Name = "listView3";
            listView3.Size = new Size(294, 87);
            listView3.TabIndex = 23;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btdatban);
            tabPage2.Controls.Add(btdathang);
            tabPage2.Controls.Add(cbbchinhanh);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(cbbmuc);
            tabPage2.Controls.Add(btXoa);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(btThem);
            tabPage2.Controls.Add(cbbmonan);
            tabPage2.Controls.Add(cbbthucdon);
            tabPage2.Controls.Add(btuudai);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 364);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Đặt Hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(434, 267);
            dataGridView1.TabIndex = 42;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbDiaChi);
            groupBox3.Location = new Point(448, 252);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(335, 61);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "Địa Chỉ";
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(0, 26);
            tbDiaChi.Multiline = true;
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(332, 32);
            tbDiaChi.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView2);
            groupBox1.Location = new Point(451, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 152);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // listView2
            // 
            listView2.Location = new Point(0, 26);
            listView2.Name = "listView2";
            listView2.Size = new Size(335, 120);
            listView2.TabIndex = 23;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // btdatban
            // 
            btdatban.Location = new Point(572, 316);
            btdatban.Name = "btdatban";
            btdatban.Size = new Size(94, 29);
            btdatban.TabIndex = 33;
            btdatban.Text = "Đặt bàn";
            btdatban.UseVisualStyleBackColor = true;
            // 
            // btdathang
            // 
            btdathang.AutoSize = true;
            btdathang.Location = new Point(451, 316);
            btdathang.Name = "btdathang";
            btdathang.Size = new Size(114, 30);
            btdathang.TabIndex = 31;
            btdathang.Text = "Đặt hàng";
            btdathang.UseVisualStyleBackColor = true;
            btdathang.Click += btdathang_Click;
            // 
            // cbbchinhanh
            // 
            cbbchinhanh.FormattingEnabled = true;
            cbbchinhanh.Location = new Point(11, 6);
            cbbchinhanh.Name = "cbbchinhanh";
            cbbchinhanh.Size = new Size(121, 28);
            cbbchinhanh.TabIndex = 36;
            cbbchinhanh.Text = "Chi Nhánh";
            cbbchinhanh.SelectedIndexChanged += cbbchinhanh_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbghichu);
            groupBox2.Location = new Point(451, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 91);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ghi chú";
            // 
            // tbghichu
            // 
            tbghichu.Location = new Point(0, 19);
            tbghichu.Multiline = true;
            tbghichu.Name = "tbghichu";
            tbghichu.Size = new Size(332, 69);
            tbghichu.TabIndex = 0;
            // 
            // cbbmuc
            // 
            cbbmuc.FormattingEnabled = true;
            cbbmuc.Location = new Point(147, 40);
            cbbmuc.Name = "cbbmuc";
            cbbmuc.Size = new Size(116, 28);
            cbbmuc.TabIndex = 37;
            cbbmuc.Text = "Mục";
            cbbmuc.SelectedIndexChanged += cbbMuc_SelectedIndexChanged;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(269, 40);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(87, 28);
            btXoa.TabIndex = 35;
            btXoa.Text = "Xoá";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(362, 18);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 27);
            numericUpDown1.TabIndex = 34;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btThem
            // 
            btThem.Location = new Point(269, 10);
            btThem.Name = "btThem";
            btThem.Size = new Size(87, 28);
            btThem.TabIndex = 32;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // cbbmonan
            // 
            cbbmonan.FormattingEnabled = true;
            cbbmonan.Location = new Point(11, 40);
            cbbmonan.Name = "cbbmonan";
            cbbmonan.Size = new Size(121, 28);
            cbbmonan.TabIndex = 30;
            cbbmonan.Text = "Món Ăn";
            cbbmonan.SelectedIndexChanged += cbbmonan_SelectedIndexChanged;
            // 
            // cbbthucdon
            // 
            cbbthucdon.FormattingEnabled = true;
            cbbthucdon.Location = new Point(147, 6);
            cbbthucdon.Name = "cbbthucdon";
            cbbthucdon.Size = new Size(116, 28);
            cbbthucdon.TabIndex = 29;
            cbbthucdon.Text = "Thực đơn ";
            cbbthucdon.SelectedIndexChanged += cbbthucdon_SelectedIndexChanged;
            // 
            // btuudai
            // 
            btuudai.Location = new Point(686, 316);
            btuudai.Name = "btuudai";
            btuudai.Size = new Size(94, 29);
            btuudai.TabIndex = 39;
            btuudai.Text = "Ưu đãi";
            btuudai.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 364);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Quản Lý thông tin";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Mainfmkhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Name = "Mainfmkhachhang";
            Text = "Mainkhachhang";
            Load += Mainfmkhachhang_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private TextBox tbDiaChi;
        private GroupBox groupBox1;
        private ListView listView2;
        private Button btdatban;
        private Button btdathang;
        private ComboBox cbbchinhanh;
        private GroupBox groupBox2;
        private TextBox tbghichu;
        private ComboBox cbbmuc;
        private Button btXoa;
        private NumericUpDown numericUpDown1;
        private Button btThem;
        private ComboBox cbbmonan;
        private ComboBox cbbthucdon;
        private Button btuudai;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private Button btdanhgia;
        private GroupBox groupBox4;
        private Button btTimkiem;
        private Label label1;
        private ComboBox tbtinhtrang;
        private Button btquaylai;
        private Button bthuydon;
        private GroupBox groupBox5;
        private ListView listView1;
        private GroupBox groupBox6;
        private ListView listView3;
    }
}