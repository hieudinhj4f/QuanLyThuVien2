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
    public partial class ThongTin : UserControl
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        //
        static string SachConn = "Data Source=HIEUDINHLAPTOP\\SQLEXPRESS;" +
                          "Initial Catalog=QuanLyThuVien;" +
                          "Integrated Security=True";
        SqlConnection BookConn = new SqlConnection(SachConn);
        DataTable SachData = new DataTable();
        DataTable SachData2 = new DataTable();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();


        private void ThongTin_Load(object sender, EventArgs e)
        {
            //Bang Muon_tra
            BookConn.Open();
            cmd.CommandText = "Select * from MuonSach";
            cmd.Connection = BookConn;

            SqlDataReader reader = cmd.ExecuteReader();
            SachData.Load(reader);
            BorowReturn.DataSource = SachData;
            BookConn.Close();
            //Bang Nguoi Dung
            BookConn.Open();
            cmd2.CommandText = "Select IDnguoidung,TenNguoiDung,NgaySinh,GioiTinh,SDT from NguoiDung ";
            cmd2.Connection = BookConn;
           
            SqlDataReader reader2 = cmd2.ExecuteReader();
            SachData2.Load(reader2);
            in4.DataSource = SachData2;
            BookConn.Close();

        }

        private void in4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookConn.Open();
            SachData.Clear();
            int indexxxx = e.RowIndex;
            DataRow rowww = SachData2.Rows[indexxxx];

            string CheckCheck = "Select * " +
                                $"from MuonSach where IDnguoidung = '{rowww["IDnguoidung"].ToString()}'";
            SqlCommand kiemtra = new SqlCommand(CheckCheck, BookConn);
            

            SqlDataReader kiemtraread = kiemtra.ExecuteReader();
            SachData.Load(kiemtraread);
            BorowReturn.DataSource = SachData;

            BookConn.Close();
        }
    }

}
