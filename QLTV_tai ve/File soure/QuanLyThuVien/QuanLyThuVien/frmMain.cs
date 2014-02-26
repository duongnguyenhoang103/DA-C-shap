using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace QuanLyThuVien
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private Bitmap _backBuffer;
        public frmMain()
        {
            InitializeComponent();
            this.SetStyle(
                  ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint |
                  ControlStyles.DoubleBuffer, true);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            frmBackground fB = new frmBackground();
            fB.MdiParent = this;
            fB.Top = 0;
            fB.Left = 0;
            fB.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.frmMuonSach == null || Global.frmMuonSach.IsDisposed)
                Global.frmMuonSach = new frmMuonSach();
            Global.frmMuonSach.MdiParent = this;
            Global.frmMuonSach.Show();
            Global.frmMuonSach.BringToFront();
            lbl_stt.Text = this.Text;
        }

        private void mnLoginout_Click(object sender, EventArgs e)
        {
            if (Global.ThongBao("Bạn có chắc là muốn thoát khỏi tài khoản này không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Global.LoginForm.Show();
                this.Hide();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.ThongBao("Bạn có chắc là muốn thoát không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.ExitThread();
        }

        private void quảnLýDanhSáchThẻMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.frmNguoiMuon == null || Global.frmNguoiMuon.IsDisposed)
                Global.frmNguoiMuon = new frmNguoiMuon();
            Global.frmNguoiMuon.MdiParent = this;
            Global.frmNguoiMuon.Show();
            Global.frmNguoiMuon.BringToFront();
            lbl_stt.Text = this.Text;
        }

        private void làmThẻMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.frmNguoiMuon == null || Global.frmNguoiMuon.IsDisposed)
                Global.frmNguoiMuon = new frmNguoiMuon();
            Global.frmNguoiMuon.MdiParent = this;
            Global.frmNguoiMuon.Show();
            Global.frmNguoiMuon.BringToFront();
            Global.frmNguoiMuon.ThemNM();
            lbl_stt.Text = this.Text;
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.frmLoaiSach == null || Global.frmLoaiSach.IsDisposed)
                Global.frmLoaiSach = new frmLoaiSach();
            Global.frmLoaiSach.MdiParent = this;
            Global.frmLoaiSach.Show();
            Global.frmLoaiSach.BringToFront();
            lbl_stt.Text = this.Text;
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.frmTacGia == null || Global.frmTacGia.IsDisposed)
                Global.frmTacGia = new frmTacGia();
            Global.frmTacGia.MdiParent = this;
            Global.frmTacGia.Show();
            Global.frmTacGia.BringToFront();
            lbl_stt.Text = this.Text;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Global.frmNxb == null || Global.frmNxb.IsDisposed)
                Global.frmNxb = new frmNXB();
            Global.frmNxb.MdiParent = this;
            Global.frmNxb.Show();
            Global.frmNxb.BringToFront();
            lbl_stt.Text = this.Text;
        }

        private void khoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.frmSach == null || Global.frmSach.IsDisposed)
                Global.frmSach = new frmSach();
            Global.frmSach.MdiParent = this;
            Global.frmSach.Show();
            Global.frmSach.BringToFront();
            lbl_stt.Text = this.Text;
        }
    }
}
