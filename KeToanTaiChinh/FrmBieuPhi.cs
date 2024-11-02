using huserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTaiChinh
{
    public partial class FrmBieuPhi : Form
    {
        public FrmBieuPhi()
        {
            InitializeComponent();
        }

        
        private void btnXemNgangNhatXuatExcel_Click(object sender, EventArgs e)
        {
            frmBieuPhi_Excel f = new frmBieuPhi_Excel();
            f.ShowDialog();
        }

        private void btnThemMucPhiChoThang_Click(object sender, EventArgs e)
        {
            frmThemKhoanThuBieuPhi f = new frmThemKhoanThuBieuPhi();
            f.ShowDialog();
        }

        private void dgvBieuPhi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmDangKyTuyChon f = new FrmDangKyTuyChon();
            f.ShowDialog();
        }

        private void dgvBieuPhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
