using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.Them;

namespace QuanLyThuVien
{
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }

        public void cap_nhat()
        {
            DataTable dt = Global.LayDuLieu("SELECT stt as 'STT', manguoimuon as 'Mã người mượn', masach as 'Mã sách'," + 
                                            "soluong as 'Số lượng', ngaymuon as 'Ngày mượn', hentra as 'Ngày hẹn trả', ngaytra as 'Ngày trả' FROM muonsach");
            gridControl1.DataSource = dt;
            gridView1.BestFitColumns();
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            pn_muon_info.Top = splitContainer1.Panel1.Height / 2 - pn_muon_info.Height / 2;
            pn_muon_info.Left = splitContainer1.Panel1.Width / 2 - pn_muon_info.Width / 2;
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cap_nhat();
            pn_muon_info.Top = splitContainer1.Panel1.Height / 2 - pn_muon_info.Height / 2;
            pn_muon_info.Left = splitContainer1.Panel1.Width / 2 - pn_muon_info.Width / 2;
        }

        public void lay_thong_tin(int stt)
        {
            DataTable dt = Global.LayDuLieu("SELECT * FROM muonsach WHERE stt=" + stt.ToString());
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string manm = dr.ItemArray[1].ToString();
                string masach = dr.ItemArray[2].ToString();
                string soluong = dr.ItemArray[3].ToString();
                string ngaymuon = dr.ItemArray[4].ToString();
                string hentra = dr.ItemArray[5].ToString();
                string ngaytra = dr.ItemArray[6].ToString();
                lMaNM.Text = manm;
                lMaSach.Text = masach;
                lSoLuongM.Text = soluong;
                lNgayMuon.Text = ngaymuon;
                lNgayTra.Text = ngaytra;
                lHenTra.Text = hentra;
            }
            else
            {
                lMaNM.Text = "";
                lTenNM.Text = "";
                lNgSinh.Text = "";
                lSoDT.Text = "";
                lMaSach.Text = "";
                lTenSach.Text = "";
                lTheLoai.Text = "";
                lTacGia.Text = "";
                lNXB.Text = "";
                lSoTrang.Text = "";
                lSoLuongCon.Text = "";
                lSoLuongM.Text = "";
                lNgayTra.Text = "";
                lNgayMuon.Text = "";
                lHenTra.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cap_nhat();
        }

        public void xoa(int stt)
        {
            if (Global.ThongBao("Bạn có chắc muốn xóa mục này không?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string kq = Global.ChayStoredProcedure("SP_XOA_MUONSACH", new string[] { "STT:" + stt.ToString() });
                if (kq.Substring(0, 2).ToUpper() == "OK")
                {
                    Global.ThongBao(kq.Substring(3, kq.Length - 3));
                }
                else
                {
                    Global.BaoLoi(kq.Substring(3, kq.Length - 3));
                }
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int i = int.Parse(gridView1.GetRowCellValue(0, gridView1.Columns[0]).ToString());
                xoa(i);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView1.SelectedRowsCount > 0)
                {
                    int i = int.Parse(gridView1.GetRowCellValue(0, gridView1.Columns[0]).ToString());
                    xoa(i);
                }
            }
        }

        public string get_manm(string ten)
        {
            string s = Global.TruyVan("SELECT manguoimuon FROM nguoimuon WHERE ten=N'" + ten + "'");
            return s;
        }

        public string get_masach(string ten)
        {
            string s = Global.TruyVan("SELECT masach FROM sach WHERE tensach=N'" + ten + "'");
            return s;
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((new frmAddMuonSach()).ShowDialog() == DialogResult.OK)
            {
                string[] tmp = Global.result_MuonSach.Split('#');
                string manm = get_manm(tmp[0]);
                string masach = get_masach(tmp[1]);
                string soluong = tmp[2];
                string ngaymuon = tmp[3];
                string hentra = tmp[4];
                string kq = Global.ChayStoredProcedure("SP_MUONSACH", new string[] { "manguoimuon:"+manm, "masach:"+masach, "soluong:"+soluong, "ngaymuon:"+ngaymuon, "hentra:"+hentra });
                if (kq.Substring(0, 2).ToUpper() == "OK")
                {
                    Global.ThongBao(kq.Substring(3, kq.Length - 3));
                    cap_nhat();
                }
                else Global.BaoLoi(kq.Substring(3, kq.Length - 3));
            }
        }

        public void lay_thong_tin_nm(string ma)
        {
            DataTable dt = Global.LayDuLieu("SELECT * FROM nguoimuon WHERE manguoimuon='" + ma + "'");
            if (dt.Rows.Count > 0)
            {
                lMaNM.Text = dt.Rows[0].ItemArray[1].ToString();
                lTenNM.Text = dt.Rows[0].ItemArray[2].ToString();
                if (int.Parse(dt.Rows[0].ItemArray[3].ToString()) == 0)
                {
                    pictureBox1.Image = Properties.Resources.Office_Girl;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.Preppy;
                }
                lNgSinh.Text = dt.Rows[0].ItemArray[4].ToString();
                lSoDT.Text = dt.Rows[0].ItemArray[5].ToString();
            }
        }

        public void lay_thong_tin_sach(string ma, string soluong)
        {
            DataTable dt = Global.LayDuLieu("SELECT * FROM sach WHERE masach='" + ma + "'");
            if (dt.Rows.Count > 0)
            {
                lMaSach.Text = dt.Rows[0].ItemArray[1].ToString();
                lTenSach.Text = dt.Rows[0].ItemArray[2].ToString();
                lTheLoai.Text = Global.TruyVan("SELECT tenloaisach FROM loaisach WHERE maloaisach='" +
                                        dt.Rows[0].ItemArray[3].ToString() + "'");
                lTacGia.Text = Global.TruyVan("SELECT tentacgia FROM tacgia WHERE matacgia='" +
                                        dt.Rows[0].ItemArray[6].ToString() + "'");
                lNXB.Text = Global.TruyVan("SELECT tennxb FROM nxb WHERE manxb='" +
                                        dt.Rows[0].ItemArray[7].ToString() + "'");
                lSoTrang.Text = dt.Rows[0].ItemArray[5].ToString();
                lSoLuongM.Text = soluong;
                int con = int.Parse(dt.Rows[0].ItemArray[4].ToString()) - int.Parse(soluong);
                lSoLuongCon.Text = con.ToString();
            }
        }

        public void tra_sach(int i)
        {
            string s = Global.ChayStoredProcedure("SP_TRASACH", new string [] {"stt:"+i, "ngaytra:"+DateTime.Now.ToShortDateString()});
            if (s.Substring(0, 2).ToUpper() == "OK")
            {
                Global.ThongBao(s.Substring(3, s.Length - 3));
                cap_nhat();
            }
            else
            {
                Global.BaoLoi(s.Substring(3, s.Length - 3));
            }
        }

        public void lay_du_lieu(int i)
        {
            DataTable dt = Global.LayDuLieu("SELECT * FROM muonsach WHERE stt=" + i.ToString());
            if (dt.Rows.Count > 0)
            {
                string manm = dt.Rows[0].ItemArray[1].ToString();
                lay_thong_tin_nm(manm);
                string masach = dt.Rows[0].ItemArray[2].ToString();
                string soluong = dt.Rows[0].ItemArray[3].ToString();
                lay_thong_tin_sach(masach, soluong);
                DateTime ngaymuon = (DateTime)dt.Rows[0].ItemArray[4];
                lNgayMuon.Text = ngaymuon.ToShortDateString();
                DateTime hentra = (DateTime)dt.Rows[0].ItemArray[5];
                lHenTra.Text = hentra.ToShortDateString();
                try
                {
                    DateTime ngaytra = (DateTime)dt.Rows[0].ItemArray[6];
                    lNgayTra.ForeColor = Color.Black;
                    lNgayTra.Text = ngaytra.ToShortDateString();
                }
                catch
                {
                    lNgayTra.ForeColor = Color.Red;
                    lNgayTra.Text = "CHƯA TRẢ";
                    if (hentra <= DateTime.Now)
                    {
                        lNgayTra.Text = "QUÁ HẠN";
                    }
                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                lay_du_lieu(int.Parse(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns[0]).ToString()));
            }
            catch { }
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                if (Global.ThongBao("Thực hiện thao tác trả sách cho người này?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    tra_sach(int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[0]).ToString()));
                
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataTable dt = Global.LayDuLieu("SELECT stt as 'STT', manguoimuon as 'Mã người mượn', masach as 'Mã sách'," +
                                            "soluong as 'Số lượng', ngaymuon as 'Ngày mượn', hentra as 'Ngày hẹn trả', ngaytra as 'Ngày trả' FROM muonsach WHERE manguoimuon LIKE '%" + txtSearch.Text + "%' OR masach LIKE '%" + txtSearch.Text + "%'");
            if (dt.Rows.Count > 0)
            {
                gridControl1.DataSource = dt;
                gridView1.BestFitColumns();
            }
            else
            {
                Global.ThongBao("Không tìm thấy thông tin bạn yêu cầu!");
            }
        }
    }
}