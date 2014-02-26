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
    public partial class frmLoaiSach : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtLoaiSach;

        public frmLoaiSach()
        {
            InitializeComponent();
        }

        public void cap_nhat()
        {
            dtLoaiSach = Global.LayDuLieu("SELECT * FROM LoaiSach");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtLoaiSach.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                listView1.Items.Add(maso, ten, 0);
            }
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
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
            Them.frmAddLoaiSach f = new QuanLyThuVien.Them.frmAddLoaiSach();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = Global.result_LoaiSach.Split('#');
                string maLoaiSach = tmp[0];
                string ten = tmp[1];
                string rs = Global.ChayStoredProcedure("SP_NHAP_LoaiSach", new string[] { "maLoaiSach:" + maLoaiSach, "tenloaisach:" + ten});
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
                    string kq = Global.ChayStoredProcedure("SP_XOA_LoaiSach", new string[] { "maLoaiSach:" + ten });
                    if (kq.Substring(0, 2).ToUpper() == "OK")
                    {
                        Global.TruyVan("UPDATE Sach SET matacgia='0' WHERE matacgia='" + ten + "'");
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
                DataTable dt = Global.LayDuLieu("SELECT * FROM LoaiSach WHERE maLoaiSach='" + listView1.SelectedItems[0].Name + "'");
                if (dt.Rows.Count > 0)
                {
                    txtMa.Text = dt.Rows[0].ItemArray[1].ToString();
                    txtTen.Text = dt.Rows[0].ItemArray[2].ToString();
                }
                DataTable ds = Global.LayDuLieu("SELECT * FROM Sach WHERE maloaisach='" + listView1.SelectedItems[0].Name + "'");
                lst_sach.Items.Clear();
                if (ds.Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Rows.Count; i++)
                    {
                        lst_sach.Items.Add(ds.Rows[i].ItemArray[1].ToString() + "." + ds.Rows[i].ItemArray[2].ToString());
                    }
                }
                else
                {
                    lst_sach.Items.Add("Chưa có sách nào thuộc mục này!");
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
            string rs = Global.ChayStoredProcedure("SP_SUA_LOAISACH", new string[] { "maloaisach:" + txtMa.Text, "tenloaisach:" + txtTen.Text});
            if (rs.Substring(0, 2).ToUpper() == "OK")
            {
                Global.ThongBao(rs.Substring(3, rs.Length - 3));
                cap_nhat();
            }
            else Global.BaoLoi(rs.Substring(3, rs.Length - 3));
        }

        private void pn_thongtin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataTable dt = Global.LayDuLieu("SELECT * FROM LoaiSach WHERE maloaisach LIKE N'%"+txtSearch.Text+"%' or tenloaisach LIKE N'%" + txtSearch.Text + "%'");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string maso = dr[1].ToString();
                    string ten = dr[2].ToString();
                    listView1.Items.Add(maso, ten, 0);
                }
            }
            else Global.ThongBao("Không tìm thấy thông tin bạn yêu cầu!");
        }
    }
}
