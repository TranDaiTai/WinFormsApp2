namespace QuanLySuShi
{
    partial class Khachhang_donhang
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
            listdonhang = new ListView();
            btdanhgia = new Button();
            tbtinhtrang = new ComboBox();
            groupBox4 = new GroupBox();
            btTimkiem = new Button();
            label1 = new Label();
            bthuydon = new Button();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            btquaylai = new Button();
            listView2 = new ListView();
            groupBox1 = new GroupBox();
            listView3 = new ListView();
            groupBox2 = new GroupBox();
            groupBox4.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listdonhang
            // 
            listdonhang.Location = new Point(17, 127);
            listdonhang.Name = "listdonhang";
            listdonhang.Size = new Size(421, 266);
            listdonhang.TabIndex = 31;
            listdonhang.UseCompatibleStateImageBehavior = false;
            // 
            // btdanhgia
            // 
            btdanhgia.Location = new Point(132, 399);
            btdanhgia.Name = "btdanhgia";
            btdanhgia.Size = new Size(94, 29);
            btdanhgia.TabIndex = 29;
            btdanhgia.Text = "Đánh Giá";
            btdanhgia.UseVisualStyleBackColor = true;
            // 
            // tbtinhtrang
            // 
            tbtinhtrang.FormattingEnabled = true;
            tbtinhtrang.Location = new Point(85, 18);
            tbtinhtrang.Name = "tbtinhtrang";
            tbtinhtrang.Size = new Size(167, 28);
            tbtinhtrang.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btTimkiem);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(tbtinhtrang);
            groupBox4.Location = new Point(15, 43);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(423, 78);
            groupBox4.TabIndex = 32;
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
            btTimkiem.Click += button1_Click;
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
            // bthuydon
            // 
            bthuydon.AutoSize = true;
            bthuydon.Location = new Point(12, 399);
            bthuydon.Name = "bthuydon";
            bthuydon.Size = new Size(114, 30);
            bthuydon.TabIndex = 28;
            bthuydon.Text = "Huỷ Đơn";
            bthuydon.UseVisualStyleBackColor = true;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(735, 28);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // btquaylai
            // 
            btquaylai.Location = new Point(629, 400);
            btquaylai.Name = "btquaylai";
            btquaylai.Size = new Size(94, 29);
            btquaylai.TabIndex = 37;
            btquaylai.Text = "Quay lại";
            btquaylai.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(11, 26);
            listView2.Name = "listView2";
            listView2.Size = new Size(262, 137);
            listView2.TabIndex = 23;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView2);
            groupBox1.Location = new Point(444, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 172);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // listView3
            // 
            listView3.Location = new Point(11, 26);
            listView3.Name = "listView3";
            listView3.Size = new Size(256, 146);
            listView3.TabIndex = 23;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView3);
            groupBox2.Location = new Point(444, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 173);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ghi chú";
            // 
            // Khachhang_donhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btquaylai);
            Controls.Add(groupBox4);
            Controls.Add(listdonhang);
            Controls.Add(menuStrip1);
            Controls.Add(btdanhgia);
            Controls.Add(bthuydon);
            Name = "Khachhang_donhang";
            Text = "Khachhang_donhang";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listdonhang;
        private Button btdanhgia;
        private ComboBox tbtinhtrang;
        private GroupBox groupBox4;
        private Button bthuydon;
        private Button btTimkiem;
        private Label label1;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button btquaylai;
        private ListView listView2;
        private GroupBox groupBox1;
        private ListView listView3;
        private GroupBox groupBox2;
    }
}