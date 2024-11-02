namespace KeToanTaiChinh
{
    partial class FrmPhanQuyenSuDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhanQuyenSuDung));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbChonQuyen = new huserControl.hComboBox();
            this.txtTenNguoiDung = new huserControl.hTextBox();
            this.txtMaDangNhap = new huserControl.hTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPhanQuyenSuDDung = new System.Windows.Forms.DataGridView();
            this.cChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cXemQuyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cThemQuyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cSuaQuyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cXoaQuyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyenSuDDung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.cbbChonQuyen);
            this.panel3.Controls.Add(this.txtTenNguoiDung);
            this.panel3.Controls.Add(this.txtMaDangNhap);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 42);
            this.panel3.TabIndex = 4;
            // 
            // cbbChonQuyen
            // 
            this.cbbChonQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbChonQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonQuyen.FormattingEnabled = true;
            this.cbbChonQuyen.Location = new System.Drawing.Point(705, 6);
            this.cbbChonQuyen.Name = "cbbChonQuyen";
            this.cbbChonQuyen.Size = new System.Drawing.Size(180, 30);
            this.cbbChonQuyen.TabIndex = 5;
            this.cbbChonQuyen.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.cbbChonQuyen.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonQuyen.xDefaultForeColor = System.Drawing.Color.Empty;
            this.cbbChonQuyen.xDisplayField = "";
            this.cbbChonQuyen.xInitialValue = null;
            this.cbbChonQuyen.xLable = null;
            this.cbbChonQuyen.xLayDulieu = true;
            this.cbbChonQuyen.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.cbbChonQuyen.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.cbbChonQuyen.xSelectForeColor = System.Drawing.Color.White;
            this.cbbChonQuyen.xTentruongDulieu = "";
            this.cbbChonQuyen.xTentruongDulieu_Ma = "";
            this.cbbChonQuyen.xTextBoxBackColor = System.Drawing.Color.White;
            this.cbbChonQuyen.xUnderLine = false;
            this.cbbChonQuyen.xUnderlineColor = System.Drawing.Color.Blue;
            this.cbbChonQuyen.xYeucauNhapDulieu = true;
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiDung.Location = new System.Drawing.Point(420, 6);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(165, 30);
            this.txtTenNguoiDung.TabIndex = 6;
            this.txtTenNguoiDung.xBorderStyle = huserControl.hBorderStyle.Fixed3D;
            this.txtTenNguoiDung.xChoPhepRong = false;
            this.txtTenNguoiDung.xDataType = huserControl.mDataType.xStandard;
            this.txtTenNguoiDung.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtTenNguoiDung.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiDung.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtTenNguoiDung.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiDung.xGetYYYYmmdd = null;
            this.txtTenNguoiDung.xGetYYYYmmddhhmmss = null;
            this.txtTenNguoiDung.xInitialValue = "";
            this.txtTenNguoiDung.xLable = null;
            this.txtTenNguoiDung.xLayDulieu = true;
            this.txtTenNguoiDung.xOneSpaceInText = true;
            this.txtTenNguoiDung.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtTenNguoiDung.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.txtTenNguoiDung.xSelectForeColor = System.Drawing.Color.White;
            this.txtTenNguoiDung.xTentruongDulieu = "";
            this.txtTenNguoiDung.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtTenNguoiDung.xYeucauNhapDulieu = true;
            // 
            // txtMaDangNhap
            // 
            this.txtMaDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDangNhap.Location = new System.Drawing.Point(140, 6);
            this.txtMaDangNhap.Name = "txtMaDangNhap";
            this.txtMaDangNhap.Size = new System.Drawing.Size(128, 30);
            this.txtMaDangNhap.TabIndex = 5;
            this.txtMaDangNhap.xBorderStyle = huserControl.hBorderStyle.Fixed3D;
            this.txtMaDangNhap.xChoPhepRong = false;
            this.txtMaDangNhap.xDataType = huserControl.mDataType.xStandard;
            this.txtMaDangNhap.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtMaDangNhap.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDangNhap.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtMaDangNhap.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDangNhap.xGetYYYYmmdd = null;
            this.txtMaDangNhap.xGetYYYYmmddhhmmss = null;
            this.txtMaDangNhap.xInitialValue = "";
            this.txtMaDangNhap.xLable = null;
            this.txtMaDangNhap.xLayDulieu = true;
            this.txtMaDangNhap.xOneSpaceInText = true;
            this.txtMaDangNhap.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtMaDangNhap.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.txtMaDangNhap.xSelectForeColor = System.Drawing.Color.White;
            this.txtMaDangNhap.xTentruongDulieu = "";
            this.txtMaDangNhap.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtMaDangNhap.xYeucauNhapDulieu = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn quyền:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên người dùng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã đăng nhập:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 54);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(20, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(42, 42);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phân quyền";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 66);
            this.panel2.TabIndex = 5;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(762, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(128, 60);
            this.btnDong.TabIndex = 77;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(631, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 60);
            this.btnLuu.TabIndex = 76;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvPhanQuyenSuDDung);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(897, 496);
            this.panel4.TabIndex = 6;
            // 
            // dgvPhanQuyenSuDDung
            // 
            this.dgvPhanQuyenSuDDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyenSuDDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChucNang,
            this.cXemQuyen,
            this.cThemQuyen,
            this.cSuaQuyen,
            this.cXoaQuyen});
            this.dgvPhanQuyenSuDDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanQuyenSuDDung.Location = new System.Drawing.Point(0, 0);
            this.dgvPhanQuyenSuDDung.Name = "dgvPhanQuyenSuDDung";
            this.dgvPhanQuyenSuDDung.RowHeadersWidth = 51;
            this.dgvPhanQuyenSuDDung.RowTemplate.Height = 24;
            this.dgvPhanQuyenSuDDung.Size = new System.Drawing.Size(897, 496);
            this.dgvPhanQuyenSuDDung.TabIndex = 1;
            // 
            // cChucNang
            // 
            this.cChucNang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cChucNang.HeaderText = "Chức năng";
            this.cChucNang.MinimumWidth = 6;
            this.cChucNang.Name = "cChucNang";
            // 
            // cXemQuyen
            // 
            this.cXemQuyen.HeaderText = "Xem quyền";
            this.cXemQuyen.MinimumWidth = 6;
            this.cXemQuyen.Name = "cXemQuyen";
            this.cXemQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cXemQuyen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cXemQuyen.Width = 125;
            // 
            // cThemQuyen
            // 
            this.cThemQuyen.HeaderText = "Thêm/Tính quyền";
            this.cThemQuyen.MinimumWidth = 6;
            this.cThemQuyen.Name = "cThemQuyen";
            this.cThemQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cThemQuyen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cThemQuyen.Width = 125;
            // 
            // cSuaQuyen
            // 
            this.cSuaQuyen.HeaderText = "Sửa/Điều chỉnh quyền";
            this.cSuaQuyen.MinimumWidth = 6;
            this.cSuaQuyen.Name = "cSuaQuyen";
            this.cSuaQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSuaQuyen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cSuaQuyen.Width = 125;
            // 
            // cXoaQuyen
            // 
            this.cXoaQuyen.HeaderText = "Xóa/Hủy quyền";
            this.cXoaQuyen.MinimumWidth = 6;
            this.cXoaQuyen.Name = "cXoaQuyen";
            this.cXoaQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cXoaQuyen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cXoaQuyen.Width = 125;
            // 
            // FrmPhanQuyenSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 658);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPhanQuyenSuDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyenSuDDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private huserControl.hComboBox cbbChonQuyen;
        private huserControl.hTextBox txtTenNguoiDung;
        private huserControl.hTextBox txtMaDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvPhanQuyenSuDDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChucNang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cXemQuyen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cThemQuyen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cSuaQuyen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cXoaQuyen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panel5;
    }
}