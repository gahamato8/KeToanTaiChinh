namespace KeToanTaiChinh
{
    partial class frmDieuChinhHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDieuChinhHocPhi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgvDieuChinhHocPhi = new System.Windows.Forms.DataGridView();
            this.btnDong = new huserControl.hButton();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayTinhPhiThangNay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMucPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThanhTienTruThanhTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayTruThangTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienTruThangTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienDaThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDaThu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hLabel1 = new huserControl.hLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuChinhHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.hLabel1);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 63);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 41);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDieuChinhHocPhi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 364);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điều chỉnh học phí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phí tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lớp:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 30);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(457, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 30);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(693, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 30);
            this.textBox3.TabIndex = 5;
            // 
            // dgvDieuChinhHocPhi
            // 
            this.dgvDieuChinhHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDieuChinhHocPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cNoiDung,
            this.cNgayTinhPhiThangNay,
            this.cMucPhi,
            this.cGiam,
            this.cThanhTienTruThanhTruoc,
            this.cNgayTruThangTruoc,
            this.cTienTruThangTruoc,
            this.cCong,
            this.cTienDaThu,
            this.cDaThu});
            this.dgvDieuChinhHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDieuChinhHocPhi.Location = new System.Drawing.Point(0, 0);
            this.dgvDieuChinhHocPhi.Name = "dgvDieuChinhHocPhi";
            this.dgvDieuChinhHocPhi.RowHeadersWidth = 51;
            this.dgvDieuChinhHocPhi.RowTemplate.Height = 24;
            this.dgvDieuChinhHocPhi.Size = new System.Drawing.Size(954, 364);
            this.dgvDieuChinhHocPhi.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(807, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(135, 57);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cStt
            // 
            this.cStt.HeaderText = "Stt";
            this.cStt.MinimumWidth = 6;
            this.cStt.Name = "cStt";
            this.cStt.Width = 125;
            // 
            // cNoiDung
            // 
            this.cNoiDung.HeaderText = "Nội dung";
            this.cNoiDung.MinimumWidth = 6;
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.Width = 125;
            // 
            // cNgayTinhPhiThangNay
            // 
            this.cNgayTinhPhiThangNay.HeaderText = "Ngày tính phí tháng này";
            this.cNgayTinhPhiThangNay.MinimumWidth = 6;
            this.cNgayTinhPhiThangNay.Name = "cNgayTinhPhiThangNay";
            this.cNgayTinhPhiThangNay.Width = 125;
            // 
            // cMucPhi
            // 
            this.cMucPhi.HeaderText = "Mức phí tháng này";
            this.cMucPhi.MinimumWidth = 6;
            this.cMucPhi.Name = "cMucPhi";
            this.cMucPhi.Width = 125;
            // 
            // cGiam
            // 
            this.cGiam.HeaderText = "%giảm(trừ tháng trước)";
            this.cGiam.MinimumWidth = 6;
            this.cGiam.Name = "cGiam";
            this.cGiam.Width = 125;
            // 
            // cThanhTienTruThanhTruoc
            // 
            this.cThanhTienTruThanhTruoc.HeaderText = "Thành tiền trừ tháng trước";
            this.cThanhTienTruThanhTruoc.MinimumWidth = 6;
            this.cThanhTienTruThanhTruoc.Name = "cThanhTienTruThanhTruoc";
            this.cThanhTienTruThanhTruoc.Width = 125;
            // 
            // cNgayTruThangTruoc
            // 
            this.cNgayTruThangTruoc.HeaderText = "Ngày trừ tháng trước";
            this.cNgayTruThangTruoc.MinimumWidth = 6;
            this.cNgayTruThangTruoc.Name = "cNgayTruThangTruoc";
            this.cNgayTruThangTruoc.Width = 125;
            // 
            // cTienTruThangTruoc
            // 
            this.cTienTruThangTruoc.HeaderText = "Tiền trừ tháng trước";
            this.cTienTruThangTruoc.MinimumWidth = 6;
            this.cTienTruThangTruoc.Name = "cTienTruThangTruoc";
            this.cTienTruThangTruoc.Width = 125;
            // 
            // cCong
            // 
            this.cCong.HeaderText = "Cộng";
            this.cCong.MinimumWidth = 6;
            this.cCong.Name = "cCong";
            this.cCong.Width = 125;
            // 
            // cTienDaThu
            // 
            this.cTienDaThu.HeaderText = "Tiền đã thu";
            this.cTienDaThu.MinimumWidth = 6;
            this.cTienDaThu.Name = "cTienDaThu";
            this.cTienDaThu.Width = 125;
            // 
            // cDaThu
            // 
            this.cDaThu.HeaderText = "Đã thu";
            this.cDaThu.MinimumWidth = 6;
            this.cDaThu.Name = "cDaThu";
            this.cDaThu.Width = 125;
            // 
            // hLabel1
            // 
            this.hLabel1.AutoSize = true;
            this.hLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hLabel1.ForeColor = System.Drawing.Color.Red;
            this.hLabel1.Location = new System.Drawing.Point(3, 20);
            this.hLabel1.Name = "hLabel1";
            this.hLabel1.Size = new System.Drawing.Size(155, 23);
            this.hLabel1.TabIndex = 5;
            this.hLabel1.Text = "Lưu ý quan trọng";
            this.hLabel1.xBorderStyle = huserControl.hBorderStyle.Fixed3D;
            this.hLabel1.xUnderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(616, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Các điều chỉnh nhập ở đây có thể sẽ bị mất nếu thực hiện lệnh tính lại học phí";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(35, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 51);
            this.panel5.TabIndex = 1;
            // 
            // frmDieuChinhHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 522);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDieuChinhHocPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuChinhHocPhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDieuChinhHocPhi;
        private huserControl.hButton btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayTinhPhiThangNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMucPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhTienTruThanhTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayTruThangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienTruThangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienDaThu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cDaThu;
        private System.Windows.Forms.Label label5;
        private huserControl.hLabel hLabel1;
        private System.Windows.Forms.Panel panel5;
    }
}