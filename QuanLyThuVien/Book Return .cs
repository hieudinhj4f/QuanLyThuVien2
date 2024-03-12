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
    public partial class Book_Return : Form
    {
        public Book_Return()
        {
            InitializeComponent();
        }
        static SqlCommand cmd;

        void hienThi()
        {
            cmd = new SqlCommand($"Select MuonSach.IDmuon, sach.IDsach, sach.Ten,sach.TheLoai, sach.TacGia, MuonSach.NgayMuon, MuonSach.NgayTra\r\nFrom sach inner join MuonSach On sach.IDsach = MuonSach.IDsach\r\nwhere MuonSach.IDnguoidung = {idNguoiDung.id}\r\norder by MuonSach.ngaytra", ConnectToDatabase.conn);
            ConnectToDatabase.init();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ConnectToDatabase.close();
            dtg_tra.DataSource = dt;
        }
        private void Book_Return_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                foreach (DataGridViewRow dr in dtg_tra.SelectedRows)
                {
                    count += 1;
                    cmd = new SqlCommand($"delete from muonsach where idMuon = {dr.Cells["IdMuon"].Value}", ConnectToDatabase.conn);
                    ConnectToDatabase.init();
                    cmd.ExecuteNonQuery();
                    ConnectToDatabase.close();
                }
                MessageBox.Show($"Bạn đã trả {count} cuốn sách");
                hienThi();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                ConnectToDatabase.close();
                MessageBox.Show("Vui lòng chọn ô hợp lệ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dtg_tra.SelectedRows)
                {
                    cmd = new SqlCommand($"update MuonSach\r\nSet NgayTra = '{dtp_ngaytra.Value.ToString("MM-dd-yyyy")}'\r\nwhere IDmuon = {Convert.ToInt32(dr.Cells["IdMuon"].Value)}", ConnectToDatabase.conn);
                    ConnectToDatabase.init();
                    cmd.ExecuteNonQuery();
                    ConnectToDatabase.close();
                }
                MessageBox.Show($"Bạn đã thay đổi thành công ngày mượn sang ngày: {dtp_ngaytra.Value.ToString("MM-dd-yyyy")}");
                hienThi();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                ConnectToDatabase.close();
                MessageBox.Show("Vui lòng chọn ô hợp lệ!");
            }
        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            Admin_Mangagement admin_Mangagement = new Admin_Mangagement();
            admin_Mangagement.Show();
            
        }
    }
}

