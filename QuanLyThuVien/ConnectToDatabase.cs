using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class ConnectToDatabase
    {
        static public string str_conn = "Data Source=LAPTOP-RT1ETNCP\\LYDUYBACH;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        static public SqlConnection conn = new SqlConnection(str_conn);
        static public void init()
        {
            conn.Open();
        }
        static public void close()
        {
            conn.Close();
        }
    }
}
