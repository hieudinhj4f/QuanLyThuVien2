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
    public partial class Book_Cart : Form
    {
        public Book_Cart()
        {
            InitializeComponent();
        }
        static SqlCommand cmd;

        void hienthi()
        {
            cmd = new SqlCommand($"Select Sach.IDsach as [Mã sách], sach.Ten as [Tên sách],sach.TheLoai As [Thể loại], sach.GiaThue As [Giá thuê]\r\nFrom Sach Inner join GioHang On sach.IDsach = GioHang.IDsach\r\nwhere IDnguoidung = {idNguoiDung.id}", ConnectToDatabase.conn);
            ConnectToDatabase.init();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ConnectToDatabase.close();
            dgr_gioHang.DataSource = dt;
        }
        private void Book_Cart_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                foreach (DataGridViewRow row in dgr_gioHang.SelectedRows)
                {
                    count += 1;
                    cmd = new SqlCommand($"insert into muonsach(idsach,idnguoidung,ngaytra) values({Convert.ToInt32(row.Cells["Mã sách"].Value)},{idNguoiDung.id},'{dtp_ngaytra.Value.ToString("MM-dd-yyyy")}')", ConnectToDatabase.conn);
                    ConnectToDatabase.init();
                    cmd.ExecuteNonQuery();
                    ConnectToDatabase.close();
                }
                MessageBox.Show($"Bạn đã mượn thành công {count} cuốn sách");

            }
            catch (System.Data.SqlClient.SqlException)
            {
                ConnectToDatabase.close();
                MessageBox.Show("Vui lòng chọn ô hợp lệ!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                foreach (DataGridViewRow row in dgr_gioHang.SelectedRows)
                {
                    count += 1;
                    cmd = new SqlCommand($"delete from giohang where idsach = {Convert.ToInt32(row.Cells["Mã sách"].Value)} and idnguoidung = {idNguoiDung.id}", ConnectToDatabase.conn);
                    ConnectToDatabase.init();
                    cmd.ExecuteNonQuery();
                    ConnectToDatabase.close();
                }
                MessageBox.Show($"Bạn đã xoá thành công {count} cuốn sách ra khỏi giỏ hàng");
                hienthi();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                ConnectToDatabase.close();
                MessageBox.Show("Vui lòng chọn ô hợp lệ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Mangagement admin_Mangagement = new Admin_Mangagement();
            admin_Mangagement.Show();
        }
    }
}
