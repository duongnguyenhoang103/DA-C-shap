using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public class Global
    {
        static string app_name = "Quản lý thư viện";

        static SqlConnection db_connect = new SqlConnection("Server=localhost;Database=QLTV;Trusted_Connection=True;");
        static frmMain mainForm = new frmMain();
        static frmLogin loginForm = new frmLogin();

        public static frmLoaiSach frmLoaiSach;
        public static frmNguoiMuon frmNguoiMuon;
        public static frmTacGia frmTacGia;
        public static frmNXB frmNxb;
        public static frmMuonSach frmMuonSach;
        public static frmSach frmSach;

        public static string result_NguoiMuon = "";
        public static string result_NguoiDung = "";
        public static string result_LoaiSach = "";
        public static string result_Sach = "";
        public static string result_TacGia = "";
        public static string result_NXB = "";
        public static string result_MuonSach = "";

        public static string AppName
        {
            get { return app_name; }
        }

        public static frmLogin LoginForm
        {
            get { if ((loginForm == null) || (loginForm.IsDisposed)) loginForm = new frmLogin(); return loginForm; }
        }

        public static frmMain MainForm
        {
            get { if ((mainForm == null) || (mainForm.IsDisposed)) mainForm = new frmMain(); return mainForm; }
        }

        public static SqlConnection DoiTuongKetNoi
        {
            get { return db_connect; }
        }

        public static void KetNoi()
        {
            db_connect.Open();
        }

        public static void HuyKetNoi()
        {
            db_connect.Close();
        }

        public static string MaHoa(string matkhau)
        {
            Byte[] byte_goc;
            Byte[] byte_mahoa;
            MD5 md5;

            md5 = new MD5CryptoServiceProvider();
            byte_goc = ASCIIEncoding.Default.GetBytes(matkhau);
            byte_mahoa = md5.ComputeHash(byte_goc);
            return BitConverter.ToString(byte_mahoa).Replace("-","").ToLower();
        }

        public static DataTable LayDuLieu(string truyvan)
        {
            DataTable bang_tam = new DataTable();
            SqlCommand lenhtruyvan = new SqlCommand(truyvan, DoiTuongKetNoi);
            SqlDataAdapter da = new SqlDataAdapter(lenhtruyvan);
            da.Fill(bang_tam);
            return bang_tam;
        }

        public static string LayDuLieu(DataTable dulieu, int hang, int cot)
        {
            if (dulieu.Rows.Count > 0)
                return dulieu.Rows[hang].ItemArray[cot].ToString();
            else return "";
        }

        public static string TruyVan(string cmd)
        {
            return LayDuLieu(LayDuLieu(cmd), 0, 0);
        }

        /// <summary>
        /// Hàm ChayStoredProcedure, dùng để thực thi 1 Stored Procedure trong SQL Server
        /// </summary>
        /// <param name="sp_ten">Tên Stored Procedure</param>
        /// <param name="sp_thamso">Danh sách các tham số, có dạng ("tên tham số:giá trị")</param>
        /// <returns>Giá trị trả về của Stored Procedure</returns>
        public static string ChayStoredProcedure(string sp_ten, string [] sp_thamso) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DoiTuongKetNoi;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp_ten ;
            SqlParameter op = new SqlParameter("@KETQUA", SqlDbType.NVarChar, 255);
            op.Direction = ParameterDirection.Output;
            foreach (string stso in sp_thamso)
            {
                string ten = stso.Split(':')[0];
                ten = ten.Insert(0,"@");
                string gtri = stso.Split(':')[1];
                cmd.Parameters.Add(new SqlParameter(ten, gtri));
            }
            cmd.Parameters.Add(op);
            cmd.ExecuteNonQuery();
            return op.Value.ToString();
        }

        public static void BaoLoi(string err)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(err, AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ThongBao(string tb)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(tb, AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ThongBao(string hoi, MessageBoxButtons btn)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(hoi, AppName, btn, MessageBoxIcon.Question);
        }
    }
}
