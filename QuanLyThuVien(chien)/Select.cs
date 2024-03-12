using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllBooks f  = new AllBooks();
            f.Show();
            this.Hide();
        }

        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachYeuThich f = new DanhSachYeuThich();
            f.Show();
            this.Hide();
        }
    }
}
