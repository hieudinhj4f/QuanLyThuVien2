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
    public partial class Book_Late : Form
    {
        public Book_Late()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        private void Book_Late_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand($"Select MuonSach.IDmuon as [Mã Đơn],MuonSach.IDsach As[Mã sách],sach.Ten As [Tên sách],Sach.TheLoai As [Thể loại],Sach.TacGia As [Tác giả],MuonSach.NgayTra As [Ngày trả] , datediff(day,MuonSach.NgayTra,getdate())*5000 as [Tiền phạt]\r\nfrom MuonSach inner join Sach On sach.IDsach = MuonSach.IDsach \r\nwhere MuonSach.NgayTra < cast(GETDATE() as date) and MuonSach.IDnguoidung = {idNguoiDung.id}", ConnectToDatabase.conn);
            ConnectToDatabase.init();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            ConnectToDatabase.close();
            dtg_sachMuon.DataSource = dt;
        }
    }
}
