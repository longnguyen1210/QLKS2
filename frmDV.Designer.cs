namespace QLKS2
{
    partial class frmDV
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
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.BtnBo = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnHienThi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDV
            // 
            this.dgvDV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(0, 151);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(1232, 267);
            this.dgvDV.TabIndex = 8;
            this.dgvDV.SelectionChanged += new System.EventHandler(this.dgvDV_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC DỊCH VỤ";
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnQuayLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnQuayLai.Location = new System.Drawing.Point(1046, 49);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(103, 27);
            this.BtnQuayLai.TabIndex = 7;
            this.BtnQuayLai.Text = "Quay lại";
            this.BtnQuayLai.UseVisualStyleBackColor = false;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.BtnQuayLai);
            this.panel2.Controls.Add(this.BtnTimKiem);
            this.panel2.Controls.Add(this.BtnLuu);
            this.panel2.Controls.Add(this.BtnBo);
            this.panel2.Controls.Add(this.BtnSua);
            this.panel2.Controls.Add(this.BtnXoa);
            this.panel2.Controls.Add(this.BtnThem);
            this.panel2.Controls.Add(this.BtnHienThi);
            this.panel2.Location = new System.Drawing.Point(1, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 129);
            this.panel2.TabIndex = 10;
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTimKiem.Location = new System.Drawing.Point(910, 49);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(103, 27);
            this.BtnTimKiem.TabIndex = 6;
            this.BtnTimKiem.Text = "Tìm kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = false;
            this.BtnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLuu.Location = new System.Drawing.Point(771, 49);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(103, 27);
            this.BtnLuu.TabIndex = 5;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = false;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnBo
            // 
            this.BtnBo.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnBo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBo.Location = new System.Drawing.Point(623, 49);
            this.BtnBo.Name = "BtnBo";
            this.BtnBo.Size = new System.Drawing.Size(103, 27);
            this.BtnBo.TabIndex = 4;
            this.BtnBo.Text = "Bỏ";
            this.BtnBo.UseVisualStyleBackColor = false;
            this.BtnBo.Click += new System.EventHandler(this.BtnBo_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSua.Location = new System.Drawing.Point(481, 49);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(103, 27);
            this.BtnSua.TabIndex = 3;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = false;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnXoa.Location = new System.Drawing.Point(339, 49);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(103, 27);
            this.BtnXoa.TabIndex = 2;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnThem.Location = new System.Drawing.Point(204, 49);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(103, 27);
            this.BtnThem.TabIndex = 1;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnHienThi
            // 
            this.BtnHienThi.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnHienThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHienThi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHienThi.Location = new System.Drawing.Point(69, 49);
            this.BtnHienThi.Name = "BtnHienThi";
            this.BtnHienThi.Size = new System.Drawing.Size(103, 27);
            this.BtnHienThi.TabIndex = 0;
            this.BtnHienThi.Text = "Hiển thị ";
            this.BtnHienThi.UseVisualStyleBackColor = false;
            this.BtnHienThi.Click += new System.EventHandler(this.BtnHienThi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã dịch vụ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 0;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTenDichVu.Location = new System.Drawing.Point(203, 109);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(115, 22);
            this.txtTenDichVu.TabIndex = 8;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMaDichVu.Location = new System.Drawing.Point(203, 51);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(115, 22);
            this.txtMaDichVu.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.cboMaNhanVien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDonViTinh);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenDichVu);
            this.panel1.Controls.Add(this.txtMaDichVu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 156);
            this.panel1.TabIndex = 9;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(1009, 49);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(160, 24);
            this.cboMaNhanVien.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(907, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã nhân viên";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDonViTinh.Location = new System.Drawing.Point(759, 109);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(115, 22);
            this.txtDonViTinh.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSoLuong.Location = new System.Drawing.Point(759, 51);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(115, 22);
            this.txtSoLuong.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đơn vị tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(682, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDonGia.Location = new System.Drawing.Point(480, 109);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(115, 22);
            this.txtDonGia.TabIndex = 12;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTrangThai.Location = new System.Drawing.Point(480, 51);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(115, 22);
            this.txtTrangThai.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trạng thái";
            // 
            // frmDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 547);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDV";
            this.Text = "frmDV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDV_FormClosing);
            this.Load += new System.EventHandler(this.frmDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnQuayLai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button BtnBo;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnHienThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
    }
}