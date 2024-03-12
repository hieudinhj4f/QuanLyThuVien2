using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Thongke : Form
    {


        string strConnect = @"Data Source=LAPTOP-RFF4KPTS\CHIEN;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlDataReader reader;
        string query;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataAdapter adapter;
        public Thongke()
        {
            InitializeComponent();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            query = "select sach.ten as Tên_sách,sach.theloai as Thể_loại,sach.tacgia as Tác_giả,count (*) as Số_lượt_mượn from sach inner join muonsach on sach.idsach = muonsach.idsach group by sach.ten,sach.theloai,sach.tacgia";
            cmd = new SqlCommand(query,con);
            reader = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(reader);
            reader.Close();
            dataGridView1.DataSource = dt;
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strConnect);
            con.Open();
        }

        private void btnTreHan_Click(object sender, EventArgs e)
        {
            query = "select nguoidung.tennguoidung as Họ_và_tên,nguoidung.ngaysinh as Ngày_sinh,nguoidung.gioitinh as Giới_tính,nguoidung.sdt as SĐT,sach.ten as Tên_sách,sach.theloai as Thể_loại,sach.tacgia as Tác_giả " +
                "from nguoidung inner join muonsach on nguoidung.idnguoidung = muonsach.idnguoidung " +
                "inner join sach on sach.idsach = muonsach.idsach" +
                "where day(ngaytra)<day(getdate()) and month(ngaytra) < month(getdate()) and year(ngaytra) < year(getdate())";
            cmd = new SqlCommand(query,con);
            reader = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(reader);
            reader.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
