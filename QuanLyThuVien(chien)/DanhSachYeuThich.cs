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

    public partial class DanhSachYeuThich : Form
    {
        string strConnect = @"Data Source=LAPTOP-RFF4KPTS\CHIEN;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        string query;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        DataTable dt = new DataTable();
        string idSach;

        public DanhSachYeuThich()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            query = $"update yeuthich4 set ghichu = '{txtGhiChu.Text}' where idnguoidung = {ID.idNguoiDung} and idsach = {Convert.ToInt32(idSach)}";
            cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        void HienThi()
        {
            query = $"select sach.idsach as Mã_sách,sach.ten as Tên_sách,sach.theloai as Thể_loại,sach.tacgia as Tác_giả, yeuthich4.ghichu as Ghi_chú from sach inner join yeuthich4 on sach.idsach = yeuthich4.idsach where yeuthich4.idnguoidung ={ID.idNguoiDung}";
            cmd  = new SqlCommand(query,con);
            reader = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void DanhSachYeuThich_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strConnect);
            con.Open();
            HienThi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            try
            {
                DataRow row = dt.Rows[i];
                txtGhiChu.Text = row[4].ToString();
                idSach = row[0].ToString();
            }
            catch (Exception ee)
            {
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            query = $"delete from yeuthich4 where idsach = {Convert.ToInt32(idSach)}";
            cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Select f = new Select();
            f.Show();
            this.Hide();

        }
    }
}
