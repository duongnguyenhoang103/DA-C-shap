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
    public partial class frmNXB : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtNXB;

        public frmNXB()
        {
            InitializeComponent();
        }

        public void cap_nhat()
        {
            dtNXB = Global.LayDuLieu("SELECT * FROM NXB");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtNXB.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                listView1.Items.Add(maso, ten, 0);
            }
        }

        private void frmNXB_Load(object sender, EventArgs e)
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

        private void mn_them_Click(object sender, EventArgs e)
        {
            Them.frmAddNXB f = new QuanLyThuVien.Them.frmAddNXB();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = Global.result_NXB.Split('#');
                string maNXB = tmp[0];
                string ten = tmp[1];
                string rs = Global.ChayStoredProcedure("SP_NHAP_NXB", new string[] { "maNXB:" + maNXB, "tenNXB:" + ten});
                if (rs.Substring(0, 2).ToUpper() == "OK")
                {
                    Global.ThongBao(rs.Substring(3, rs.Length - 3));
                    cap_nhat();
                }
                else Global.BaoLoi(rs.Substring(3, rs.Length - 3));
            }
        }

        public void Xoa()
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (Global.ThongBao("Bạn có chắc là muốn xóa đối tượng này không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string ten = listView1.SelectedItems[0].Name;
                    string kq = Global.ChayStoredProcedure("SP_XOA_NXB", new string[] { "maNXB:" + ten });
                    if (kq.Substring(0, 2).ToUpper() == "OK")
                    {
                        Global.TruyVan("UPDATE Sach SET manxb='0' WHERE manxb='" + ten + "'");
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
                DataTable dt = Global.LayDuLieu("SELECT * FROM NXB WHERE maNXB='" + listView1.SelectedItems[0].Name + "'");
                if (dt.Rows.Count > 0)
                {
                    txtMa.Text = dt.Rows[0].ItemArray[1].ToString();
                    txtTen.Text = dt.Rows[0].ItemArray[2].ToString();
                }
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
            string rs = Global.ChayStoredProcedure("SP_SUA_NXB", new string[] { "maNXB:" + txtMa.Text, "tenNXB:" + txtTen.Text});
            if (rs.Substring(0, 2).ToUpper() == "OK")
            {
                Global.ThongBao(rs.Substring(3, rs.Length - 3));
                cap_nhat();
            }
            else Global.BaoLoi(rs.Substring(3, rs.Length - 3));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dtNXB = Global.LayDuLieu("SELECT * FROM NXB WHERE manxb LIKE '%"+txtSearch.Text+"%' OR tennxb LIKE N'%"+txtSearch.Text+"%'");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtNXB.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                listView1.Items.Add(maso, ten, 0);
            }
        }
    }
}
