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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = Global.ChayStoredProcedure("SP_DANG_NHAP", new string[]{"TENTRUYCAP:"+txt_usr.Text,
                                                        "MATKHAU:" + Global.MaHoa(txt_pwr.Text)});
            if (s.Substring(0, 2).ToUpper() == "NO")
            {
                Global.BaoLoi(s.Substring(3));
            }
            else
            {
                Global.ThongBao(s.Substring(3));
                Global.MainForm.Show();
                this.Close();
            }
        }

        private void txt_usr_Enter(object sender, EventArgs e)
        {
            txt_usr.SelectAll();
        }

        private void txt_pwr_Enter(object sender, EventArgs e)
        {
            txt_pwr.SelectAll();
        }
    }
}
