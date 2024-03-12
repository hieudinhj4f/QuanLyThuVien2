using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Sach : UserControl
    {
        public Sach()
        {
            InitializeComponent();
        }
        //
        static string SachConn = "Data Source=HIEUDINHLAPTOP\\SQLEXPRESS;" +
                          "Initial Catalog=QuanLyThuVien;" +
                          "Integrated Security=True";
        SqlConnection BookConn = new SqlConnection(SachConn);
        DataTable SachData = new DataTable();
        SqlCommand cmd = new SqlCommand();


        private void Sach_Load(object sender, EventArgs e)
        {
            BookConn.Open();
           
            cmd.CommandText = "Select * from Sach";
            cmd.Connection = BookConn;

            SqlDataReader reader = cmd.ExecuteReader();
            SachData.Load(reader);
            SachGridView.DataSource = SachData;
            BookConn.Close();
        }

        private void SachGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexx = e.RowIndex;
            DataRow row = SachData.Rows[indexx];

            IDSachBox.Text = row["IDSach"].ToString();
            SACHBOX.Text = row["Ten"].ToString();
            TheLoaiBox.Text = row["TheLoai"].ToString();
            TacGiaBox.Text = row["TacGia"].ToString();
            GiaThueBox.Text = row["GiaThue"].ToString();
        }

        private void SearchingButton_Click(object sender, EventArgs e)
        {
            BookConn.Open();
            SachData.Clear();
            
            string SearchingQuery= $"Select * from Sach Where Ten = '{SearchingBox.Text}'";
            SqlCommand Search = new SqlCommand(SearchingQuery,BookConn);


            //DolaiDulieuc
            SqlDataReader SearchReader = Search.ExecuteReader();   
            SachData.Load(SearchReader);
            SachGridView.DataSource = SachData;
            //Do du lieu thanh tim kiem
            DataGridViewRow dt = SachGridView.Rows[0];

            IDSachBox.Text = dt.Cells["IDsach"].Value.ToString();
            SACHBOX.Text = dt.Cells["Ten"].Value.ToString() ;
            TheLoaiBox.Text = dt.Cells["TheLoai"].Value.ToString();
            TacGiaBox.Text = dt.Cells["TacGia"].Value.ToString();
            GiaThueBox.Text = dt.Cells["GiaThue"].Value.ToString(); ;


            BookConn.Close();

        }
        //ADD BUTTON
        private void ADDbutton_Click(object sender, EventArgs e)
        {
            SachData.Clear();

            BookConn.Open();
            string ADDquery = "Insert into Sach(Ten,TheLoai,TacGia,GiaThue)" +
                              "Values " +
                              $"('{SACHBOX.Text}','{TheLoaiBox.Text}','{TacGiaBox.Text}','{Convert.ToInt32(GiaThueBox.Text)}')";
            SqlCommand ADD = new SqlCommand(ADDquery,BookConn);
            ADD.ExecuteNonQuery();
            //DolaiDulieu

            SqlDataReader reader = cmd.ExecuteReader();
            SachData.Load(reader);
            SachGridView.DataSource = SachData;

            BookConn.Close();

        }
        //UPDATE BUTTON
        private void EditButton_Click(object sender, EventArgs e)
        {
            SachData.Clear();

            BookConn.Open();
            string UPDATEquery = "UPDATE Sach " +
                              "SET " +
                              $"Ten = '{SACHBOX.Text}'," +
                              $"TheLoai = '{TheLoaiBox.Text}'," +
                              $"TacGia= '{TacGiaBox.Text}'," +
                              $"GiaThue = '{Convert.ToInt32(GiaThueBox.Text)}' " +
                              $"Where IDsach = '{Convert.ToInt32(IDSachBox.Text)}'";
            SqlCommand UPDATE = new SqlCommand(UPDATEquery, BookConn);
            UPDATE.ExecuteNonQuery();
            //DolaiDulieu

            SqlDataReader reader = cmd.ExecuteReader();
            SachData.Load(reader);
            SachGridView.DataSource = SachData;

            BookConn.Close();

        }
        //DELETE BUTTON
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SachData.Clear();

            BookConn.Open();
            string DELquery = "Delete from Sach " +
                              $"where IDsach = '{IDSachBox.Text}'";
                              
            SqlCommand DEL = new SqlCommand(DELquery, BookConn);
            DEL.ExecuteNonQuery();
            //DolaiDulieu

            SqlDataReader reader = cmd.ExecuteReader();
            SachData.Load(reader);
            SachGridView.DataSource = SachData;

            BookConn.Close();
        }
    }

}
