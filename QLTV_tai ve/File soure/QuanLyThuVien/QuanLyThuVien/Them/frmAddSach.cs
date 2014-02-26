using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Them
{
    public partial class frmAddSach : DevExpress.XtraEditors.XtraForm
    {
        public frmAddSach()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Ma#Ten
            if ((cbLoai.Text != "") && (cbNXB.Text != "") && (cbTacgia.Text != ""))
            {
                Global.result_Sach = txtMa.Text + "#" + txtTen.Text + "#" + cbLoai.Text + "#" + cbNXB.Text + "#" + txtSoluong.Text + "#" + txtSoTrang.Text + "#" + cbTacgia.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                Global.BaoLoi("Bạn phải nhập đầy đủ thông tin!");
                DialogResult = DialogResult.Cancel;
            }
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

        private void frmAddSach_Load(object sender, EventArgs e)
        {
            string ma_nm = "";
            string kq = "";
            kq = Global.TruyVan(("SELECT MAX(stt) FROM Sach"));
            if (kq == "") kq = "0";
            int max = int.Parse(kq);
            max++;
            if (max < 10)
                ma_nm = "SH0" + max.ToString();
            else ma_nm = "SH" + max.ToString();
            txtMa.Text = ma_nm;
            get_loaisach();
            get_nxb();
            get_tacgia();
        }

        private void btn_thoi_Click(object sender, EventArgs e)
        {

        }
    }
}