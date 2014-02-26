using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Them
{
    public partial class frmAddMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmAddMuonSach()
        {
            InitializeComponent();
        }

        public void get_sach()
        {
            cb_sach.Properties.Items.Clear();
            DataTable dt = Global.LayDuLieu("SELECT tensach FROM sach");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_sach.Properties.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                }
            }
            cb_sach.Properties.Sorted = true;
        }

        public void get_nguoimuon()
        {
            cb_nguoimuon.Properties.Items.Clear();
            DataTable dt = Global.LayDuLieu("SELECT ten FROM nguoimuon");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cb_nguoimuon.Properties.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                }
            }
            cb_nguoimuon.Properties.Sorted = true;
        }

        private void frmAddMuonSach_Load(object sender, EventArgs e)
        {
            get_nguoimuon();
            get_sach();
            ngay_muon.DateTime = DateTime.Now;
            hen_tra.DateTime = DateTime.Now;
        }

        private void so_luong_EditValueChanged(object sender, EventArgs e)
        {
            if (so_luong.Value <= 0)
            {
                Global.BaoLoi("Số lượng phải lớn hơn 0!");
                so_luong.Value = 1;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((cb_nguoimuon.Text.Trim().Length == 0) || (cb_sach.Text.Trim().Length == 0))
            {
                Global.BaoLoi("Bạn phải điền đày đủ thông tin!");
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                Global.result_MuonSach = cb_nguoimuon.Text + "#" + cb_sach.Text + "#" + so_luong.Value.ToString() + "#" +
                    ngay_muon.DateTime.ToShortDateString() + "#" + hen_tra.DateTime.ToShortDateString();
                DialogResult = DialogResult.OK;
            }
        }
    }
}