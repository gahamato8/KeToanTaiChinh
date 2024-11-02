namespace KeToanTaiChinh
{
    partial class FrmNhatKyTruyCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhatKyTruyCap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbbUser = new huserControl.hComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNhatKyTruyCap = new System.Windows.Forms.DataGridView();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDUSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThucHien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyTruyCap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.cbbUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtDenNgay);
            this.panel1.Controls.Add(this.dtTuNgay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(907, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 580);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(4, 512);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 65);
            this.btnRefresh.TabIndex = 75;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // cbbUser
            // 
            this.cbbUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(53, 109);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(225, 30);
            this.cbbUser.TabIndex = 60;
            this.cbbUser.xDefaultBackGroundColor = System.Drawing.Color.Empty;
            this.cbbUser.xDefaultFont = new System.Drawing.Font("Tahoma", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUser.xDefaultForeColor = System.Drawing.Color.Empty;
            this.cbbUser.xDisplayField = "";
            this.cbbUser.xInitialValue = null;
            this.cbbUser.xLable = null;
            this.cbbUser.xLayDulieu = true;
            this.cbbUser.xPhanLoai = huserControl.mPhanLoaiDuLieu.Master;
            this.cbbUser.xSelectBackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(254)))));
            this.cbbUser.xSelectForeColor = System.Drawing.Color.White;
            this.cbbUser.xTentruongDulieu = "";
            this.cbbUser.xTentruongDulieu_Ma = "";
            this.cbbUser.xTextBoxBackColor = System.Drawing.Color.White;
            this.cbbUser.xUnderLine = false;
            this.cbbUser.xUnderlineColor = System.Drawing.Color.Blue;
            this.cbbUser.xYeucauNhapDulieu = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "User:";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(53, 74);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(225, 30);
            this.dtDenNgay.TabIndex = 56;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTuNgay.Location = new System.Drawing.Point(53, 40);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(225, 30);
            this.dtTuNgay.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Từ:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 34);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNhatKyTruyCap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 580);
            this.panel2.TabIndex = 2;
            // 
            // dgvNhatKyTruyCap
            // 
            this.dgvNhatKyTruyCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKyTruyCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cNgay,
            this.cIDUSE,
            this.cUser,
            this.cThucHien,
            this.cNoiDung});
            this.dgvNhatKyTruyCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhatKyTruyCap.Location = new System.Drawing.Point(0, 0);
            this.dgvNhatKyTruyCap.Name = "dgvNhatKyTruyCap";
            this.dgvNhatKyTruyCap.RowHeadersWidth = 51;
            this.dgvNhatKyTruyCap.RowTemplate.Height = 24;
            this.dgvNhatKyTruyCap.Size = new System.Drawing.Size(907, 580);
            this.dgvNhatKyTruyCap.TabIndex = 0;
            // 
            // cStt
            // 
            this.cStt.HeaderText = "Stt";
            this.cStt.MinimumWidth = 6;
            this.cStt.Name = "cStt";
            this.cStt.Width = 70;
            // 
            // cNgay
            // 
            this.cNgay.HeaderText = "Ngày";
            this.cNgay.MinimumWidth = 6;
            this.cNgay.Name = "cNgay";
            this.cNgay.Width = 125;
            // 
            // cIDUSE
            // 
            this.cIDUSE.HeaderText = "ID USE";
            this.cIDUSE.MinimumWidth = 6;
            this.cIDUSE.Name = "cIDUSE";
            this.cIDUSE.Width = 125;
            // 
            // cUser
            // 
            this.cUser.HeaderText = "User";
            this.cUser.MinimumWidth = 6;
            this.cUser.Name = "cUser";
            this.cUser.Width = 125;
            // 
            // cThucHien
            // 
            this.cThucHien.HeaderText = "Thực hiện";
            this.cThucHien.MinimumWidth = 6;
            this.cThucHien.Name = "cThucHien";
            this.cThucHien.Width = 125;
            // 
            // cNoiDung
            // 
            this.cNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNoiDung.HeaderText = "Nội dung";
            this.cNoiDung.MinimumWidth = 6;
            this.cNoiDung.Name = "cNoiDung";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(139, 512);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(138, 65);
            this.btnDong.TabIndex = 76;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmNhatKyTruyCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 580);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNhatKyTruyCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhật ký truy cập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKyTruyCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private huserControl.hComboBox cbbUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvNhatKyTruyCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDUSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThucHien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.Button btnDong;
    }
}