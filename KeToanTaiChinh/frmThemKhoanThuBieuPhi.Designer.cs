namespace KeToanTaiChinh
{
    partial class frmThemKhoanThuBieuPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemKhoanThuBieuPhi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbThemMacDinh = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.hComboBox1 = new huserControl.hComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtThang = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnThem = new huserControl.hButton();
            this.btnDong = new huserControl.hButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm khoảng thu vào biểu phí";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(13, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 49);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 69);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtThang);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.hComboBox1);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.rbThemMacDinh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 69);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(656, 346);
            this.panel5.TabIndex = 0;
            // 
            // rbThemMacDinh
            // 
            this.rbThemMacDinh.AutoSize = true;
            this.rbThemMacDinh.Location = new System.Drawing.Point(13, 5);
            this.rbThemMacDinh.Name = "rbThemMacDinh";
            this.rbThemMacDinh.Size = new System.Drawing.Size(151, 26);
            this.rbThemMacDinh.TabIndex = 0;
            this.rbThemMacDinh.TabStop = true;
            this.rbThemMacDinh.Text = "Thêm mặc định";
            this.rbThemMacDinh.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(164, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 26);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thêm giống như";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // hComboBox1
            // 
            this.hComboBox1.FormattingEnabled = true;
            this.hComboBox1.Location = new System.Drawing.Point(320, 3);
            this.hComboBox1.Name = "hComboBox1";
            this.hComboBox1.Size = new System.Drawing.Size(230, 30);
            this.hComboBox1.TabIndex = 2;
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
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xóa các phí hiện tại và thêm giống tháng";
            // 
            // dtThang
            // 
            this.dtThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtThang.CustomFormat = "MM/yyyy";
            this.dtThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThang.Location = new System.Drawing.Point(346, 35);
            this.dtThang.Name = "dtThang";
            this.dtThang.Size = new System.Drawing.Size(204, 30);
            this.dtThang.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMa,
            this.cTen,
            this.cChon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // cMa
            // 
            this.cMa.HeaderText = "Mã";
            this.cMa.MinimumWidth = 6;
            this.cMa.Name = "cMa";
            this.cMa.Width = 125;
            // 
            // cTen
            // 
            this.cTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTen.HeaderText = "Tên";
            this.cTen.MinimumWidth = 6;
            this.cTen.Name = "cTen";
            // 
            // cChon
            // 
            this.cChon.HeaderText = "Chọn";
            this.cChon.MinimumWidth = 6;
            this.cChon.Name = "cChon";
            this.cChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cChon.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(373, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 63);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.xEnterColor = System.Drawing.SystemColors.Highlight;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(517, 1);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(136, 66);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.xEnterColor = System.Drawing.SystemColors.Highlight;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThemKhoanThuBieuPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 542);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemKhoanThuBieuPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbThemMacDinh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private huserControl.hComboBox hComboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dtThang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cChon;
        private huserControl.hButton btnThem;
        private huserControl.hButton btnDong;
    }
}