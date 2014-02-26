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
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtSach;

        public frmSach()
        {
            InitializeComponent();
        }

        public void lay_thong_tin_nhap(string masach)
        {
            lst_nhap.Items.Clear();
            DataTable d = Global.LayDuLieu("SELECT * FROM nhapsach WHERE masach='" + masach + "'");
            if (d.Rows.Count > 0)
            {
                for (int i = 0; i < d.Rows.Count; i++)
                {
                    lst_nhap.Items.Add("Ngày: " + d.Rows[i].ItemArray[2].ToString() + " - Số lượng: " + d.Rows[i].ItemArray[3].ToString());
                }
            }
        }

        public void cap_nhat()
        {
            dtSach = Global.LayDuLieu("SELECT * FROM Sach");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtSach.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                listView1.Items.Add(maso, ten, 0);
            }
            get_nxb();
            get_tacgia();
            get_loaisach();
        }

        private void frmSach_Load(object sender, EventArgs e)
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

        public string get_maloaisach(string ten)
        {
            if (ten.ToUpper() != "CHƯA BIẾT")
            {
                string s = Global.TruyVan("SELECT maloaisach FROM loaisach WHERE tenloaisach=N'" + ten + "'");
                return s;
            }
            else
            {
                return "0";
            }
        }

        public string get_manxb(string ten)
        {
            if (ten.ToUpper() != "CHƯA BIẾT")
            {
                string s = Global.TruyVan("SELECT manxb FROM nxb WHERE tennxb=N'" + ten + "'");
                return s;
            }
            else
            {
                return "0";
            }
        }

        public string get_matacgia(string ten)
        {
            if (ten.ToUpper() != "CHƯA BIẾT")
            {
                string s = Global.TruyVan("SELECT matacgia FROM tacgia WHERE tentacgia=N'" + ten + "'");
                return s;
            }
            else
            {
                return "0";
            }
        }

        private void mn_them_Click(object sender, EventArgs e)
        {
            Them.frmAddSach f = new QuanLyThuVien.Them.frmAddSach();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string[] tmp = Global.result_Sach.Split('#');
                string maSach = tmp[0];
                string ten = tmp[1];
                string lsach = get_maloaisach(tmp[2]);
                string nxb = get_manxb(tmp[3]);
                string soluong = tmp[4];
                string sotrang = tmp[5];
                string tacgia = get_matacgia(tmp[6]);
                string rs = Global.ChayStoredProcedure("SP_THEM_SACH", new string[] { "maSach:" + maSach, "tenSach:" + ten, "maloaisach:"+ lsach ,
                                                        "soluong:" + soluong, "sotrang:"+sotrang, "matacgia:"+tacgia, "manxb:"+nxb });
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
                    string kq = Global.ChayStoredProcedure("SP_XOA_Sach", new string[] { "maSach:" + ten });
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

        public void get_loaisach()
        {
            cbLoai.Properties.Items.Clear();
            DataTable dt = Global.LayDuLieu("SELECT tenloaisach FROM loaisach");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbLoai.Properties.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                }
            }
            cbLoai.Properties.Sorted = true;
        }

        public string get_loaisach(string ma)
        {
            if (ma.ToUpper() != "0")
            {
                string s = Global.TruyVan("SELECT tenloaisach FROM loaisach WHERE maloaisach='" + ma + "'");
                return s;
            }
            else
            {
                return "Chưa biết";
            }
        }

        public void get_nxb()
        {
            cbNXB.Properties.Items.Clear();
            DataTable dt = Global.LayDuLieu("SELECT tennxb FROM nxb");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbNXB.Properties.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                }
            }
            cbNXB.Properties.Sorted = true;
        }

        public string get_nxb(string ma)
        {
            if (ma.ToUpper() != "0")
            {
                string s = Global.TruyVan("SELECT tennxb FROM nxb WHERE manxb='" + ma + "'");
                return s;
            }
            else
            {
                return "Chưa biết";
            }
        }

        public void get_tacgia()
        {
            cbTacgia.Properties.Items.Clear();
            DataTable dt = Global.LayDuLieu("SELECT tentacgia FROM tacgia");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbTacgia.Properties.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                }
            }
            cbTacgia.Properties.Sorted = true;
        }

        public string get_tacgia(string ma)
        {
            if (ma.ToUpper() != "0")
            {
                string s = Global.TruyVan("SELECT tentacgia FROM tacgia WHERE matacgia='" + ma + "'");
                return s;
            }
            else
            {
                return "Chưa biết";
            }
        }

        public void lay_thong_tin()
        {
            get_tacgia();
            get_nxb();
            get_loaisach();
            if (listView1.SelectedItems.Count != 0)
            {
                DataTable dt = Global.LayDuLieu("SELECT * FROM Sach WHERE maSach='" + listView1.SelectedItems[0].Name + "'");
                if (dt.Rows.Count > 0)
                {
                    txtMa.Text = dt.Rows[0].ItemArray[1].ToString();
                    txtTen.Text = dt.Rows[0].ItemArray[2].ToString();
                    cbLoai.Text = get_loaisach(dt.Rows[0].ItemArray[3].ToString());
                    txtSoluong.Text = dt.Rows[0].ItemArray[4].ToString();
                    txtSoTrang.Text = dt.Rows[0].ItemArray[5].ToString();
                    cbTacgia.Text = get_tacgia(dt.Rows[0].ItemArray[6].ToString());
                    cbNXB.Text = get_nxb(dt.Rows[0].ItemArray[7].ToString());
                }
                else
                {
                    txtMa.Text = "";
                    txtTen.Text = "";
                    cbLoai.Text = "Chưa biết";
                    txtSoluong.Text = "";
                    txtSoTrang.Text = "";
                    cbTacgia.Text = "Chưa biết";
                    cbNXB.Text = "Chưa biết";
                }
            }
            lay_thong_tin_nhap(txtMa.Text);
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
            string maSach = txtMa.Text;
            string ten = txtTen.Text;
            string lsach = get_maloaisach(cbLoai.Text);
            string nxb = get_manxb(cbNXB.Text);
            string soluong = txtSoluong.Text;
            string sotrang = txtSoTrang.Text;
            string tacgia = get_matacgia(cbTacgia.Text);
            string rs = Global.ChayStoredProcedure("SP_SUA_Sach", new string[] { "maSach:" + maSach, "tenSach:" + ten, "maloaisach:"+ lsach ,
                                                        "soluong:" + soluong, "sotrang:"+sotrang, "matacgia:"+tacgia, "manxb:"+nxb});
            if (rs.Substring(0, 2).ToUpper() == "OK")
            {
                Global.ThongBao(rs.Substring(3, rs.Length - 3));
                cap_nhat();
            }
            else Global.BaoLoi(rs.Substring(3, rs.Length - 3));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string rs = Global.ChayStoredProcedure("SP_NHAPSACH", new string[] { "maSach:" + txtMa.Text, "ngaynhap:" + DateTime.Now.ToShortDateString(), "soluong:" + txtThem.Text});
            if (rs.Substring(0, 2).ToUpper() == "OK")
            {
                Global.ThongBao(rs.Substring(3, rs.Length - 3));
                cap_nhat();
                lay_thong_tin();
            }
            else Global.BaoLoi(rs.Substring(3, rs.Length - 3));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dtSach = Global.LayDuLieu("SELECT * FROM Sach WHERE masach LIKE '%"+txtSearch.Text+"%' OR tensach LIKE N'%"+txtSearch.Text+"%'");
            listView1.Groups.Clear();
            listView1.Clear();
            listView1.ShowGroups = false;
            foreach (DataRow dr in dtSach.Rows)
            {
                string maso = dr[1].ToString();
                string ten = dr[2].ToString();
                listView1.Items.Add(maso, ten, 0);
            }
            get_nxb();
            get_tacgia();
            get_loaisach();
        }
    }
}
