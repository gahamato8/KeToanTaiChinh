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
    public partial class FrmSoThuDuDoanDauThang : Form
    {
        public FrmSoThuDuDoanDauThang()
        {
            InitializeComponent();
        }

        private void btnThucHienBaoCao_Click(object sender, EventArgs e)
        {
            dgvThucHienBaoCao.Visible = true;
            dgvNen.Visible = false;
        }
        private void XuatExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvThucHienBaoCao.Rows.Count; i++)
            {
                application.Cells[1, i + 1] = dgvThucHienBaoCao.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvThucHienBaoCao.Columns.Count; i++)
            {
                for (int j = 0; i < dgvThucHienBaoCao.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvThucHienBaoCao.Rows[i].Cells[j].Value;
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
    }
}
