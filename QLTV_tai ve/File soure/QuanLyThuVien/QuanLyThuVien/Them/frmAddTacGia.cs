using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Them
{
    public partial class frmAddTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmAddTacGia()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Ma#Ten#NgaySinh
            Global.result_TacGia = txtMa.Text + "#" + txtTen.Text + "#" + ((DateTime)dNgaySinh.EditValue).ToShortDateString();
            DialogResult = DialogResult.OK;
        }

        private void frmAddTacGia_Load(object sender, EventArgs e)
        {
            string ma_nm = "";
            string kq = "";
            kq = Global.TruyVan(("SELECT MAX(stt) FROM TacGia"));
            if (kq == "") kq = "0";
            int max = int.Parse(kq);
            max++;
            if (max < 10)
                ma_nm = "TG0" + max.ToString();
            else ma_nm = "TG" + max.ToString();
            txtMa.Text = ma_nm;
        }

        private void btn_thoi_Click(object sender, EventArgs e)
        {

        }
    }
}