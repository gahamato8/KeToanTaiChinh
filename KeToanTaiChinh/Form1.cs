
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hDataLibraryNF;
using hUltiLibraryNF;


namespace KeToanTaiChinh
{
    public partial class Form1 : Form
    {
        //public static hdataLib xdataulti = null;
        //public static hsqlDataLib xdatasql = null;
        public static string xHashCode = "";
        public static string xLoginID = "";
        public static string xLoginID_Master_index = "";
        public static string xApplicationName = "Titkul";
        
        public Form1()
        {
            InitializeComponent();
        }
        public void Load(object Form)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(f);
            this.pnMain.Tag = f;
            f.Show();

        }
        public void Load1(object Form)
        {
            if (this.pnMain1.Controls.Count > 0)
                this.pnMain1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain1.Controls.Add(f);
            this.pnMain1.Tag = f;
            f.Show();

        }
        public void Load2(object Form)
        {
            if (this.pnMain2.Controls.Count > 0)
                this.pnMain2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain2.Controls.Add(f);
            this.pnMain2.Tag = f;
            f.Show();

        }
        public void Load3(object Form)
        {
            if (this.pnMain3.Controls.Count > 0)
                this.pnMain3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain3.Controls.Add(f);
            this.pnMain3.Tag = f;
            f.Show();
        }
        public void Load4(object Form)
        {
            if (this.pnMain4.Controls.Count > 0)
                this.pnMain4.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain4.Controls.Add(f);
            this.pnMain4.Tag = f;
            f.Show();

        }
        public void Load5(object Form)
        {
            if (this.pnMain5.Controls.Count > 0)
                this.pnMain5.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain5.Controls.Add(f);
            this.pnMain5.Tag = f;
            f.Show();

        }
        private void btnBieuPhi3_Click(object sender, EventArgs e)
        {
            Load2(new FrmBieuPhi());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCaoThongKe f = new FrmBaoCaoThongKe();
            f.ShowDialog();
        }

        private void btnCauHinh1_Click(object sender, EventArgs e)
        {
            FrmCauHinh f = new FrmCauHinh();
            f.ShowDialog();
        }

        private void btnChuaThu_Click(object sender, EventArgs e)
        {
            //FrmChuaThuPhi f = new FrmChuaThuPhi();
            //f.ShowDialog();
            Load3(new FrmChuaThuPhi());
        }

        private void btnChuaXuat_Click(object sender, EventArgs e)
        {
            Load3(new FrmChuaXuatHoaDon());
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            Load2(new FrmDangKyTuyChon());
        }

        private void btnKhauTru_Click(object sender, EventArgs e)
        {
            Load2(new FrmKhauTruNgayNghi());
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            FrmNguoiDung f = new FrmNguoiDung();
            f.ShowDialog();
        }

        private void btnHoaDonPhieuThu_Click(object sender, EventArgs e)
        {
            Load3(new FrmPhieuXuatHoaDon());
        }

        private void btnSoNgay_Click(object sender, EventArgs e)
        {
            Load2(new FrmSoNgayTinhPhi());
        }

        private void btnSoQuy_Click(object sender, EventArgs e)
        {
            Load3(new FrmSoQuy());
        }

        private void btnDuThuDaThu_Click(object sender, EventArgs e)
        {
            Load5(new FrmSoThuDuDoanDauThang());
        }

        private void btnSoThuThanhToan_Click(object sender, EventArgs e)
        {
            Load5(new FrmSoThuThanhToan());
        }

        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            FrmThemPhieuChi f = new FrmThemPhieuChi();
            f.ShowDialog();
        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            FrmThemPhieuThu f = new FrmThemPhieuThu();
            f.ShowDialog();
        }

        private void btnMaVach_Click(object sender, EventArgs e)
        {
            FrmThuPhiMaVach f = new FrmThuPhiMaVach();
            f.ShowDialog();
        }

        private void btnPhi_Click(object sender, EventArgs e)
        {
            Load1(new LePhi());
        }

        private void btnLopPhieu_Click(object sender, EventArgs e)
        {
            //Load4(new LopPhieuThuPhiOnline());
            LopPhieuThuPhiOnline f = new LopPhieuThuPhiOnline();
            f.ShowDialog();
        }

        private void btnMienGiam_Click(object sender, EventArgs e)
        {
            Load2(new MienGiamPhi());
        }

        private void btnTinhPhi_Click(object sender, EventArgs e)
        {
            Load2(new TinhPhi());
        }

        private void BtnBieuPhi2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnBienLai_Click(object sender, EventArgs e)
        {

        }

        private void btnVietQR_Click(object sender, EventArgs e)
        {

        }

        private void BtnCauHinh_Click(object sender, EventArgs e)
        {

        }

        private void btnDaXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnCauHinh5_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void btnDaUpload_Click(object sender, EventArgs e)
        {

        }

        private void btnDaThu_Click(object sender, EventArgs e)
        {

        }

        private void btnSaoKe_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeThuTien_Click(object sender, EventArgs e)
        {

        }

        private void btnSoThuThanhToanCuoiThang_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachConNo_Click(object sender, EventArgs e)
        {

        }

        private void btnTongHopHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemXuatDanhSachBHYTD03_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemNhatKyTruyCap_Click(object sender, EventArgs e)
        {
            FrmNhatKyTruyCap f = new FrmNhatKyTruyCap();
            f.ShowDialog();
        }

        private void BtnBieuPhi2_Click_1(object sender, EventArgs e)
        {
            Load1(new FrmBieuPhi());
        }
    }
}
