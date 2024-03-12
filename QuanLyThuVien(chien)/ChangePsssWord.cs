using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ChangePsssWord : Form
    {

        string strConnect = @"Data Source=LAPTOP-RFF4KPTS\CHIEN;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand cmd;
        string query;

        public ChangePsssWord()
        {
            InitializeComponent();
        }

        private void ChangePsssWord_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strConnect);
            con.Open();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

            query = $"Select * from nguoidung where idnguoidung = {Convert.ToInt32(ID.idNguoiDung)}";
            cmd = new SqlCommand(query, con);
            reader = cmd.ExecuteReader();
            string matKhauCu = "";
            if (reader.Read() == true)
            {
                matKhauCu = reader["matkhau"].ToString();
            }
            reader.Close();
            if (txtMatKhauCu.Text.Length == 0)
            {
                lblMatKhauCu.Text = "Không được để trống trường dữ liệu này!";
            }
            else if (txtMatKhauMoi.Text.Length == 0)
            {
                lblMatKhauMoi.Text = "Không được để trống trường dữ liệu này!";
            }
            else if (txtNhapLaiMatKhauMoi.Text.Length == 0)
            {
                lblNhapLaiMatKhauMoi.Text = "Không được để trống trường dữ liệu này!";
            }
            else if(txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
            {
                lblNhapLaiMatKhauMoi.Text = "Mật khẩu không trùng khớp!";
            }
            else if (matKhauCu != txtMatKhauCu.Text)
            {
                MessageBox.Show("Nhập sai mật khẩu cũ!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (matKhauCu == txtMatKhauCu.Text)
            {
                query = $"Update nguoidung set matkhau = '{txtMatKhauMoi.Text}' where idnguoidung = {Convert.ToInt32(ID.idNguoiDung)}";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            

            if (txtMatKhauCu.Text.Length > 0)
            {
                lblMatKhauCu.Text = "";
            }
            if (txtMatKhauMoi.Text.Length > 0)
            {
                lblMatKhauMoi.Text = "";
            }
            if (txtNhapLaiMatKhauMoi.Text.Length > 0 && txtMatKhauMoi.Text == txtNhapLaiMatKhauMoi.Text)
            {
                lblNhapLaiMatKhauMoi.Text = "";
            }

        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHienThiMatKhau.Checked == true) {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar=false;
                txtNhapLaiMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtNhapLaiMatKhauMoi.UseSystemPasswordChar = true;
            }
        }
    }
}
