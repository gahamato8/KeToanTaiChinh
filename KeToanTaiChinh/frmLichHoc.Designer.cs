namespace KeToanTaiChinh
{
    partial class frmLichHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichHoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaLich = new huserControl.hButton();
            this.btnThemLichHocChoKhoi = new huserControl.hButton();
            this.btnTaoLichHoc = new huserControl.hButton();
            this.dtThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.cKhoiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHocChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaLich);
            this.panel1.Controls.Add(this.btnThemLichHocChoKhoi);
            this.panel1.Controls.Add(this.btnTaoLichHoc);
            this.panel1.Controls.Add(this.dtThang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(914, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 612);
            this.panel1.TabIndex = 0;
            // 
            // btnXoaLich
            // 
            this.btnXoaLich.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLich.Image")));
            this.btnXoaLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLich.Location = new System.Drawing.Point(6, 160);
            this.btnXoaLich.Name = "btnXoaLich";
            this.btnXoaLich.Size = new System.Drawing.Size(265, 46);
            this.btnXoaLich.TabIndex = 55;
            this.btnXoaLich.Text = "Xóa lịch";
            this.btnXoaLich.UseVisualStyleBackColor = true;
            this.btnXoaLich.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnThemLichHocChoKhoi
            // 
            this.btnThemLichHocChoKhoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLichHocChoKhoi.Image")));
            this.btnThemLichHocChoKhoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLichHocChoKhoi.Location = new System.Drawing.Point(6, 113);
            this.btnThemLichHocChoKhoi.Name = "btnThemLichHocChoKhoi";
            this.btnThemLichHocChoKhoi.Size = new System.Drawing.Size(265, 46);
            this.btnThemLichHocChoKhoi.TabIndex = 54;
            this.btnThemLichHocChoKhoi.Text = "Thêm lịch học cho khối";
            this.btnThemLichHocChoKhoi.UseVisualStyleBackColor = true;
            this.btnThemLichHocChoKhoi.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnTaoLichHoc
            // 
            this.btnTaoLichHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoLichHoc.Image")));
            this.btnTaoLichHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoLichHoc.Location = new System.Drawing.Point(6, 66);
            this.btnTaoLichHoc.Name = "btnTaoLichHoc";
            this.btnTaoLichHoc.Size = new System.Drawing.Size(265, 46);
            this.btnTaoLichHoc.TabIndex = 53;
            this.btnTaoLichHoc.Text = "Tạo lịch học";
            this.btnTaoLichHoc.UseVisualStyleBackColor = true;
            this.btnTaoLichHoc.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // dtThang
            // 
            this.dtThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtThang.CustomFormat = "MM/yyyy";
            this.dtThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThang.Location = new System.Drawing.Point(67, 34);
            this.dtThang.Name = "dtThang";
            this.dtThang.Size = new System.Drawing.Size(204, 30);
            this.dtThang.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tháng:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 30);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(459, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(34, 32);
            this.panel7.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(206, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(34, 32);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(84, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(34, 32);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(499, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nghỉ lễ, nghỉ tất cả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(240, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày nghỉ(nghỉ hàng tuần)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(121, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày học";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ký hiệu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvLichHoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 572);
            this.panel3.TabIndex = 2;
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKhoiLop,
            this.cHocChinh,
            this.cThu7,
            this.cGhiChu});
            this.dgvLichHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHoc.Location = new System.Drawing.Point(0, 0);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.RowHeadersWidth = 51;
            this.dgvLichHoc.RowTemplate.Height = 24;
            this.dgvLichHoc.Size = new System.Drawing.Size(914, 572);
            this.dgvLichHoc.TabIndex = 0;
            // 
            // cKhoiLop
            // 
            this.cKhoiLop.HeaderText = "Khối lớp";
            this.cKhoiLop.MinimumWidth = 6;
            this.cKhoiLop.Name = "cKhoiLop";
            this.cKhoiLop.Width = 125;
            // 
            // cHocChinh
            // 
            this.cHocChinh.HeaderText = "Học chính";
            this.cHocChinh.MinimumWidth = 6;
            this.cHocChinh.Name = "cHocChinh";
            this.cHocChinh.Width = 125;
            // 
            // cThu7
            // 
            this.cThu7.HeaderText = "Thứ 7";
            this.cThu7.MinimumWidth = 6;
            this.cThu7.Name = "cThu7";
            this.cThu7.Width = 125;
            // 
            // cGhiChu
            // 
            this.cGhiChu.HeaderText = "Ghi chú";
            this.cGhiChu.MinimumWidth = 6;
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.Width = 125;
            // 
            // frmLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLichHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch học";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private huserControl.hButton btnTaoLichHoc;
        private System.Windows.Forms.DateTimePicker dtThang;
        private System.Windows.Forms.Label label2;
        private huserControl.hButton btnThemLichHocChoKhoi;
        private huserControl.hButton btnXoaLich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHocChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThu7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
    }
}