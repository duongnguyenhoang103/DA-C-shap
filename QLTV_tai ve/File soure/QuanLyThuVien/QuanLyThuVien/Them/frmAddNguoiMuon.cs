using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Them
{
    public partial class frmAddNguoiMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmAddNguoiMuon()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string gt = "1";
            if (rNam.Checked) gt="1";
            else gt="0";
            // Ma#Ten#GioiTinh#NgaySinh#SoDT
            Global.result_NguoiMuon = txtMa.Text + "#" + txtTen.Text + "#" + gt + "#" + ((DateTime)dNgaySinh.EditValue).ToShortDateString() +
                                        "#" + txtSoDt.Text;
            DialogResult = DialogResult.OK;
        }

        private void frmAddNguoiMuon_Load(object sender, EventArgs e)
        {
            string ma_nm = "";
            string kq = "";
            kq = Global.TruyVan(("SELECT MAX(stt) FROM nguoimuon"));
            if (kq == "") kq = "0";
            int max = int.Parse(kq);
            max++;
            if (max < 10)
                ma_nm = "NM0" + max.ToString();
            else ma_nm = "NM" + max.ToString();
            txtMa.Text = ma_nm;
        }

        private void btn_thoi_Click(object sender, EventArgs e)
        {

        }
    }
}