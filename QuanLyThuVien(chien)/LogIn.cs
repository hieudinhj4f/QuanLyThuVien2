using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class fLogin : Form
    {
       
        string strConnect = @"Data Source=LAPTOP-RFF4KPTS\CHIEN;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        string query;
        SqlConnection con ;
        SqlCommand cmd;
        SqlDataReader reader;
        
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strConnect);
            con.Open();
            
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            query = $"Select * from nguoidung where tentaikhoan = '{txtTenTaiKhoan.Text}' and matkhau = '{txtMatKhau.Text}'";
            cmd = new SqlCommand(query, con);
            reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                Admin_Mangagement f = new Admin_Mangagement();
                f.Show();
                this.Hide();
                ID.idNguoiDung = reader["idnguoidung"].ToString();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHienThiMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
           
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            Accout_Create f = new Accout_Create();
            f.Show();
            this.Hide(); 
        }
    }
}
