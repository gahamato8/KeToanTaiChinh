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
    public partial class FrmNguoiDung : Form
    {
        public FrmNguoiDung()
        {
            InitializeComponent();
        }

        private void btnPhanQuyenSuDung_Click(object sender, EventArgs e)
        {
            FrmPhanQuyenSuDung f = new FrmPhanQuyenSuDung();
            f.ShowDialog();
        }
    }
}
