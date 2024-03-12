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
    public partial class Accout_Create : Form
    {

        string strConnect = @"Data Source=LAPTOP-RFF4KPTS\CHIEN;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        string query;

        public Accout_Create()
        {
            InitializeComponent();
        }

        private void Accout_Create_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strConnect);
            con.Open();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        { 
            string hoVaTen = txtHoVaTen.Text;
            string ngaySinh = dateTimePicker1.Value.ToString();
            string gioiTinh = comboBox1.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string tenTaiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text;
            string query = $"INSERT INTO NGUOIDUNG VALUES (N'{txtHoVaTen.Text}','{dateTimePicker1.Value.ToString()}','{comboBox1.Text}','{txtSoDienThoai.Text}','{txtTenTaiKhoan.Text}','{txtMatKhau.Text}')";
            string checkQuery = $"Select * from nguoidung where tentaikhoan = '{tenTaiKhoan}'";
            SqlCommand cmdCheck = new SqlCommand(checkQuery, con);
            SqlDataReader readerCheck = cmdCheck.ExecuteReader();
            bool check = readerCheck.Read();
            if (check == true)
            {
                lblTenTaiKhoan.Text = "Tài khoản đã tồn tại!";
            }
            readerCheck.Close();
            if (hoVaTen.Length == 0) {
                lblHoVaTen.Text = "Không được để trống trường dữ liệu này!";
            }
            else if(gioiTinh.Length == 0)
            {
                lblGioiTinh.Text = "Không được để trống trường dữ liệu này!";
            }
            else if(soDienThoai.Length == 0)
            {
                lblSoDienThoai.Text = "Không được để trống trường dữ liệu này!";
            }
            else if(tenTaiKhoan.Length == 0)
            {
                lblTenTaiKhoan.Text = "Không được để trống trường dữ liệu này!";
            }
            else if(matKhau.Length == 0)
            {
                lblMatKhau.Text = "Không được để trống trường dữ liệu này!";
            }
            else if(nhapLaiMatKhau.Length == 0)
            {
                lblNhapLaiMatKhau.Text = "Không được để trống trường dữ liệu này!";
            }
            else if(matKhau != nhapLaiMatKhau)
            {
                lblNhapLaiMatKhau.Text = "Mật khẩu không trùng khớp!";
            }
            
            else if(check == false)
            {
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo tài khoản thành công!", "Succeed!", MessageBoxButtons.OK);
            }



            if (hoVaTen.Length > 0)
            {
                lblHoVaTen.Text = "";
            }

            if (gioiTinh.Length > 0)
            {
                lblGioiTinh.Text = "";
            }
            if (soDienThoai.Length > 0)
            {
                lblSoDienThoai.Text = "";     
            }
            if (tenTaiKhoan.Length > 0 && check == false)
            {
                lblTenTaiKhoan.Text = "";
            }
            if (matKhau.Length > 0)
            {
                lblMatKhau.Text = "";
            }
            if (nhapLaiMatKhau.Length > 0 && matKhau == nhapLaiMatKhau)
            {
                lblNhapLaiMatKhau.Text = "";
            }


        }

       

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Hide();
        }

        private void chkHienThiMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
                
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
