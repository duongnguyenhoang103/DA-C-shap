﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Money Twins");
            
            Global.KetNoi();
            Global.LoginForm.Show();
            Application.Run();
            Global.HuyKetNoi();
            Application.ExitThread();
        }
    }
}
