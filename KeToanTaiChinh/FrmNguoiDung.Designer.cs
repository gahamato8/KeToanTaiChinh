namespace KeToanTaiChinh
{
    partial class FrmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguoiDung));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new huserControl.hButton();
            this.btnDoiMatKhau = new huserControl.hButton();
            this.btnPhanQuyenSuDung = new huserControl.hButton();
            this.btnSua = new huserControl.hButton();
            this.btnThemNguoiDung = new huserControl.hButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSachNguoiDung = new System.Windows.Forms.DataGridView();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Controls.Add(this.btnPhanQuyenSuDung);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThemNguoiDung);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(912, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 580);
            this.panel1.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(7, 233);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(267, 48);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(7, 184);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(267, 48);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnPhanQuyenSuDung
            // 
            this.btnPhanQuyenSuDung.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyenSuDung.Image")));
            this.btnPhanQuyenSuDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanQuyenSuDung.Location = new System.Drawing.Point(7, 135);
            this.btnPhanQuyenSuDung.Name = "btnPhanQuyenSuDung";
            this.btnPhanQuyenSuDung.Size = new System.Drawing.Size(267, 48);
            this.btnPhanQuyenSuDung.TabIndex = 3;
            this.btnPhanQuyenSuDung.Text = "Phân quyền sử dụng";
            this.btnPhanQuyenSuDung.UseVisualStyleBackColor = true;
            this.btnPhanQuyenSuDung.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnPhanQuyenSuDung.Click += new System.EventHandler(this.btnPhanQuyenSuDung_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(7, 86);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(267, 48);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNguoiDung.Image")));
            this.btnThemNguoiDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNguoiDung.Location = new System.Drawing.Point(7, 36);
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.Size = new System.Drawing.Size(267, 48);
            this.btnThemNguoiDung.TabIndex = 1;
            this.btnThemNguoiDung.Text = "Thêm người dùng";
            this.btnThemNguoiDung.UseVisualStyleBackColor = true;
            this.btnThemNguoiDung.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 31);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSachNguoiDung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 580);
            this.panel2.TabIndex = 2;
            // 
            // dgvDanhSachNguoiDung
            // 
            this.dgvDanhSachNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cMaDangNhap,
            this.cTenNguoiDung});
            this.dgvDanhSachNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachNguoiDung.Name = "dgvDanhSachNguoiDung";
            this.dgvDanhSachNguoiDung.RowHeadersWidth = 51;
            this.dgvDanhSachNguoiDung.RowTemplate.Height = 24;
            this.dgvDanhSachNguoiDung.Size = new System.Drawing.Size(912, 580);
            this.dgvDanhSachNguoiDung.TabIndex = 0;
            // 
            // cStt
            // 
            this.cStt.HeaderText = "Stt";
            this.cStt.MinimumWidth = 6;
            this.cStt.Name = "cStt";
            this.cStt.Width = 125;
            // 
            // cMaDangNhap
            // 
            this.cMaDangNhap.HeaderText = "Mã đăng nhập";
            this.cMaDangNhap.MinimumWidth = 6;
            this.cMaDangNhap.Name = "cMaDangNhap";
            this.cMaDangNhap.Width = 125;
            // 
            // cTenNguoiDung
            // 
            this.cTenNguoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTenNguoiDung.HeaderText = "Tên người dùng";
            this.cTenNguoiDung.MinimumWidth = 6;
            this.cTenNguoiDung.Name = "cTenNguoiDung";
            // 
            // FrmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNguoiDung";
            this.Text = "Danh sách người dùng";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private huserControl.hButton btnThemNguoiDung;
        private huserControl.hButton btnDoiMatKhau;
        private huserControl.hButton btnPhanQuyenSuDung;
        private huserControl.hButton btnSua;
        private huserControl.hButton btnXoa;
        private System.Windows.Forms.DataGridView dgvDanhSachNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNguoiDung;
    }
}