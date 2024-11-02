namespace KeToanTaiChinh
{
    partial class FrmBieuPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBieuPhi));
            this.chkThemTenPhiVaoDienGiai = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnChuanHoaBieuPhi = new huserControl.hButton();
            this.btnXemNgangNhatXuatExcel = new huserControl.hButton();
            this.btnChonMucPhiCungNhau = new huserControl.hButton();
            this.btnMucPhiLienQuanNhau = new huserControl.hButton();
            this.btnBotTatCaPhi = new huserControl.hButton();
            this.btnBotPhiDangChon = new huserControl.hButton();
            this.btnThemMucPhiKhoiLop = new huserControl.hButton();
            this.btnThemMucPhiChoThang = new huserControl.hButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBieuPhi = new System.Windows.Forms.DataGridView();
            this.cTenKhoangThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMucThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChonThu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cDienGiaiInGiayBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDanhSachThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCongThucTinhLienQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBieuPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // chkThemTenPhiVaoDienGiai
            // 
            this.chkThemTenPhiVaoDienGiai.AutoSize = true;
            this.chkThemTenPhiVaoDienGiai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThemTenPhiVaoDienGiai.Location = new System.Drawing.Point(65, 6);
            this.chkThemTenPhiVaoDienGiai.Name = "chkThemTenPhiVaoDienGiai";
            this.chkThemTenPhiVaoDienGiai.Size = new System.Drawing.Size(381, 26);
            this.chkThemTenPhiVaoDienGiai.TabIndex = 0;
            this.chkThemTenPhiVaoDienGiai.Text = "Thêm tên phí vào diễn giải(nếu có diễn giải)";
            this.chkThemTenPhiVaoDienGiai.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkThemTenPhiVaoDienGiai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 36);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnChuanHoaBieuPhi);
            this.panel6.Controls.Add(this.btnXemNgangNhatXuatExcel);
            this.panel6.Controls.Add(this.btnChonMucPhiCungNhau);
            this.panel6.Controls.Add(this.btnMucPhiLienQuanNhau);
            this.panel6.Controls.Add(this.btnBotTatCaPhi);
            this.panel6.Controls.Add(this.btnBotPhiDangChon);
            this.panel6.Controls.Add(this.btnThemMucPhiKhoiLop);
            this.panel6.Controls.Add(this.btnThemMucPhiChoThang);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.dtThang);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(906, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 548);
            this.panel6.TabIndex = 42;
            // 
            // btnChuanHoaBieuPhi
            // 
            this.btnChuanHoaBieuPhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuanHoaBieuPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnChuanHoaBieuPhi.Image")));
            this.btnChuanHoaBieuPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuanHoaBieuPhi.Location = new System.Drawing.Point(4, 431);
            this.btnChuanHoaBieuPhi.Name = "btnChuanHoaBieuPhi";
            this.btnChuanHoaBieuPhi.Size = new System.Drawing.Size(276, 51);
            this.btnChuanHoaBieuPhi.TabIndex = 52;
            this.btnChuanHoaBieuPhi.Text = "Chuẩn hóa biểu phí";
            this.btnChuanHoaBieuPhi.UseVisualStyleBackColor = true;
            this.btnChuanHoaBieuPhi.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnXemNgangNhatXuatExcel
            // 
            this.btnXemNgangNhatXuatExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemNgangNhatXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXemNgangNhatXuatExcel.Image")));
            this.btnXemNgangNhatXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemNgangNhatXuatExcel.Location = new System.Drawing.Point(4, 379);
            this.btnXemNgangNhatXuatExcel.Name = "btnXemNgangNhatXuatExcel";
            this.btnXemNgangNhatXuatExcel.Size = new System.Drawing.Size(276, 51);
            this.btnXemNgangNhatXuatExcel.TabIndex = 51;
            this.btnXemNgangNhatXuatExcel.Text = "Xem ngang, nhập xuất Excel";
            this.btnXemNgangNhatXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemNgangNhatXuatExcel.UseVisualStyleBackColor = true;
            this.btnXemNgangNhatXuatExcel.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnXemNgangNhatXuatExcel.Click += new System.EventHandler(this.btnXemNgangNhatXuatExcel_Click);
            // 
            // btnChonMucPhiCungNhau
            // 
            this.btnChonMucPhiCungNhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonMucPhiCungNhau.Image = ((System.Drawing.Image)(resources.GetObject("btnChonMucPhiCungNhau.Image")));
            this.btnChonMucPhiCungNhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonMucPhiCungNhau.Location = new System.Drawing.Point(4, 327);
            this.btnChonMucPhiCungNhau.Name = "btnChonMucPhiCungNhau";
            this.btnChonMucPhiCungNhau.Size = new System.Drawing.Size(276, 51);
            this.btnChonMucPhiCungNhau.TabIndex = 50;
            this.btnChonMucPhiCungNhau.Text = "Chọn mức phí cùng nhau";
            this.btnChonMucPhiCungNhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonMucPhiCungNhau.UseVisualStyleBackColor = true;
            this.btnChonMucPhiCungNhau.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnMucPhiLienQuanNhau
            // 
            this.btnMucPhiLienQuanNhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMucPhiLienQuanNhau.Image = ((System.Drawing.Image)(resources.GetObject("btnMucPhiLienQuanNhau.Image")));
            this.btnMucPhiLienQuanNhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMucPhiLienQuanNhau.Location = new System.Drawing.Point(4, 274);
            this.btnMucPhiLienQuanNhau.Name = "btnMucPhiLienQuanNhau";
            this.btnMucPhiLienQuanNhau.Size = new System.Drawing.Size(276, 51);
            this.btnMucPhiLienQuanNhau.TabIndex = 49;
            this.btnMucPhiLienQuanNhau.Text = "Mức phí liên quan nhau";
            this.btnMucPhiLienQuanNhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMucPhiLienQuanNhau.UseVisualStyleBackColor = true;
            this.btnMucPhiLienQuanNhau.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnBotTatCaPhi
            // 
            this.btnBotTatCaPhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotTatCaPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnBotTatCaPhi.Image")));
            this.btnBotTatCaPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBotTatCaPhi.Location = new System.Drawing.Point(4, 222);
            this.btnBotTatCaPhi.Name = "btnBotTatCaPhi";
            this.btnBotTatCaPhi.Size = new System.Drawing.Size(276, 51);
            this.btnBotTatCaPhi.TabIndex = 48;
            this.btnBotTatCaPhi.Text = "Bớt tất cả phí";
            this.btnBotTatCaPhi.UseVisualStyleBackColor = true;
            this.btnBotTatCaPhi.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnBotPhiDangChon
            // 
            this.btnBotPhiDangChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotPhiDangChon.Image = ((System.Drawing.Image)(resources.GetObject("btnBotPhiDangChon.Image")));
            this.btnBotPhiDangChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBotPhiDangChon.Location = new System.Drawing.Point(4, 170);
            this.btnBotPhiDangChon.Name = "btnBotPhiDangChon";
            this.btnBotPhiDangChon.Size = new System.Drawing.Size(276, 51);
            this.btnBotPhiDangChon.TabIndex = 47;
            this.btnBotPhiDangChon.Text = "Bớt phí đang chọn";
            this.btnBotPhiDangChon.UseVisualStyleBackColor = true;
            this.btnBotPhiDangChon.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnThemMucPhiKhoiLop
            // 
            this.btnThemMucPhiKhoiLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMucPhiKhoiLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMucPhiKhoiLop.Image")));
            this.btnThemMucPhiKhoiLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMucPhiKhoiLop.Location = new System.Drawing.Point(4, 118);
            this.btnThemMucPhiKhoiLop.Name = "btnThemMucPhiKhoiLop";
            this.btnThemMucPhiKhoiLop.Size = new System.Drawing.Size(276, 51);
            this.btnThemMucPhiKhoiLop.TabIndex = 46;
            this.btnThemMucPhiKhoiLop.Text = "Thêm mức phí Khối/Lớp";
            this.btnThemMucPhiKhoiLop.UseVisualStyleBackColor = true;
            this.btnThemMucPhiKhoiLop.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnThemMucPhiChoThang
            // 
            this.btnThemMucPhiChoThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMucPhiChoThang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMucPhiChoThang.Image")));
            this.btnThemMucPhiChoThang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMucPhiChoThang.Location = new System.Drawing.Point(4, 66);
            this.btnThemMucPhiChoThang.Name = "btnThemMucPhiChoThang";
            this.btnThemMucPhiChoThang.Size = new System.Drawing.Size(276, 51);
            this.btnThemMucPhiChoThang.TabIndex = 45;
            this.btnThemMucPhiChoThang.Text = "Thêm mức phí cho tháng";
            this.btnThemMucPhiChoThang.UseVisualStyleBackColor = true;
            this.btnThemMucPhiChoThang.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnThemMucPhiChoThang.Click += new System.EventHandler(this.btnThemMucPhiChoThang_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLuu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 485);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 63);
            this.panel5.TabIndex = 43;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(6, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(135, 63);
            this.btnLuu.TabIndex = 68;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 30);
            this.panel4.TabIndex = 42;
            // 
            // dtThang
            // 
            this.dtThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtThang.CustomFormat = "MM/yyyy";
            this.dtThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThang.Location = new System.Drawing.Point(68, 33);
            this.dtThang.Name = "dtThang";
            this.dtThang.Size = new System.Drawing.Size(211, 30);
            this.dtThang.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tháng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBieuPhi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 548);
            this.panel2.TabIndex = 43;
            // 
            // dgvBieuPhi
            // 
            this.dgvBieuPhi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBieuPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBieuPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenKhoangThu,
            this.cMucThu,
            this.cChonThu,
            this.cDienGiaiInGiayBao,
            this.cDanhSachThu,
            this.cCongThucTinhLienQuan,
            this.cMaPhi});
            this.dgvBieuPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBieuPhi.Location = new System.Drawing.Point(0, 0);
            this.dgvBieuPhi.Name = "dgvBieuPhi";
            this.dgvBieuPhi.RowHeadersWidth = 51;
            this.dgvBieuPhi.RowTemplate.Height = 24;
            this.dgvBieuPhi.Size = new System.Drawing.Size(906, 548);
            this.dgvBieuPhi.TabIndex = 0;
            this.dgvBieuPhi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBieuPhi_CellContentClick);
            this.dgvBieuPhi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBieuPhi_CellMouseDoubleClick);
            // 
            // cTenKhoangThu
            // 
            this.cTenKhoangThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenKhoangThu.HeaderText = "Tên khoảng thu";
            this.cTenKhoangThu.MinimumWidth = 6;
            this.cTenKhoangThu.Name = "cTenKhoangThu";
            // 
            // cMucThu
            // 
            this.cMucThu.HeaderText = "Mức thu";
            this.cMucThu.MinimumWidth = 6;
            this.cMucThu.Name = "cMucThu";
            this.cMucThu.Width = 125;
            // 
            // cChonThu
            // 
            this.cChonThu.HeaderText = "Chọn thu";
            this.cChonThu.MinimumWidth = 6;
            this.cChonThu.Name = "cChonThu";
            this.cChonThu.Width = 125;
            // 
            // cDienGiaiInGiayBao
            // 
            this.cDienGiaiInGiayBao.HeaderText = "Diễn giải in giấy báo";
            this.cDienGiaiInGiayBao.MinimumWidth = 6;
            this.cDienGiaiInGiayBao.Name = "cDienGiaiInGiayBao";
            this.cDienGiaiInGiayBao.Width = 125;
            // 
            // cDanhSachThu
            // 
            this.cDanhSachThu.HeaderText = "Danh sách thu(dữ kiến thu)";
            this.cDanhSachThu.MinimumWidth = 6;
            this.cDanhSachThu.Name = "cDanhSachThu";
            this.cDanhSachThu.Width = 125;
            // 
            // cCongThucTinhLienQuan
            // 
            this.cCongThucTinhLienQuan.HeaderText = "Công thức tính liên quan";
            this.cCongThucTinhLienQuan.MinimumWidth = 6;
            this.cCongThucTinhLienQuan.Name = "cCongThucTinhLienQuan";
            this.cCongThucTinhLienQuan.Width = 125;
            // 
            // cMaPhi
            // 
            this.cMaPhi.HeaderText = "Mã phí";
            this.cMaPhi.MinimumWidth = 6;
            this.cMaPhi.Name = "cMaPhi";
            this.cMaPhi.Width = 125;
            // 
            // FrmBieuPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBieuPhi";
            this.Text = " Biểu phí hàng tháng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBieuPhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkThemTenPhiVaoDienGiai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBieuPhi;
        private huserControl.hButton btnBotTatCaPhi;
        private huserControl.hButton btnBotPhiDangChon;
        private huserControl.hButton btnThemMucPhiKhoiLop;
        private huserControl.hButton btnThemMucPhiChoThang;
        private huserControl.hButton btnXemNgangNhatXuatExcel;
        private huserControl.hButton btnChonMucPhiCungNhau;
        private huserControl.hButton btnMucPhiLienQuanNhau;
        private huserControl.hButton btnChuanHoaBieuPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenKhoangThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMucThu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChonThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDienGiaiInGiayBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDanhSachThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCongThucTinhLienQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaPhi;
        private System.Windows.Forms.Button btnLuu;
    }
}