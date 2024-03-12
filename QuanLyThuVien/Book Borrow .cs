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
    public partial class Book_Borrow : Form
    {
        public Book_Borrow()
        {
            InitializeComponent();
        }


        static SqlCommand cmd;
        void HienThi()
        {
            ConnectToDatabase.init();
            cmd = new SqlCommand("select * from sach", ConnectToDatabase.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ConnectToDatabase.close();
            dtg_muon.DataSource = dt;
        }
        private void Book_Borrow_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                foreach (DataGridViewRow dt in dtg_muon.SelectedRows)
                {
                    count += 1;
                    cmd = new SqlCommand($"insert into muonsach(idsach,idnguoidung,ngaytra) values({Convert.ToInt32(dt.Cells[0].Value)},{idNguoiDung.id},'{dtp_ngaytra.Value.ToString("MM-dd-yyyy")}')", ConnectToDatabase.conn);
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
                foreach (DataGridViewRow dt in dtg_muon.SelectedRows)
                {
                    count += 1;
                    cmd = new SqlCommand($"insert into giohang values({Convert.ToInt32(dt.Cells["IDsach"].Value)},{idNguoiDung.id})", ConnectToDatabase.conn);
                    ConnectToDatabase.init();
                    cmd.ExecuteNonQuery();
                    ConnectToDatabase.close();
                }
                MessageBox.Show($"Bạn đã thêm {count} cuốn sách vào giỏ hàng");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                ConnectToDatabase.close();
                MessageBox.Show("Vui lòng chọn ô hợp lệ!");
            }
        }
    }
}
