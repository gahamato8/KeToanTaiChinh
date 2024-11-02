using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace KeToanTaiChinh
{
    public partial class TinhPhi : Form
    {
        public static string a;
        public TinhPhi()
        {
            InitializeComponent();
            dtThang.ValueChanged += dtThang_ValueChanged;
            pnTinhPhi.Visible = true;
            pnTinhPhiTruoc.Visible = false;
        }

        private void btnXemGiayBao_Click(object sender, EventArgs e)
        {
            FrmChonInTinhPhi f = new FrmChonInTinhPhi();
            f.ShowDialog();
        }

        private void btnDieuChinh1HocSinh_Click(object sender, EventArgs e)
        {
            frmThongBaoChinhHocSinh f = new frmThongBaoChinhHocSinh();
            f.ShowDialog();
        }

        private void btnMienGiamPhi_Click(object sender, EventArgs e)
        {

        }

        private void btnLichHoc_Click(object sender, EventArgs e)
        {
            frmLichHoc f = new frmLichHoc();
            f.ShowDialog();
        }

        private void btnCacPhiSeTinh_Click(object sender, EventArgs e)
        {
            FrmBieuPhi f = new FrmBieuPhi();
            f.ShowDialog();
        }
        private void XuatExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvTinhPhi.Rows.Count; i++)
            {
                application.Cells[1, i + 1] = dgvTinhPhi.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvTinhPhi.Columns.Count; i++)
            {
                for (int j = 0; i < dgvTinhPhi.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvTinhPhi.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnXuatSangExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XuatExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!!\n" + ex.Message);
                }
            }
        }

        private void dtThang_ValueChanged(object sender, EventArgs e)
        {
            DateTime nextMonth = DateTime.Now.AddMonths(1);
            if (dtThang.Value.Month >= nextMonth.Month || dtThang.Value.Year >= nextMonth.Year)
            {
                // Switch to the desired panel or display
                AnPanel();
            }
            else
            {
                pnTinhPhi.Visible = true;
                pnTinhPhiTruoc.Visible = false;
            }    
        }
        private void AnPanel()
        {
            pnTinhPhi.Visible = false;
            pnTinhPhiTruoc.Visible = true;
        }

    }
}
