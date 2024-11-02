using DevExpress.XtraWaitForm;
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
    public partial class frmThongBaoChinhHocSinh : Form
    {
        public frmThongBaoChinhHocSinh()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  // Set the DialogResult
            this.Close();
            //frmDieuChinhHocPhi f = new frmDieuChinhHocPhi();
            //f.ShowDialog();
            //f.Dispose();
            // Show the MainForm as a dialog
            if (new frmDieuChinhHocPhi().ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("OK button clicked.");
            }
            //else
            //{
            //    MessageBox.Show("Cancel button clicked or form closed.");
            //}
        }

    }
}
