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
    public partial class FrmSoQuy : Form
    {
        public FrmSoQuy()
        {
            InitializeComponent();
        }

        private void btnThemPhieuThu_Click(object sender, EventArgs e)
        {
            FrmThemPhieuThu f = new FrmThemPhieuThu();
            f.ShowDialog();
        }

        private void btnThemPhieuChi_Click(object sender, EventArgs e)
        {
            FrmThemPhieuChi f = new FrmThemPhieuChi();
            f.ShowDialog();
        }
    }
}
