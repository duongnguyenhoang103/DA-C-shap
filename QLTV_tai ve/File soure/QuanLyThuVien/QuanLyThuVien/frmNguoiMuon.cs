using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frmNguoiMuon : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtNguoiMuon;

        public frmNguoiMuon()
        {
            InitializeComponent();
        }

        public void cap_nhat()
        {
            dtNguoiMuon = Global.LayDuLieu("SELECT * FROM nguoimuon");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtNguoiMuon.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                int gt = int.Parse(dr[3].ToString());
                listView1.Items.Add(maso, ten, gt);
            }
        }

        public void cap_nhat_gt()
        {
            dtNguoiMuon = Global.LayDuLieu("SELECT * FROM nguoimuon");
            listView1.Groups.Clear();
            listView1.Groups.Add("Nu", "Nữ");
            listView1.Groups.Add("Nam", "Nam");
            listView1.Clear();
            listView1.ShowGroups = true;

            foreach (DataRow dr in dtNguoiMuon.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                int gt = int.Parse(dr[3].ToString());
                ListViewItem lv = new ListViewItem(ten, gt.ToString(), listView1.Groups[gt]);
                lv.Name = maso;
                lv.ImageIndex = gt;
                listView1.Items.Add(lv);
            }
        }

        private void frmNguoiMuon_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cap_nhat();
            pn_thongtin.Top = splitContainer1.Panel2.Height / 2 - pn_thongtin.Height / 2;
            pn_thongtin.Left = splitContainer1.Panel2.Width / 2 - pn_thongtin.Width / 2;
        }

        private void mn_capnhat_Click(object sender, EventArgs e)
        {
            cap_nhat();
        }

        public void ThemNM()
        {
            Them.frmAddNguoiMuon f = new QuanLyThuVien.Them.frmAddNguoiMuon();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = Global.result_NguoiMuon.Split('#');
                string manguoimuon = tmp[0];
                string ten = tmp[1];
                string gioitinh = tmp[2];
                string ngaysinh = tmp[3];
                string sodt = tmp[4];
                string rs = Global.ChayStoredProcedure("SP_NHAP_NGUOIMUON", new string[] { "manguoimuon:" + manguoimuon, "ten:" + ten, "gioitinh:" + gioitinh, "ngaysinh:" + ngaysinh, "sodienthoai:" + sodt });
                if (rs.Substring(0, 2).ToUpper() == "OK")
                {
                    Global.ThongBao(rs.Substring(3, rs.Length - 3));
                    cap_nhat();
                }
                else Global.BaoLoi(rs.Substring(3, rs.Length - 3));
            }
        }

        private void mn_them_Click(object sender, EventArgs e)
        {
            ThemNM();
        }

        public void Xoa()
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (Global.ThongBao("Bạn có chắc là muốn xóa đối tượng này không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string ten = listView1.SelectedItems[0].Name;
                    string kq = Global.ChayStoredProcedure("SP_XOA_NGUOIMUON", new string[] { "manguoimuon:" + ten });
                    if (kq.Substring(0, 2).ToUpper() == "OK")
                    {
                        Global.ThongBao(kq.Substring(3, kq.Length - 3));
                        cap_nhat();
                    }
                    else
                    {
                        Global.BaoLoi(kq.Substring(3, kq.Length - 3));
                    }
                }
            }
        }

        private void mn_delete_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void mngopgtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cap_nhat_gt();
        }

        private void mngopdfaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cap_nhat();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Xoa();
            }
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            pn_thongtin.Top = splitContainer1.Panel2.Height / 2 - pn_thongtin.Height / 2;
            pn_thongtin.Left = splitContainer1.Panel2.Width / 2 - pn_thongtin.Width / 2;
        }

        public void lay_thong_tin()
        {
            if (listView1.SelectedItems.Count != 0)
            {
                DataTable dt = Global.LayDuLieu("SELECT * FROM nguoimuon WHERE manguoimuon='" + listView1.SelectedItems[0].Name + "'");
                txtMa.Text = dt.Rows[0].ItemArray[1].ToString();
                txtTen.Text = dt.Rows[0].ItemArray[2].ToString();
                if (int.Parse(dt.Rows[0].ItemArray[3].ToString()) == 1)
                    rNam.Checked = true;
                else rNu.Checked = true;
                dNgaySinh.EditValue = (DateTime)dt.Rows[0].ItemArray[4];
                txtSoDt.Text = dt.Rows[0].ItemArray[5].ToString();
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lay_thong_tin();
        }

        private void btn_thoi_Click(object sender, EventArgs e)
        {
            lay_thong_tin();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string gioitinh = "1";
            if (rNam.Checked) gioitinh = "1";
            else gioitinh = "0";
            string rs = Global.ChayStoredProcedure("SP_SUA_NGUOIMUON", new string[] { "manguoimuon:" + txtMa.Text, "ten:" + txtTen.Text, "gioitinh:" + gioitinh, "ngaysinh:" + ((DateTime)dNgaySinh.EditValue).ToShortDateString(), "sodienthoai:" + txtSoDt.Text });
            if (rs.Substring(0, 2).ToUpper() == "OK")
            {
                Global.ThongBao(rs.Substring(3, rs.Length - 3));
                cap_nhat();
            }
            else Global.BaoLoi(rs.Substring(3, rs.Length - 3));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dtNguoiMuon = Global.LayDuLieu("SELECT * FROM nguoimuon WHERE manguoimuon LIKE '%"+txtSearch.Text+"%' OR ten LIKE N'%"+txtSearch.Text+"%'");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtNguoiMuon.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                int gt = int.Parse(dr[3].ToString());
                listView1.Items.Add(maso, ten, gt);
            }
        }
    }
}
