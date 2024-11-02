using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using hdataLibrary;
//using hultiLibrary;
using BusinessCommon;
using System.Web.Management;
using System.Data.SqlClient;
//using hDataLibraryN8;
using hUltiLibraryNF;
using Npgsql;
using KeToanTaiChinh.PN_Library;
namespace KeToanTaiChinh
{
    public partial class frmDangNhap : Form
    {
        //private string mconnectstring = "server = 192.168.1.108;Port=9108;Username=postgres;Password=titkul@@devpg15;Database=hd_index";
        private string msql;
        private string _queryBuilder = "";
        private static readonly hLibrary hlib = new hLibrary();
        
        Dictionary<string, object> dic_login = new Dictionary<string, object>();
        private string _Database, _NguoiDung, _MatKhau;
        public JObject xjObjLoginInFo = new JObject();
        //public frmDangNhap(string Database, string NguoiDung, string MatKhau)
        //{
        //    InitializeComponent();
        //    Int_data();
        //    LoadCbb();
        //    _Database = Database;
        //    _NguoiDung = NguoiDung;
        //    _MatKhau = MatKhau;
        //}
        public frmDangNhap()
        {
            InitializeComponent();
            LoadCbb();
        }
        public static string matkhau;
        public static string tendn;
        public static string tenquyen;
        //private static readonly string loginID_Index = PN_LoginService.LoginID_Index;


        private async void LoadCbb()
        {
            //var connection = new NpgsqlConnection(mconnectstring);
            //connection.Open();
            //var command = new NpgsqlCommand("select id_user, username from l_user", connection);
            //var reader = command.ExecuteReader();
            ////msql = "select * from l_user";
            //DataTable nguoiDung = new DataTable();
            //nguoiDung.Load(reader);
            //cbbNguoiDung.DataSource = nguoiDung;
            //cbbNguoiDung.DisplayMember = "username"; 
            //cbbNguoiDung.ValueMember = "id_user";
            //string sql = "select * from l_user";
            //DataTable dt = hdataLib.hgetDataTableAsync(loginID_Index, sql);
            //cbbNguoiDung.DataSource = dt;
            //cbbNguoiDung.DisplayMember = "username";
            //cbbNguoiDung.ValueMember = "id_user";

        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRemember.Checked)
            {
                cbbNguoiDung.Text = Properties.Settings.Default.Username;
                txtMatKhau.Text = Properties.Settings.Default.Password;
                Properties.Settings.Default.RememberMe = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {

                cbbNguoiDung.Text = Properties.Settings.Default.Username;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = "no";
                Properties.Settings.Default.Save();


            }
        }

        private void chkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpass.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;

            }
            else
            {
                txtMatKhau.PasswordChar = '*';

            }
        }
        //private void save()
        //{
        //    if (chkRemember.Checked)
        //    {
        //        cbbNguoiDung.Text = Properties.Settings.Default.Username;
        //        txtMatKhau.Text = Properties.Settings.Default.Password;
        //        Properties.Settings.Default.RememberMe = "yes";
        //        Properties.Settings.Default.Save();
        //    }
        //    else
        //    {

        //        cbbNguoiDung.Text = Properties.Settings.Default.Username;
        //        Properties.Settings.Default.Password = "";
        //        Properties.Settings.Default.RememberMe = "no";
        //        Properties.Settings.Default.Save();


        //    }


        //}
        //private void Int_data()
        //{
        //    if (Properties.Settings.Default.Username != string.Empty)
        //    {
        //        if (Properties.Settings.Default.RememberMe == "yes")
        //        {

        //            cbbNguoiDung.Text = Properties.Settings.Default.Username;
        //            txtMatKhau.Text = Properties.Settings.Default.Password;
        //            chkRemember.Checked = true;
        //        }
        //        else
        //        {

        //            cbbNguoiDung.Text = Properties.Settings.Default.Username;

        //        }



        //    }
        //}

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //bool loginMachine = true;
            //Cursor = Cursors.WaitCursor;
            //try
            //{
            //    Form1.xdataulti = new hdataLib(hConstants.PN_CORE_SERVICE_KEYNAME);
            //    Form1.xdatasql = new hsqlDataLib(hConstants.PN_SQL_SERVICE_KEYNAME);
            //    string mhashCode = Form1.xHashCode;
            //    Form1.xLoginID = Form1.xdataulti.hloginService(mhashCode, _Database, _NguoiDung, _MatKhau);
            //    Form1.xLoginID_Master_index = Form1.xdataulti.hloginService(mhashCode, "hd_index", _NguoiDung, _MatKhau);
            //    Application.DoEvents();
            //}
            //catch (Exception ex)
            //{
            //    loginMachine = false;
            //    MessageBox.Show(ex.ToString());
            //}
            //if(loginMachine)// login bằng hashcode của máy
            //{
            //    if(cbbNguoiDung.SelectedText.Length > 0 && txtMatKhau.Text.Length > 0)
            //        //Login lớp username và password người dùng
            //    {
            //        try
            //        {
            //            var result = Form1.xdataulti.hloginApplication(Form1.xLoginID, cbbNguoiDung.SelectedText, txtMatKhau.Text, Form1.xApplicationName);
            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }
            //    }
            //}    
            //string query = "select * from l_user where username = @NguoiDung and password = @MatKhau";
            //using (SqlConnection connection = new SqlConnection(mconnectstring))
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            //    adapter.SelectCommand.Parameters.AddWithValue("@NguoiDung",cbbNguoiDung.SelectedText);
            //    adapter.SelectCommand.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    if(dt.Rows.Count>0)
            //    {
            //        MessageBox.Show("Đăng nhập thành công!!");
            //        tendn = dt.Rows[0]["username"].ToString();
            //        matkhau = dt.Rows[0]["password"].ToString();
            //        tenquyen = dt.Rows[0]["role"].ToString();
            //        // Save user data or perform other actions
            //        save();
            //        Form1 f = new Form1(dt.Rows[0][0].ToString());
            //        this.Hide();
            //        f.ShowDialog();
            //    }    
            //}
            //Form1 f = new Form1();
            //f.ShowDialog();
        }
    }
}
