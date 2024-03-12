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
    public partial class Customer_Information : Form
    {
        public Customer_Information()
        {
            InitializeComponent();

        }
        SqlConnection ketnoi;
        string str = @"Data Source=LAPTOP-493ABJJS\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True"; //Duong dan
        SqlCommand cmd; //thuchien
        SqlDataAdapter a = new SqlDataAdapter(); // Đổ dữ liệu và cập nhật thay đổi vào database
        DataTable data = new DataTable();

        private void Customer_Information_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(str);
            ketnoi.Open();
            Hienthi();
        }
        //Hiển thị
        public void Hienthi()
        {
            cmd = ketnoi.CreateCommand();
            cmd.CommandText = "SELECT *FROM NguoiDung";
            a.SelectCommand = cmd;
            data.Clear();
            a.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void Customer_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            ketnoi.Close();
        }

        //Xoa du lieu

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = ketnoi.CreateCommand();
            cmd.CommandText = " delete from NguoiDung  where IDnguoidung=@IDnguoidung";
            cmd.Parameters.AddWithValue("IDnguoidung",Convert.ToInt32(txtID.Text));

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công!");
            }
            Hienthi();
            
        }

        //Sua du lieu

        private void button2_Click(object sender, EventArgs e)
        {

            cmd = ketnoi.CreateCommand();
            cmd.CommandText = "UPDATE NguoiDung SET  TenNguoiDung = @TenNguoiDung, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh,SDT = @SDT,TenTaiKhoan = @TenTaiKhoan,MatKhau = @MatKhau where IDnguoidung = @IDnguoidung";
            cmd.Parameters.AddWithValue("IDnguoidung", txtID.Text);
            cmd.Parameters.AddWithValue("TenNguoiDung", txtNguoidung.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("GioiTinh", comboBox1.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("TenTaiKhoan", txtTenTK.Text);
            cmd.Parameters.AddWithValue("MatKhau", txtMK.Text);
            int i= cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu không thành công!");
            }
            Hienthi();
        }

        //tim kiem du lieu

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Clear();
            cmd = ketnoi.CreateCommand();
            cmd.CommandText ="SELECT *FROM NguoiDung WHERE IDnguoidung = @IDnguoidung";
            cmd.Parameters.AddWithValue("IDnguoidung", Txttimkiem.Text);
            cmd.Parameters.AddWithValue("TenNguoiDung", txtNguoidung.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("GioiTinh", comboBox1.Text);
            cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("TenTaiKhoan", txtTenTK.Text);
            cmd.Parameters.AddWithValue("MatKhau", txtMK.Text);
            int i = cmd.ExecuteNonQuery();
            SqlDataReader doc = cmd.ExecuteReader();
            data.Load(doc);
            dataGridView1.DataSource = data;

            //day du lieu len textbox sau khi tim kiếm

                DataGridViewRow dt = dataGridView1.Rows[0];
                txtID.Text = dt.Cells[0].Value.ToString();
                txtNguoidung.Text = dt.Cells[1].Value.ToString();
                dateTimePicker1.Text = dt.Cells[2].Value.ToString();
                comboBox1.Text = dt.Cells[3].Value.ToString();
                txtSDT.Text = dt.Cells[4].Value.ToString();
                txtTenTK.Text = dt.Cells[5].Value.ToString();
                txtMK.Text = dt.Cells[6].Value.ToString();
  
        }
        //Nút thoát
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        //Nút Them du lieu

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = ketnoi.CreateCommand();
            cmd.CommandText = " insert into NguoiDung  VALUES('"+txtNguoidung.Text+ "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + txtSDT.Text + "','" + txtTenTK.Text + "','" + txtMK.Text + "')";
            int i = cmd.ExecuteNonQuery();
            if(i!=0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công!");
            }
            Hienthi();
        }

        //day du lieu len textbox

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtNguoidung.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtTenTK.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtMK.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }
    }
}
    

