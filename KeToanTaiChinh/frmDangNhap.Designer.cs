namespace KeToanTaiChinh
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new huserControl.hButton();
            this.btnDangNhap = new huserControl.hButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.chkpass = new System.Windows.Forms.CheckBox();
            this.txtMatKhau = new huserControl.hTextBox();
            this.cbbNguoiDung = new huserControl.hComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 63);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(12, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(58, 51);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý thu phí";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.btnDangNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 186);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 55);
            this.panel2.TabIndex = 1;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai.Location = new System.Drawing.Point(385, 5);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(120, 46);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangNhap.Location = new System.Drawing.Point(259, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(120, 46);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkRemember);
            this.panel3.Controls.Add(this.chkpass);
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.cbbNguoiDung);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 123);
            this.panel3.TabIndex = 2;
            // 
            // chkRemember
            // 
            this.chkRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRemember.AutoSize = true;
            this.chkRemember.Checked = true;
            this.chkRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.chkRemember.Location = new System.Drawing.Point(359, 89);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(140, 26);
            this.chkRemember.TabIndex = 36;
            this.chkRemember.Text = "Nhớ mật khẩu";
            this.chkRemember.UseVisualStyleBackColor = true;
            this.chkRemember.Visible = false;
            this.chkRemember.CheckedChanged += new System.EventHandler(this.chkRemember_CheckedChanged);
            // 
            // chkpass
            // 
            this.chkpass.AutoSize = true;
            this.chkpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(87)))), ((int)(((byte)(118)))));
            this.chkpass.Location = new System.Drawing.Point(37, 89);
            this.chkpass.Name = "chkpass";
            this.chkpass.Size = new System.Drawing.Size(169, 26);
            this.chkpass.TabIndex = 35;
            this.chkpass.Text = "Hiển thị mật khẩu";
            this.chkpass.UseVisualStyleBackColor = true;
            this.chkpass.CheckedChanged += new System.EventHandler(this.chkpass_CheckedChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMatKhau.Location = new System.Drawing.Point(152, 48);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.ShortcutsEnabled = false;
            this.txtMatKhau.Size = new System.Drawing.Size(347, 34);
            this.txtMatKhau.TabIndex = 25;
            this.txtMatKhau.xBorderStyle = huserControl.hBorderStyle.Fixed3D;
            this.txtMatKhau.xChoPhepRong = false;
            this.txtMatKhau.xDataType = huserControl.mDataType.xStandard;
            this.txtMatKhau.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.txtMatKhau.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.xDefaultForeColor = System.Drawing.Color.Empty;
            this.txtMatKhau.xFontFocus = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.xGetYYYYmmdd = null;
            this.txtMatKhau.xGetYYYYmmddhhmmss = null;
            this.txtMatKhau.xInitialValue = "";
            this.txtMatKhau.xLable = null;
            this.txtMatKhau.xLayDulieu = true;
            this.txtMatKhau.xOneSpaceInText = true;
            this.txtMatKhau.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.txtMatKhau.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.txtMatKhau.xSelectForeColor = System.Drawing.Color.White;
            this.txtMatKhau.xTentruongDulieu = "";
            this.txtMatKhau.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtMatKhau.xYeucauNhapDulieu = true;
            // 
            // cbbNguoiDung
            // 
            this.cbbNguoiDung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNguoiDung.FormattingEnabled = true;
            this.cbbNguoiDung.Location = new System.Drawing.Point(152, 5);
            this.cbbNguoiDung.Name = "cbbNguoiDung";
            this.cbbNguoiDung.Size = new System.Drawing.Size(347, 34);
            this.cbbNguoiDung.TabIndex = 2;
            this.cbbNguoiDung.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.cbbNguoiDung.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNguoiDung.xDefaultForeColor = System.Drawing.Color.Empty;
            this.cbbNguoiDung.xDisplayField = "";
            this.cbbNguoiDung.xInitialValue = null;
            this.cbbNguoiDung.xLable = null;
            this.cbbNguoiDung.xLayDulieu = true;
            this.cbbNguoiDung.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.cbbNguoiDung.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.cbbNguoiDung.xSelectForeColor = System.Drawing.Color.White;
            this.cbbNguoiDung.xTentruongDulieu = "username";
            this.cbbNguoiDung.xTentruongDulieu_Ma = "id_user";
            this.cbbNguoiDung.xTextBoxBackColor = System.Drawing.Color.White;
            this.cbbNguoiDung.xUnderLine = false;
            this.cbbNguoiDung.xUnderlineColor = System.Drawing.Color.Blue;
            this.cbbNguoiDung.xYeucauNhapDulieu = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người dùng:";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 241);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private huserControl.hTextBox txtMatKhau;
        private huserControl.hComboBox cbbNguoiDung;
        private huserControl.hButton btnDangNhap;
        private huserControl.hButton btnQuayLai;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.CheckBox chkpass;
    }
}