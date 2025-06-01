namespace QLKS2
{
    partial class frmPhong
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
            this.cboMaLP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.BtnBo = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            this.BtnHienThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMaLP
            // 
            this.cboMaLP.FormattingEnabled = true;
            this.cboMaLP.Location = new System.Drawing.Point(1009, 49);
            this.cboMaLP.Name = "cboMaLP";
            this.cboMaLP.Size = new System.Drawing.Size(160, 24);
            this.cboMaLP.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(910, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Loại phòng";
            // 
            // txtTT
            // 
            this.txtTT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTT.Location = new System.Drawing.Point(559, 49);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(183, 22);
            this.txtTT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trạng thái";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMaPhong.Location = new System.Drawing.Point(203, 51);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(115, 22);
            this.txtMaPhong.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 0;
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTimKiem.Location = new System.Drawing.Point(927, 49);
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
            this.BtnLuu.Location = new System.Drawing.Point(782, 49);
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
            this.BtnBo.Location = new System.Drawing.Point(639, 49);
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
            this.BtnSua.Location = new System.Drawing.Point(498, 49);
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
            this.BtnXoa.Location = new System.Drawing.Point(356, 49);
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
            this.BtnThem.Location = new System.Drawing.Point(215, 49);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(103, 27);
            this.BtnThem.TabIndex = 1;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
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
            this.panel2.Location = new System.Drawing.Point(1, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 114);
            this.panel2.TabIndex = 13;
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnQuayLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnQuayLai.Location = new System.Drawing.Point(1076, 49);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(103, 27);
            this.BtnQuayLai.TabIndex = 7;
            this.BtnQuayLai.Text = "Quay lại";
            this.BtnQuayLai.UseVisualStyleBackColor = false;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // BtnHienThi
            // 
            this.BtnHienThi.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnHienThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHienThi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnHienThi.Location = new System.Drawing.Point(80, 49);
            this.BtnHienThi.Name = "BtnHienThi";
            this.BtnHienThi.Size = new System.Drawing.Size(103, 27);
            this.BtnHienThi.TabIndex = 0;
            this.BtnHienThi.Text = "Hiển thị ";
            this.BtnHienThi.UseVisualStyleBackColor = false;
            this.BtnHienThi.Click += new System.EventHandler(this.BtnHienThi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC PHÒNG";
            // 
            // dgvP
            // 
            this.dgvP.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Location = new System.Drawing.Point(1, 95);
            this.dgvP.Name = "dgvP";
            this.dgvP.RowHeadersWidth = 51;
            this.dgvP.RowTemplate.Height = 24;
            this.dgvP.Size = new System.Drawing.Size(1236, 357);
            this.dgvP.TabIndex = 11;
            this.dgvP.SelectionChanged += new System.EventHandler(this.dgvP_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.cboMaLP);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 98);
            this.panel1.TabIndex = 12;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvP);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhong";
            this.Text = "frmPhong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhong_FormClosing);
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaLP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button BtnBo;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnQuayLai;
        private System.Windows.Forms.Button BtnHienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.Panel panel1;
    }
}