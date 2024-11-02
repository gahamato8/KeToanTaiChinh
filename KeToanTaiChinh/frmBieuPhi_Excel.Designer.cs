namespace KeToanTaiChinh
{
    partial class frmBieuPhi_Excel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBieuPhi_Excel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hLabel1 = new huserControl.hLabel();
            this.labelTime = new huserControl.hLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new huserControl.hButton();
            this.btnDong = new huserControl.hButton();
            this.btnNhanTuExcel = new huserControl.hButton();
            this.btnXuatSangExcel = new huserControl.hButton();
            this.chkKhongTheHienMucThuCuaKhoi = new huserControl.hCheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkTuDongDien = new huserControl.hCheckBox();
            this.nudSoNgayTinhTienAn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hComboBox1 = new huserControl.hComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvBieuPhi = new System.Windows.Forms.DataGridView();
            this.cMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBieuPhiKhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienAn1Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBanTruVeSinhPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienNuocUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAnhVanNN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKyNangSongThucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKyNangSong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNangKhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToChucHocTCTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMonNKBoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTiengNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDVCNTTChuyenDoiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTraLaiTienNangKhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayTinhTienAn)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBieuPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.hLabel1);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 48);
            this.panel1.TabIndex = 0;
            // 
            // hLabel1
            // 
            this.hLabel1.AutoSize = true;
            this.hLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hLabel1.Location = new System.Drawing.Point(195, 8);
            this.hLabel1.Name = "hLabel1";
            this.hLabel1.Size = new System.Drawing.Size(78, 35);
            this.hLabel1.TabIndex = 2;
            this.hLabel1.Text = "tháng";
            this.hLabel1.xBorderStyle = huserControl.hBorderStyle.Fixed3D;
            this.hLabel1.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(266, 7);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(127, 35);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "MM/yyyy";
            this.labelTime.xBorderStyle = huserControl.hBorderStyle.Fixed3D;
            this.labelTime.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(32, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 47);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biểu phí";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnNhanTuExcel);
            this.panel2.Controls.Add(this.btnXuatSangExcel);
            this.panel2.Controls.Add(this.chkKhongTheHienMucThuCuaKhoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 61);
            this.panel2.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(983, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 55);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1101, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 55);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnNhanTuExcel
            // 
            this.btnNhanTuExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNhanTuExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanTuExcel.Image")));
            this.btnNhanTuExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanTuExcel.Location = new System.Drawing.Point(488, 3);
            this.btnNhanTuExcel.Name = "btnNhanTuExcel";
            this.btnNhanTuExcel.Size = new System.Drawing.Size(187, 55);
            this.btnNhanTuExcel.TabIndex = 2;
            this.btnNhanTuExcel.Text = "Nhận từ excel";
            this.btnNhanTuExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanTuExcel.UseVisualStyleBackColor = true;
            this.btnNhanTuExcel.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnXuatSangExcel
            // 
            this.btnXuatSangExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatSangExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatSangExcel.Image")));
            this.btnXuatSangExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatSangExcel.Location = new System.Drawing.Point(299, 3);
            this.btnXuatSangExcel.Name = "btnXuatSangExcel";
            this.btnXuatSangExcel.Size = new System.Drawing.Size(187, 55);
            this.btnXuatSangExcel.TabIndex = 1;
            this.btnXuatSangExcel.Text = "Xuất sang excel";
            this.btnXuatSangExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatSangExcel.UseVisualStyleBackColor = true;
            this.btnXuatSangExcel.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnXuatSangExcel.Click += new System.EventHandler(this.btnXuatSangExcel_Click);
            // 
            // chkKhongTheHienMucThuCuaKhoi
            // 
            this.chkKhongTheHienMucThuCuaKhoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkKhongTheHienMucThuCuaKhoi.Location = new System.Drawing.Point(9, 17);
            this.chkKhongTheHienMucThuCuaKhoi.Name = "chkKhongTheHienMucThuCuaKhoi";
            this.chkKhongTheHienMucThuCuaKhoi.Size = new System.Drawing.Size(287, 26);
            this.chkKhongTheHienMucThuCuaKhoi.TabIndex = 0;
            this.chkKhongTheHienMucThuCuaKhoi.Text = "Không thể hiện mức thu của khối";
            this.chkKhongTheHienMucThuCuaKhoi.UnderlineHeight = 1.5F;
            this.chkKhongTheHienMucThuCuaKhoi.UseVisualStyleBackColor = true;
            this.chkKhongTheHienMucThuCuaKhoi.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.chkKhongTheHienMucThuCuaKhoi.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKhongTheHienMucThuCuaKhoi.xDefaultForeColor = System.Drawing.Color.Empty;
            this.chkKhongTheHienMucThuCuaKhoi.xInitialValue = false;
            this.chkKhongTheHienMucThuCuaKhoi.xLable = null;
            this.chkKhongTheHienMucThuCuaKhoi.xLayDulieu = true;
            this.chkKhongTheHienMucThuCuaKhoi.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.chkKhongTheHienMucThuCuaKhoi.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.chkKhongTheHienMucThuCuaKhoi.xSelectForeColor = System.Drawing.Color.White;
            this.chkKhongTheHienMucThuCuaKhoi.xTentruongDulieu = "";
            this.chkKhongTheHienMucThuCuaKhoi.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkKhongTheHienMucThuCuaKhoi.xValue = false;
            this.chkKhongTheHienMucThuCuaKhoi.xYeucauNhapDulieu = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkTuDongDien);
            this.panel3.Controls.Add(this.nudSoNgayTinhTienAn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.hComboBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1216, 37);
            this.panel3.TabIndex = 2;
            // 
            // chkTuDongDien
            // 
            this.chkTuDongDien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTuDongDien.AutoSize = true;
            this.chkTuDongDien.Location = new System.Drawing.Point(909, 4);
            this.chkTuDongDien.Name = "chkTuDongDien";
            this.chkTuDongDien.Size = new System.Drawing.Size(300, 26);
            this.chkTuDongDien.TabIndex = 4;
            this.chkTuDongDien.Text = "Tự động điền mức phí xuống dưới";
            this.chkTuDongDien.UnderlineHeight = 1.5F;
            this.chkTuDongDien.UseVisualStyleBackColor = true;
            this.chkTuDongDien.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.chkTuDongDien.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTuDongDien.xDefaultForeColor = System.Drawing.Color.Empty;
            this.chkTuDongDien.xInitialValue = false;
            this.chkTuDongDien.xLable = null;
            this.chkTuDongDien.xLayDulieu = true;
            this.chkTuDongDien.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.chkTuDongDien.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.chkTuDongDien.xSelectForeColor = System.Drawing.Color.White;
            this.chkTuDongDien.xTentruongDulieu = "";
            this.chkTuDongDien.xUnderLineColor = System.Drawing.Color.LightGray;
            this.chkTuDongDien.xValue = false;
            this.chkTuDongDien.xYeucauNhapDulieu = true;
            // 
            // nudSoNgayTinhTienAn
            // 
            this.nudSoNgayTinhTienAn.Location = new System.Drawing.Point(553, 2);
            this.nudSoNgayTinhTienAn.Name = "nudSoNgayTinhTienAn";
            this.nudSoNgayTinhTienAn.Size = new System.Drawing.Size(63, 30);
            this.nudSoNgayTinhTienAn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số ngày tính tiền ăn(ví dụ)";
            // 
            // hComboBox1
            // 
            this.hComboBox1.FormattingEnabled = true;
            this.hComboBox1.Location = new System.Drawing.Point(97, 2);
            this.hComboBox1.Name = "hComboBox1";
            this.hComboBox1.Size = new System.Drawing.Size(227, 30);
            this.hComboBox1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khối,lớp:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvBieuPhi);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1216, 427);
            this.panel5.TabIndex = 3;
            // 
            // dgvBieuPhi
            // 
            this.dgvBieuPhi.BackgroundColor = System.Drawing.Color.White;
            this.dgvBieuPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBieuPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaLop,
            this.cBieuPhiKhoiLop,
            this.cTongCong,
            this.cTienAn1Ngay,
            this.cBanTruVeSinhPhi,
            this.cTienNuocUong,
            this.cAnhVanNN,
            this.cKyNangSongThucHanh,
            this.cKyNangSong,
            this.cNangKhieu,
            this.cToChucHocTCTA,
            this.cMonNKBoi,
            this.cIC3,
            this.cTiengNhat,
            this.cDVCNTTChuyenDoiSo,
            this.cTraLaiTienNangKhieu});
            this.dgvBieuPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBieuPhi.Location = new System.Drawing.Point(0, 0);
            this.dgvBieuPhi.Name = "dgvBieuPhi";
            this.dgvBieuPhi.RowHeadersWidth = 51;
            this.dgvBieuPhi.RowTemplate.Height = 24;
            this.dgvBieuPhi.Size = new System.Drawing.Size(1216, 427);
            this.dgvBieuPhi.TabIndex = 0;
            // 
            // cMaLop
            // 
            this.cMaLop.HeaderText = "Mã lớp";
            this.cMaLop.MinimumWidth = 6;
            this.cMaLop.Name = "cMaLop";
            this.cMaLop.Width = 125;
            // 
            // cBieuPhiKhoiLop
            // 
            this.cBieuPhiKhoiLop.HeaderText = "Tên lớp";
            this.cBieuPhiKhoiLop.MinimumWidth = 6;
            this.cBieuPhiKhoiLop.Name = "cBieuPhiKhoiLop";
            this.cBieuPhiKhoiLop.Width = 125;
            // 
            // cTongCong
            // 
            this.cTongCong.HeaderText = "Tổng cộng";
            this.cTongCong.MinimumWidth = 6;
            this.cTongCong.Name = "cTongCong";
            this.cTongCong.Width = 125;
            // 
            // cTienAn1Ngay
            // 
            this.cTienAn1Ngay.HeaderText = "Tiền ăn (1 ngày)";
            this.cTienAn1Ngay.MinimumWidth = 6;
            this.cTienAn1Ngay.Name = "cTienAn1Ngay";
            this.cTienAn1Ngay.Width = 125;
            // 
            // cBanTruVeSinhPhi
            // 
            this.cBanTruVeSinhPhi.HeaderText = "Bán trú và Vệ sinh phí";
            this.cBanTruVeSinhPhi.MinimumWidth = 6;
            this.cBanTruVeSinhPhi.Name = "cBanTruVeSinhPhi";
            this.cBanTruVeSinhPhi.Width = 125;
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
            // cKyNangSong
            // 
            this.cKyNangSong.HeaderText = "Kỹ năng sống";
            this.cKyNangSong.MinimumWidth = 6;
            this.cKyNangSong.Name = "cKyNangSong";
            this.cKyNangSong.Width = 125;
            // 
            // cNangKhieu
            // 
            this.cNangKhieu.HeaderText = "Năng khiếu";
            this.cNangKhieu.MinimumWidth = 6;
            this.cNangKhieu.Name = "cNangKhieu";
            this.cNangKhieu.Width = 125;
            // 
            // cToChucHocTCTA
            // 
            this.cToChucHocTCTA.HeaderText = "Tổ chức học TCTA";
            this.cToChucHocTCTA.MinimumWidth = 6;
            this.cToChucHocTCTA.Name = "cToChucHocTCTA";
            this.cToChucHocTCTA.Width = 125;
            // 
            // cMonNKBoi
            // 
            this.cMonNKBoi.HeaderText = "Môn NK Bơi";
            this.cMonNKBoi.MinimumWidth = 6;
            this.cMonNKBoi.Name = "cMonNKBoi";
            this.cMonNKBoi.Width = 125;
            // 
            // cIC3
            // 
            this.cIC3.HeaderText = "IC3";
            this.cIC3.MinimumWidth = 6;
            this.cIC3.Name = "cIC3";
            this.cIC3.Width = 125;
            // 
            // cTiengNhat
            // 
            this.cTiengNhat.HeaderText = "Tiếng Nhật";
            this.cTiengNhat.MinimumWidth = 6;
            this.cTiengNhat.Name = "cTiengNhat";
            this.cTiengNhat.Width = 125;
            // 
            // cDVCNTTChuyenDoiSo
            // 
            this.cDVCNTTChuyenDoiSo.HeaderText = "DV CNTT và Chuyển đổi số";
            this.cDVCNTTChuyenDoiSo.MinimumWidth = 6;
            this.cDVCNTTChuyenDoiSo.Name = "cDVCNTTChuyenDoiSo";
            this.cDVCNTTChuyenDoiSo.Width = 125;
            // 
            // cTraLaiTienNangKhieu
            // 
            this.cTraLaiTienNangKhieu.HeaderText = "Trả lại tiền năng khiếu";
            this.cTraLaiTienNangKhieu.MinimumWidth = 6;
            this.cTraLaiTienNangKhieu.Name = "cTraLaiTienNangKhieu";
            this.cTraLaiTienNangKhieu.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBieuPhi_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBieuPhi_Excel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgayTinhTienAn)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBieuPhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private huserControl.hComboBox hComboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private huserControl.hCheckBox chkTuDongDien;
        private System.Windows.Forms.NumericUpDown nudSoNgayTinhTienAn;
        private System.Windows.Forms.DataGridView dgvBieuPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBieuPhiKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienAn1Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBanTruVeSinhPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienNuocUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAnhVanNN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKyNangSongThucHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKyNangSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNangKhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToChucHocTCTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMonNKBoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTiengNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDVCNTTChuyenDoiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTraLaiTienNangKhieu;
        private huserControl.hButton btnXuatSangExcel;
        private huserControl.hCheckBox chkKhongTheHienMucThuCuaKhoi;
        private huserControl.hButton btnLuu;
        private huserControl.hButton btnDong;
        private huserControl.hButton btnNhanTuExcel;
        private huserControl.hLabel labelTime;
        private System.Windows.Forms.Timer timer1;
        private huserControl.hLabel hLabel1;
    }
}