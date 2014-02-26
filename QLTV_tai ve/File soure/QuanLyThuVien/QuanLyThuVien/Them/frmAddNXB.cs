using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Them
{
    public partial class frmAddNXB : DevExpress.XtraEditors.XtraForm
    {
        public frmAddNXB()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Ma#Ten
            Global.result_NXB = txtMa.Text + "#" + txtTen.Text;
            DialogResult = DialogResult.OK;
        }

        private void frmAddNXB_Load(object sender, EventArgs e)
        {
            string ma_nm = "";
            string kq = "";
            kq = Global.TruyVan(("SELECT MAX(stt) FROM NXB"));
            if (kq == "") kq = "0";
            int max = int.Parse(kq);
            max++;
            if (max < 10)
                ma_nm = "NB0" + max.ToString();
            else ma_nm = "NB" + max.ToString();
            txtMa.Text = ma_nm;
        }

        private void btn_thoi_Click(object sender, EventArgs e)
        {

        }
    }
}