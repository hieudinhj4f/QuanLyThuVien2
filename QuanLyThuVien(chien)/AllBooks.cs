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
    public partial class AllBooks : Form
    {

        string strConnect = @"Data Source=LAPTOP-RFF4KPTS\CHIEN;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False";
        SqlConnection con;
        SqlDataReader reader;
        string query;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataAdapter adapter;
        public AllBooks()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Select f = new Select();
            this.Hide();
            f.Show();
        }

        private void AllBooks_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strConnect);
            con.Open();
            query = $"Select idsach as STT,ten as Tên_sách,theloai as Thể_loại,tacgia as Tác_giả from sach";
            cmd=  new SqlCommand(query, con);
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int idSach = -1;
        string ten;
        string theLoai;
        string tacGia;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                DataRow row = dt.Rows[i];
                idSach = Convert.ToInt32(row[0].ToString());
                ten = row[1].ToString();
                theLoai = row[2].ToString();
                tacGia = row[3].ToString();
            }
            catch(Exception ex)
            {

            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            query = $"Select * from yeuthich4 where idSach = {Convert.ToInt32(idSach)} and idnguoidung = {ID.idNguoiDung}";
            cmd = new SqlCommand(query, con);
            reader = cmd.ExecuteReader();
            bool check = reader.Read();
            if(check == true)
            {
                MessageBox.Show("Sách đã có trong danh sách yêu thích!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            reader.Close();


            query = $"Insert into yeuthich4 values({idSach},{ID.idNguoiDung},'{txtGhiChu.Text}')";
            cmd = new SqlCommand(query, con);
            if(idSach != -1 && check == false) { 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm thành công!", "Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
