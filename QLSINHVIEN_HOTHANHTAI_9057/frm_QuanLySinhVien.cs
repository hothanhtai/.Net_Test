using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSINHVIEN_HOTHANHTAI_9057
{
    public partial class frm_QuanLySinhVien : Form
    {
        public frm_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frm_SinhVien"] == null)
            {
                frm_SinhVien sv = new frm_SinhVien();
                sv.MdiParent = this;
                sv.Show();
                sv.Location = new Point(100, 100);


            }
            else
            {
                Application.OpenForms["frm_SinhVien"].Activate();
            }
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KhachHang"] == null)
            {
                frm_KhachHang kh = new frm_KhachHang();
                kh.MdiParent = this;
                kh.Show();
                kh.Location = new Point(200, 100);
            }
            else
            {
                Application.OpenForms["frm_KhachHang"].Activate();
            }
        }
    }
}
