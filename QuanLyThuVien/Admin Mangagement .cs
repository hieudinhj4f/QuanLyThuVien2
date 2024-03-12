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
            SideBarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book_Borrow book_Borrow = new Book_Borrow();
            book_Borrow.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book_Return book_Return = new Book_Return();
            book_Return.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book_Cart book_Cart = new Book_Cart();
            book_Cart.Show();
            this.Hide();
        }
    }
}
