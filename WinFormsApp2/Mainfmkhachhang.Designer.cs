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
            btdathang = new Button();
            btdatban = new Button();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            cbbthucdon = new ComboBox();
            cbbmonan = new ComboBox();
            btThem = new Button();
            numericUpDown1 = new NumericUpDown();
            btXoa = new Button();
            cbbmuc = new ComboBox();
            groupBox4 = new GroupBox();
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            btuudai = new Button();
            groupBox2 = new GroupBox();
            listView3 = new ListView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btdathang
            // 
            btdathang.AutoSize = true;
            btdathang.Location = new Point(12, 387);
            btdathang.Name = "btdathang";
            btdathang.Size = new Size(114, 30);
            btdathang.TabIndex = 2;
            btdathang.Text = "Đặt hàng";
            btdathang.UseVisualStyleBackColor = true;
            btdathang.Click += btdathang_Click;
            // 
            // btdatban
            // 
            btdatban.Location = new Point(141, 388);
            btdatban.Name = "btdatban";
            btdatban.Size = new Size(94, 29);
            btdatban.TabIndex = 3;
            btdatban.Text = "Đặt bàn";
            btdatban.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, trợGiúpToolStripMenuItem });
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
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, đơnHàngToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(157, 26);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click;
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(157, 26);
            đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            đơnHàngToolStripMenuItem.Click += đơnHàngToolStripMenuItem_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // cbbthucdon
            // 
            cbbthucdon.FormattingEnabled = true;
            cbbthucdon.Location = new Point(6, 15);
            cbbthucdon.Name = "cbbthucdon";
            cbbthucdon.Size = new Size(167, 28);
            cbbthucdon.TabIndex = 0;
            cbbthucdon.SelectedIndexChanged += cbbthucdon_SelectedIndexChanged;
            // 
            // cbbmonan
            // 
            cbbmonan.FormattingEnabled = true;
            cbbmonan.Location = new Point(6, 48);
            cbbmonan.Name = "cbbmonan";
            cbbmonan.Size = new Size(167, 28);
            cbbmonan.TabIndex = 1;
            // 
            // btThem
            // 
            btThem.Location = new Point(179, 47);
            btThem.Name = "btThem";
            btThem.Size = new Size(87, 28);
            btThem.TabIndex = 2;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(357, 26);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btXoa
            // 
            btXoa.Location = new Point(272, 48);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(79, 28);
            btXoa.TabIndex = 4;
            btXoa.Text = "Xoá";
            btXoa.UseVisualStyleBackColor = true;
            // 
            // cbbmuc
            // 
            cbbmuc.FormattingEnabled = true;
            cbbmuc.Location = new Point(179, 14);
            cbbmuc.Name = "cbbmuc";
            cbbmuc.Size = new Size(172, 28);
            cbbmuc.TabIndex = 5;
            cbbmuc.SelectedIndexChanged += cbbMuc_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbbmuc);
            groupBox4.Controls.Add(btXoa);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Controls.Add(btThem);
            groupBox4.Controls.Add(cbbmonan);
            groupBox4.Controls.Add(cbbthucdon);
            groupBox4.Location = new Point(15, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(423, 78);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(21, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(421, 266);
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView2);
            groupBox1.Location = new Point(459, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 184);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // listView2
            // 
            listView2.Location = new Point(11, 26);
            listView2.Name = "listView2";
            listView2.Size = new Size(318, 146);
            listView2.TabIndex = 23;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btuudai
            // 
            btuudai.Location = new Point(241, 388);
            btuudai.Name = "btuudai";
            btuudai.Size = new Size(94, 29);
            btuudai.TabIndex = 25;
            btuudai.Text = "Ưu đãi";
            btuudai.UseVisualStyleBackColor = true;
            btuudai.Click += btuudai_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView3);
            groupBox2.Location = new Point(453, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 208);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ghi chú";
            // 
            // listView3
            // 
            listView3.Location = new Point(17, 26);
            listView3.Name = "listView3";
            listView3.Size = new Size(315, 163);
            listView3.TabIndex = 23;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // Mainfmkhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(btuudai);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Controls.Add(groupBox4);
            Controls.Add(menuStrip1);
            Controls.Add(btdatban);
            Controls.Add(btdathang);
            Name = "Mainfmkhachhang";
            Text = "Mainkhachhang";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btdathang;
        private Button btdatban;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ComboBox cbbthucdon;
        private ComboBox cbbmonan;
        private Button btThem;
        private NumericUpDown numericUpDown1;
        private Button btXoa;
        private ComboBox cbbmuc;
        private GroupBox groupBox4;
        private ListView listView1;
        private GroupBox groupBox1;
        private ListView listView2;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private Button btuudai;
        private GroupBox groupBox2;
        private ListView listView3;
    }
}