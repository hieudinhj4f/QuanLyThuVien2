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
    public partial class Admin_Mangagement : Form
    {
        //Check SideBar
        bool SideBarExpand;
        public Admin_Mangagement()
        {
            InitializeComponent();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if( SideBarExpand )
            {
                // if sidebar is expand , minimize 
                SideBar.Width -= 100;
                if( SideBar.Width == SideBar.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 100;
                if ( SideBar.Width == SideBar.MaximumSize.Width )
                {
                    SideBarExpand = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Thongke f = new Thongke();
            f.Show();
        }

        private void Admin_Mangagement_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePsssWord f = new ChangePsssWord();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select f = new Select();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachYeuThich f =new DanhSachYeuThich();
            f.Show();
            this.Hide();
        }
    }
}
