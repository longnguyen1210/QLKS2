namespace QLKS2
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuĐặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 161);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhmuc,
            this.mnuHoaDon,
            this.mnuPhieu,
            this.mnuChiTiet,
            this.mnuHuongDan,
            this.mnuReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(69, 26);
            this.mnuFile.Text = "Tệp tin";
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuDichVu,
            this.mnuLoaiPhong,
            this.phòngToolStripMenuItem});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(90, 26);
            this.mnuDanhmuc.Text = "Danh mục";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(224, 26);
            this.mnuKhachHang.Text = "Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuDichVu
            // 
            this.mnuDichVu.Name = "mnuDichVu";
            this.mnuDichVu.Size = new System.Drawing.Size(224, 26);
            this.mnuDichVu.Text = "Dịch vụ";
            this.mnuDichVu.Click += new System.EventHandler(this.mnuDichVu_Click);
            // 
            // mnuLoaiPhong
            // 
            this.mnuLoaiPhong.Name = "mnuLoaiPhong";
            this.mnuLoaiPhong.Size = new System.Drawing.Size(224, 26);
            this.mnuLoaiPhong.Text = "Loại phòng";
            this.mnuLoaiPhong.Click += new System.EventHandler(this.mnuLoaiPhong_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.mnuPhong_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngToolStripMenuItem,
            this.chiTiếtToolStripMenuItem});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(83, 26);
            this.mnuHoaDon.Text = "Hóa Đơn";
            // 
            // tổngToolStripMenuItem
            // 
            this.tổngToolStripMenuItem.Name = "tổngToolStripMenuItem";
            this.tổngToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.tổngToolStripMenuItem.Text = "Tổng";
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.chiTiếtToolStripMenuItem.Text = "Chi tiết";
            // 
            // mnuPhieu
            // 
            this.mnuPhieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuĐặtPhòngToolStripMenuItem,
            this.phiếuDịchVụToolStripMenuItem});
            this.mnuPhieu.Name = "mnuPhieu";
            this.mnuPhieu.Size = new System.Drawing.Size(59, 26);
            this.mnuPhieu.Text = "Phiếu";
            // 
            // phiếuĐặtPhòngToolStripMenuItem
            // 
            this.phiếuĐặtPhòngToolStripMenuItem.Name = "phiếuĐặtPhòngToolStripMenuItem";
            this.phiếuĐặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.phiếuĐặtPhòngToolStripMenuItem.Text = "Phiếu đặt phòng";
            // 
            // phiếuDịchVụToolStripMenuItem
            // 
            this.phiếuDịchVụToolStripMenuItem.Name = "phiếuDịchVụToolStripMenuItem";
            this.phiếuDịchVụToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.phiếuDịchVụToolStripMenuItem.Text = "Phiếu dịch vụ";
            // 
            // mnuChiTiet
            // 
            this.mnuChiTiet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtPhòngToolStripMenuItem,
            this.chiTiếtDịchVụToolStripMenuItem});
            this.mnuChiTiet.Name = "mnuChiTiet";
            this.mnuChiTiet.Size = new System.Drawing.Size(70, 26);
            this.mnuChiTiet.Text = "Chi tiết";
            // 
            // chiTiếtPhòngToolStripMenuItem
            // 
            this.chiTiếtPhòngToolStripMenuItem.Name = "chiTiếtPhòngToolStripMenuItem";
            this.chiTiếtPhòngToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.chiTiếtPhòngToolStripMenuItem.Text = "Chi tiết phòng";
            // 
            // chiTiếtDịchVụToolStripMenuItem
            // 
            this.chiTiếtDịchVụToolStripMenuItem.Name = "chiTiếtDịchVụToolStripMenuItem";
            this.chiTiếtDịchVụToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.chiTiếtDịchVụToolStripMenuItem.Text = "Chi tiết dịch vụ";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(98, 26);
            this.mnuHuongDan.Text = "Hướng dẫn";
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(77, 26);
            this.mnuReport.Text = "Báo cáo";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý khách sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tổngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieu;
        private System.Windows.Forms.ToolStripMenuItem phiếuĐặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChiTiet;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
    }
}

