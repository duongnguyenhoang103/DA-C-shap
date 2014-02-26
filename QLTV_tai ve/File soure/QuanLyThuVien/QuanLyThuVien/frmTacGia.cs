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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtTacGia;

        public frmTacGia()
        {
            InitializeComponent();
        }

        public void cap_nhat()
        {
            dtTacGia = Global.LayDuLieu("SELECT * FROM TacGia");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtTacGia.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                listView1.Items.Add(maso, ten, 0);
            }
        }

        private void frmTacGia_Load(object sender, EventArgs e)
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

        public void ThemTG()
        {
            Them.frmAddTacGia f = new QuanLyThuVien.Them.frmAddTacGia();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = Global.result_TacGia.Split('#');
                string maTacGia = tmp[0];
                string ten = tmp[1];
                string ngaysinh = tmp[2];
                string rs = Global.ChayStoredProcedure("SP_NHAP_TacGia", new string[] { "maTacGia:" + maTacGia, "tentacgia:" + ten, "ngaysinh:" + ngaysinh });
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
            ThemTG();
        }

        public void Xoa()
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (Global.ThongBao("Bạn có chắc là muốn xóa đối tượng này không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string ten = listView1.SelectedItems[0].Name;
                    string kq = Global.ChayStoredProcedure("SP_XOA_TacGia", new string[] { "maTacGia:" + ten });
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
                DataTable dt = Global.LayDuLieu("SELECT * FROM TacGia WHERE maTacGia='" + listView1.SelectedItems[0].Name + "'");
                if (dt.Rows.Count > 0)
                {
                    txtMa.Text = dt.Rows[0].ItemArray[1].ToString();
                    txtTen.Text = dt.Rows[0].ItemArray[2].ToString();
                    try
                    {
                        dNgaySinh.EditValue = (DateTime)dt.Rows[0].ItemArray[3];
                    }
                    catch { dNgaySinh.EditValue = DateTime.Today; }
                }
                DataTable ds = Global.LayDuLieu("SELECT * FROM Sach WHERE matacgia='" + listView1.SelectedItems[0].Name + "'");
                lst_sach.Items.Clear();
                if (ds.Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Rows.Count; i++)
                    {
                        lst_sach.Items.Add(ds.Rows[i].ItemArray[1].ToString()+"."+ds.Rows[i].ItemArray[2].ToString());
                    }
                }
                else
                {
                    lst_sach.Items.Add("Chưa có sách nào của tác giả này!");
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
            string rs = Global.ChayStoredProcedure("SP_SUA_TacGia", new string[] { "maTacGia:" + txtMa.Text, "tentacgia:" + txtTen.Text, "ngaysinh:" + ((DateTime)dNgaySinh.EditValue).ToShortDateString()});
            if (rs.Substring(0, 2).ToUpper() == "OK")
            {
                Global.ThongBao(rs.Substring(3, rs.Length - 3));
                cap_nhat();
            }
            else Global.BaoLoi(rs.Substring(3, rs.Length - 3));
        }

        private void lst_sach_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lst_sach.SelectedItems.Count > 0)
                {
                    lst_sach.ContextMenuStrip = contextMenuStrip1;
                    contextMenuStrip1.Show();
                }
                else
                {
                    lst_sach.ContextMenuStrip = null;
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dtTacGia = Global.LayDuLieu("SELECT * FROM TacGia WHERE matacgia LIKE '%"+txtSearch.Text+"%' OR tentacgia LIKE '%"+txtSearch.Text+"%'");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtTacGia.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                listView1.Items.Add(maso, ten, 0);
            }
        }
    }
}
