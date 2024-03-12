using Microsoft.Win32;
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
                SideBar.Width -= 10;
                if( SideBar.Width == SideBar.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    SideBarTimer.Stop();

                    button1.Enabled = false;
                    button3.Enabled = false;
                    ExitButton.Enabled = false;

                }
            }
            else
            {
                SideBar.Width += 10;
                if ( SideBar.Width == SideBar.MaximumSize.Width )
                {
                    SideBarExpand = true;
                    SideBarTimer.Stop();

                    button1.Enabled = true;
                    button3.Enabled = true;
                    ExitButton.Enabled = true;
                }
            }
        }
        //KhoiDongSideBar
        private void HomeButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }
        //Nut Thoat
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangingUser(UserControl usercontrol)
        {
            usercontrol.Dock= DockStyle.Fill;
            PanelParent.Controls.Clear();
            PanelParent.Controls.Add(usercontrol);
            usercontrol.BringToFront();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Sach book = new Sach();
            ChangingUser(book);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTin tt = new ThongTin();
            ChangingUser(tt);
        }

        private void Admin_Mangagement_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            ExitButton.Enabled = false;
        }
    }
}
