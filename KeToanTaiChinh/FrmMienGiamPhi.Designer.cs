namespace KeToanTaiChinh
{
    partial class FrmMienGiamPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMienGiamPhi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDanhDauGiamTheoGiaTri = new System.Windows.Forms.CheckBox();
            this.chkHocSinhCoMienGiam = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCongCuChon = new huserControl.hButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNhanDanhSachExcel = new huserControl.hButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.hComboBox2 = new huserControl.hComboBox();
            this.hComboBox1 = new huserControl.hComboBox();
            this.chkTuDongTinhLaiHocPhi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtThang = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMienGiamPhi = new System.Windows.Forms.DataGridView();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThietBiVatDungBanTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBanTruVeSinhPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToChucHoc2Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienNuocUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAnhVanNN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKyNangSongThucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMienGiamPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkDanhDauGiamTheoGiaTri);
            this.panel1.Controls.Add(this.chkHocSinhCoMienGiam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 46);
            this.panel1.TabIndex = 1;
            // 
            // chkDanhDauGiamTheoGiaTri
            // 
            this.chkDanhDauGiamTheoGiaTri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDanhDauGiamTheoGiaTri.AutoSize = true;
            this.chkDanhDauGiamTheoGiaTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDanhDauGiamTheoGiaTri.Location = new System.Drawing.Point(937, 11);
            this.chkDanhDauGiamTheoGiaTri.Name = "chkDanhDauGiamTheoGiaTri";
            this.chkDanhDauGiamTheoGiaTri.Size = new System.Drawing.Size(239, 26);
            this.chkDanhDauGiamTheoGiaTri.TabIndex = 5;
            this.chkDanhDauGiamTheoGiaTri.Text = "Đánh dấu giảm theo giá trị";
            this.chkDanhDauGiamTheoGiaTri.UseVisualStyleBackColor = true;
            // 
            // chkHocSinhCoMienGiam
            // 
            this.chkHocSinhCoMienGiam.AutoSize = true;
            this.chkHocSinhCoMienGiam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHocSinhCoMienGiam.Location = new System.Drawing.Point(16, 11);
            this.chkHocSinhCoMienGiam.Name = "chkHocSinhCoMienGiam";
            this.chkHocSinhCoMienGiam.Size = new System.Drawing.Size(353, 26);
            this.chkHocSinhCoMienGiam.TabIndex = 4;
            this.chkHocSinhCoMienGiam.Text = "Có thể hiện những học sinh có miễn giảm";
            this.chkHocSinhCoMienGiam.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCongCuChon);
            this.panel6.Controls.Add(this.btnLuu);
            this.panel6.Controls.Add(this.btnRefresh);
            this.panel6.Controls.Add(this.btnNhanDanhSachExcel);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.hComboBox2);
            this.panel6.Controls.Add(this.hComboBox1);
            this.panel6.Controls.Add(this.chkTuDongTinhLaiHocPhi);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.dtThang);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(903, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 534);
            this.panel6.TabIndex = 2;
            // 
            // btnCongCuChon
            // 
            this.btnCongCuChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongCuChon.Image = ((System.Drawing.Image)(resources.GetObject("btnCongCuChon.Image")));
            this.btnCongCuChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongCuChon.Location = new System.Drawing.Point(6, 367);
            this.btnCongCuChon.Name = "btnCongCuChon";
            this.btnCongCuChon.Size = new System.Drawing.Size(273, 51);
            this.btnCongCuChon.TabIndex = 76;
            this.btnCongCuChon.Text = "Công cụ chọn";
            this.btnCongCuChon.UseVisualStyleBackColor = true;
            this.btnCongCuChon.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(6, 466);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(135, 66);
            this.btnLuu.TabIndex = 75;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(145, 466);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 65);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnNhanDanhSachExcel
            // 
            this.btnNhanDanhSachExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanDanhSachExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanDanhSachExcel.Image")));
            this.btnNhanDanhSachExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanDanhSachExcel.Location = new System.Drawing.Point(6, 151);
            this.btnNhanDanhSachExcel.Name = "btnNhanDanhSachExcel";
            this.btnNhanDanhSachExcel.Size = new System.Drawing.Size(273, 51);
            this.btnNhanDanhSachExcel.TabIndex = 73;
            this.btnNhanDanhSachExcel.Text = "Nhận danh sách từ Excel";
            this.btnNhanDanhSachExcel.UseVisualStyleBackColor = true;
            this.btnNhanDanhSachExcel.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 37);
            this.panel5.TabIndex = 35;
            // 
            // hComboBox2
            // 
            this.hComboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hComboBox2.FormattingEnabled = true;
            this.hComboBox2.Location = new System.Drawing.Point(69, 114);
            this.hComboBox2.Name = "hComboBox2";
            this.hComboBox2.Size = new System.Drawing.Size(207, 30);
            this.hComboBox2.TabIndex = 34;
            this.hComboBox2.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.hComboBox2.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hComboBox2.xDefaultForeColor = System.Drawing.Color.Empty;
            this.hComboBox2.xDisplayField = "";
            this.hComboBox2.xInitialValue = null;
            this.hComboBox2.xLable = null;
            this.hComboBox2.xLayDulieu = true;
            this.hComboBox2.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.hComboBox2.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.hComboBox2.xSelectForeColor = System.Drawing.Color.White;
            this.hComboBox2.xTentruongDulieu = "";
            this.hComboBox2.xTentruongDulieu_Ma = "";
            this.hComboBox2.xTextBoxBackColor = System.Drawing.Color.White;
            this.hComboBox2.xUnderLine = false;
            this.hComboBox2.xUnderlineColor = System.Drawing.Color.Blue;
            this.hComboBox2.xYeucauNhapDulieu = true;
            // 
            // hComboBox1
            // 
            this.hComboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hComboBox1.FormattingEnabled = true;
            this.hComboBox1.Location = new System.Drawing.Point(69, 79);
            this.hComboBox1.Name = "hComboBox1";
            this.hComboBox1.Size = new System.Drawing.Size(207, 30);
            this.hComboBox1.TabIndex = 33;
            this.hComboBox1.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.hComboBox1.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hComboBox1.xDefaultForeColor = System.Drawing.Color.Empty;
            this.hComboBox1.xDisplayField = "";
            this.hComboBox1.xInitialValue = null;
            this.hComboBox1.xLable = null;
            this.hComboBox1.xLayDulieu = true;
            this.hComboBox1.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.hComboBox1.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.hComboBox1.xSelectForeColor = System.Drawing.Color.White;
            this.hComboBox1.xTentruongDulieu = "";
            this.hComboBox1.xTentruongDulieu_Ma = "";
            this.hComboBox1.xTextBoxBackColor = System.Drawing.Color.White;
            this.hComboBox1.xUnderLine = false;
            this.hComboBox1.xUnderlineColor = System.Drawing.Color.Blue;
            this.hComboBox1.xYeucauNhapDulieu = true;
            // 
            // chkTuDongTinhLaiHocPhi
            // 
            this.chkTuDongTinhLaiHocPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTuDongTinhLaiHocPhi.AutoSize = true;
            this.chkTuDongTinhLaiHocPhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTuDongTinhLaiHocPhi.Location = new System.Drawing.Point(2, 424);
            this.chkTuDongTinhLaiHocPhi.Name = "chkTuDongTinhLaiHocPhi";
            this.chkTuDongTinhLaiHocPhi.Size = new System.Drawing.Size(221, 26);
            this.chkTuDongTinhLaiHocPhi.TabIndex = 32;
            this.chkTuDongTinhLaiHocPhi.Text = "Tự động tính lại học phí";
            this.chkTuDongTinhLaiHocPhi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Phí:";
            // 
            // dtThang
            // 
            this.dtThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtThang.CustomFormat = "MM/yyyy";
            this.dtThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThang.Location = new System.Drawing.Point(69, 44);
            this.dtThang.Name = "dtThang";
            this.dtThang.Size = new System.Drawing.Size(207, 30);
            this.dtThang.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tháng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMienGiamPhi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 534);
            this.panel2.TabIndex = 3;
            // 
            // dgvMienGiamPhi
            // 
            this.dgvMienGiamPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMienGiamPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cMaSo,
            this.cHo,
            this.cTen,
            this.cThietBiVatDungBanTru,
            this.cBanTruVeSinhPhi,
            this.cHocPhi,
            this.cToChucHoc2Buoi,
            this.cTienNuocUong,
            this.cAnhVanNN,
            this.cKyNangSongThucHanh});
            this.dgvMienGiamPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMienGiamPhi.Location = new System.Drawing.Point(0, 0);
            this.dgvMienGiamPhi.Name = "dgvMienGiamPhi";
            this.dgvMienGiamPhi.RowHeadersWidth = 51;
            this.dgvMienGiamPhi.RowTemplate.Height = 24;
            this.dgvMienGiamPhi.Size = new System.Drawing.Size(903, 534);
            this.dgvMienGiamPhi.TabIndex = 0;
            // 
            // cStt
            // 
            this.cStt.HeaderText = "Stt";
            this.cStt.MinimumWidth = 6;
            this.cStt.Name = "cStt";
            this.cStt.Width = 90;
            // 
            // cMaSo
            // 
            this.cMaSo.HeaderText = "Mã số";
            this.cMaSo.MinimumWidth = 6;
            this.cMaSo.Name = "cMaSo";
            this.cMaSo.Width = 125;
            // 
            // cHo
            // 
            this.cHo.HeaderText = "Họ";
            this.cHo.MinimumWidth = 6;
            this.cHo.Name = "cHo";
            this.cHo.Width = 125;
            // 
            // cTen
            // 
            this.cTen.HeaderText = "Tên";
            this.cTen.MinimumWidth = 6;
            this.cTen.Name = "cTen";
            this.cTen.Width = 125;
            // 
            // cThietBiVatDungBanTru
            // 
            this.cThietBiVatDungBanTru.HeaderText = "Thiết bị vật dụng bán trú/năm";
            this.cThietBiVatDungBanTru.MinimumWidth = 6;
            this.cThietBiVatDungBanTru.Name = "cThietBiVatDungBanTru";
            this.cThietBiVatDungBanTru.Width = 150;
            // 
            // cBanTruVeSinhPhi
            // 
            this.cBanTruVeSinhPhi.HeaderText = "Bán trú và vệ sinh phí";
            this.cBanTruVeSinhPhi.MinimumWidth = 6;
            this.cBanTruVeSinhPhi.Name = "cBanTruVeSinhPhi";
            this.cBanTruVeSinhPhi.Width = 125;
            // 
            // cHocPhi
            // 
            this.cHocPhi.HeaderText = "Học phí";
            this.cHocPhi.MinimumWidth = 6;
            this.cHocPhi.Name = "cHocPhi";
            this.cHocPhi.Width = 125;
            // 
            // cToChucHoc2Buoi
            // 
            this.cToChucHoc2Buoi.HeaderText = "Tổ chức học 2 buổi";
            this.cToChucHoc2Buoi.MinimumWidth = 6;
            this.cToChucHoc2Buoi.Name = "cToChucHoc2Buoi";
            this.cToChucHoc2Buoi.Width = 125;
            // 
            // cTienNuocUong
            // 
            this.cTienNuocUong.HeaderText = "Tiền nước uống";
            this.cTienNuocUong.MinimumWidth = 6;
            this.cTienNuocUong.Name = "cTienNuocUong";
            this.cTienNuocUong.Width = 125;
            // 
            // cAnhVanNN
            // 
            this.cAnhVanNN.HeaderText = "Anh văn NN";
            this.cAnhVanNN.MinimumWidth = 6;
            this.cAnhVanNN.Name = "cAnhVanNN";
            this.cAnhVanNN.Width = 125;
            // 
            // cKyNangSongThucHanh
            // 
            this.cKyNangSongThucHanh.HeaderText = "Kỹ năng sống thực hành";
            this.cKyNangSongThucHanh.MinimumWidth = 6;
            this.cKyNangSongThucHanh.Name = "cKyNangSongThucHanh";
            this.cKyNangSongThucHanh.Width = 125;
            // 
            // FrmMienGiamPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMienGiamPhi";
            this.Text = "FrmMienGiamPhi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMienGiamPhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkDanhDauGiamTheoGiaTri;
        private System.Windows.Forms.CheckBox chkHocSinhCoMienGiam;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox chkTuDongTinhLaiHocPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private huserControl.hComboBox hComboBox2;
        private huserControl.hComboBox hComboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnRefresh;
        private huserControl.hButton btnNhanDanhSachExcel;
        private huserControl.hButton btnCongCuChon;
        private System.Windows.Forms.DataGridView dgvMienGiamPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThietBiVatDungBanTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBanTruVeSinhPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToChucHoc2Buoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienNuocUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAnhVanNN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKyNangSongThucHanh;
    }
}