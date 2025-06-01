namespace QLKS2
{
    partial class frmKhachHang
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
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnHienThi = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.BtnBo = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnXoa.Location = new System.Drawing.Point(272, 45);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(103, 27);
            this.BtnXoa.TabIndex = 2;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnHienThi
            // 
            this.BtnHienThi.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnHienThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHienThi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHienThi.Location = new System.Drawing.Point(26, 45);
            this.BtnHienThi.Name = "BtnHienThi";
            this.BtnHienThi.Size = new System.Drawing.Size(103, 27);
            this.BtnHienThi.TabIndex = 0;
            this.BtnHienThi.Text = "Hiển thị ";
            this.BtnHienThi.UseVisualStyleBackColor = false;
            this.BtnHienThi.Click += new System.EventHandler(this.BtnHienThi_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDiaChi.Location = new System.Drawing.Point(718, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(254, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSDT.Location = new System.Drawing.Point(718, 51);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(154, 22);
            this.txtSDT.TabIndex = 9;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTenKH.Location = new System.Drawing.Point(228, 109);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(207, 22);
            this.txtTenKH.TabIndex = 8;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMaKH.Location = new System.Drawing.Point(228, 51);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(154, 22);
            this.txtMaKH.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTimKiem.Location = new System.Drawing.Point(789, 45);
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
            this.BtnLuu.Location = new System.Drawing.Point(660, 45);
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
            this.BtnBo.Location = new System.Drawing.Point(527, 45);
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
            this.BtnSua.Location = new System.Drawing.Point(394, 45);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(103, 27);
            this.BtnSua.TabIndex = 3;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = false;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
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
            this.panel2.Location = new System.Drawing.Point(2, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 129);
            this.panel2.TabIndex = 7;
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnQuayLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnQuayLai.Location = new System.Drawing.Point(911, 45);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(103, 27);
            this.BtnQuayLai.TabIndex = 7;
            this.BtnQuayLai.Text = "Quay lại";
            this.BtnQuayLai.UseVisualStyleBackColor = false;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnThem.Location = new System.Drawing.Point(144, 45);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(103, 27);
            this.BtnThem.TabIndex = 1;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 156);
            this.panel1.TabIndex = 6;
            // 
            // dgvKH
            // 
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(1, 156);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(1041, 187);
            this.dgvKH.TabIndex = 5;
            this.dgvKH.SelectionChanged += new System.EventHandler(this.dgvKH_SelectionChanged);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvKH);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnHienThi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button BtnBo;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnQuayLai;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKH;
    }
}