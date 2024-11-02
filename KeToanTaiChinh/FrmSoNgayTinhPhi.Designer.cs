namespace KeToanTaiChinh
{
    partial class FrmSoNgayTinhPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoNgayTinhPhi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhoiLopPhi = new huserControl.hButton();
            this.hButton1 = new huserControl.hButton();
            this.btnThemMucPhi = new huserControl.hButton();
            this.btnThemKhoiLop = new huserControl.hButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSoNgayTinhPhi = new System.Windows.Forms.DataGridView();
            this.cKhoiLopPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoNgayTinhPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNgayTinhPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnKhoiLopPhi);
            this.panel1.Controls.Add(this.hButton1);
            this.panel1.Controls.Add(this.btnThemMucPhi);
            this.panel1.Controls.Add(this.btnThemKhoiLop);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtThang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(904, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 496);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(145, 423);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 66);
            this.btnRefresh.TabIndex = 78;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(3, 423);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 66);
            this.btnLuu.TabIndex = 77;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnKhoiLopPhi
            // 
            this.btnKhoiLopPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiLopPhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiLopPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoiLopPhi.Image")));
            this.btnKhoiLopPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoiLopPhi.Location = new System.Drawing.Point(3, 224);
            this.btnKhoiLopPhi.Name = "btnKhoiLopPhi";
            this.btnKhoiLopPhi.Size = new System.Drawing.Size(278, 46);
            this.btnKhoiLopPhi.TabIndex = 39;
            this.btnKhoiLopPhi.Text = "Bớt khối, lớp phí";
            this.btnKhoiLopPhi.UseVisualStyleBackColor = true;
            this.btnKhoiLopPhi.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // hButton1
            // 
            this.hButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hButton1.Image = ((System.Drawing.Image)(resources.GetObject("hButton1.Image")));
            this.hButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hButton1.Location = new System.Drawing.Point(3, 177);
            this.hButton1.Name = "hButton1";
            this.hButton1.Size = new System.Drawing.Size(278, 46);
            this.hButton1.TabIndex = 38;
            this.hButton1.Text = "Từng học sinh";
            this.hButton1.UseVisualStyleBackColor = true;
            this.hButton1.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnThemMucPhi
            // 
            this.btnThemMucPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMucPhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMucPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMucPhi.Image")));
            this.btnThemMucPhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMucPhi.Location = new System.Drawing.Point(3, 130);
            this.btnThemMucPhi.Name = "btnThemMucPhi";
            this.btnThemMucPhi.Size = new System.Drawing.Size(278, 46);
            this.btnThemMucPhi.TabIndex = 37;
            this.btnThemMucPhi.Text = "Thêm mức phí ";
            this.btnThemMucPhi.UseVisualStyleBackColor = true;
            this.btnThemMucPhi.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnThemKhoiLop
            // 
            this.btnThemKhoiLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKhoiLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemKhoiLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoiLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhoiLop.Image")));
            this.btnThemKhoiLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKhoiLop.Location = new System.Drawing.Point(3, 83);
            this.btnThemKhoiLop.Name = "btnThemKhoiLop";
            this.btnThemKhoiLop.Size = new System.Drawing.Size(278, 46);
            this.btnThemKhoiLop.TabIndex = 36;
            this.btnThemKhoiLop.Text = "Thêm khối, lớp,..";
            this.btnThemKhoiLop.UseVisualStyleBackColor = true;
            this.btnThemKhoiLop.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 35);
            this.panel3.TabIndex = 35;
            // 
            // dtThang
            // 
            this.dtThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtThang.CustomFormat = "MM/yyyy";
            this.dtThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThang.Location = new System.Drawing.Point(73, 42);
            this.dtThang.Name = "dtThang";
            this.dtThang.Size = new System.Drawing.Size(208, 30);
            this.dtThang.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tháng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSoNgayTinhPhi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 496);
            this.panel2.TabIndex = 2;
            // 
            // dgvSoNgayTinhPhi
            // 
            this.dgvSoNgayTinhPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoNgayTinhPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKhoiLopPhi,
            this.cSoNgayTinhPhi,
            this.cThu7,
            this.cGhiChu});
            this.dgvSoNgayTinhPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoNgayTinhPhi.Location = new System.Drawing.Point(0, 0);
            this.dgvSoNgayTinhPhi.Name = "dgvSoNgayTinhPhi";
            this.dgvSoNgayTinhPhi.RowHeadersWidth = 51;
            this.dgvSoNgayTinhPhi.RowTemplate.Height = 24;
            this.dgvSoNgayTinhPhi.Size = new System.Drawing.Size(904, 496);
            this.dgvSoNgayTinhPhi.TabIndex = 0;
            // 
            // cKhoiLopPhi
            // 
            this.cKhoiLopPhi.HeaderText = "Khối/Lớp/Phí";
            this.cKhoiLopPhi.MinimumWidth = 6;
            this.cKhoiLopPhi.Name = "cKhoiLopPhi";
            this.cKhoiLopPhi.Width = 150;
            // 
            // cSoNgayTinhPhi
            // 
            this.cSoNgayTinhPhi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cSoNgayTinhPhi.HeaderText = "Số ngày/số lần tính phí";
            this.cSoNgayTinhPhi.MinimumWidth = 6;
            this.cSoNgayTinhPhi.Name = "cSoNgayTinhPhi";
            // 
            // cThu7
            // 
            this.cThu7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cThu7.HeaderText = "Thứ 7";
            this.cThu7.MinimumWidth = 6;
            this.cThu7.Name = "cThu7";
            // 
            // cGhiChu
            // 
            this.cGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cGhiChu.HeaderText = "Ghi chú";
            this.cGhiChu.MinimumWidth = 6;
            this.cGhiChu.Name = "cGhiChu";
            // 
            // FrmSoNgayTinhPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSoNgayTinhPhi";
            this.Text = "FrmSoNgayTinhPhi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNgayTinhPhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtThang;
        private System.Windows.Forms.Label label2;
        private huserControl.hButton btnThemMucPhi;
        private huserControl.hButton btnThemKhoiLop;
        private System.Windows.Forms.Panel panel2;
        private huserControl.hButton btnKhoiLopPhi;
        private huserControl.hButton hButton1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvSoNgayTinhPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKhoiLopPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoNgayTinhPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThu7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
    }
}