namespace QuanLyThuVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows DevExpress.XtraEditors.XtraForm Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbl_stt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLoginout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmThẻMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhSáchThẻMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_stt});
            this.statusStrip.Location = new System.Drawing.Point(0, 541);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(856, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lbl_stt
            // 
            this.lbl_stt.Name = "lbl_stt";
            this.lbl_stt.Size = new System.Drawing.Size(156, 17);
            this.lbl_stt.Text = "Chương trình Quản lý thư viện ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImage = global::QuanLyThuVien.Properties.Resources.untitled;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLoginout,
            this.toolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.ngườiDùngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ngườiDùngToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.world;
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.ngườiDùngToolStripMenuItem.Text = "Chương trình";
            // 
            // mnLoginout
            // 
            this.mnLoginout.Image = global::QuanLyThuVien.Properties.Resources.stop;
            this.mnLoginout.Name = "mnLoginout";
            this.mnLoginout.Size = new System.Drawing.Size(152, 22);
            this.mnLoginout.Text = "Đăng xuất";
            this.mnLoginout.Click += new System.EventHandler(this.mnLoginout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.cross_octagon;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.quảnLýNgườiMượnToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.chứcNăngToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.application_edit;
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chứcNăngToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiSáchToolStripMenuItem,
            this.tácGiảToolStripMenuItem,
            this.khoSáchToolStripMenuItem,
            this.toolStripMenuItem4});
            this.quảnLýToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.book_addresses;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.quảnLýToolStripMenuItem.Text = "Quản lý sách";
            // 
            // loạiSáchToolStripMenuItem
            // 
            this.loạiSáchToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.label_16;
            this.loạiSáchToolStripMenuItem.Name = "loạiSáchToolStripMenuItem";
            this.loạiSáchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loạiSáchToolStripMenuItem.Text = "Loại sách";
            this.loạiSáchToolStripMenuItem.Click += new System.EventHandler(this.loạiSáchToolStripMenuItem_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.user_16;
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // khoSáchToolStripMenuItem
            // 
            this.khoSáchToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.book_open;
            this.khoSáchToolStripMenuItem.Name = "khoSáchToolStripMenuItem";
            this.khoSáchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.khoSáchToolStripMenuItem.Text = "Kho sách";
            this.khoSáchToolStripMenuItem.Click += new System.EventHandler(this.khoSáchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::QuanLyThuVien.Properties.Resources.address_16;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem4.Text = "Nhà xuất bản";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // quảnLýNgườiMượnToolStripMenuItem
            // 
            this.quảnLýNgườiMượnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmThẻMượnToolStripMenuItem,
            this.quảnLýDanhSáchThẻMượnToolStripMenuItem});
            this.quảnLýNgườiMượnToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.group;
            this.quảnLýNgườiMượnToolStripMenuItem.Name = "quảnLýNgườiMượnToolStripMenuItem";
            this.quảnLýNgườiMượnToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.quảnLýNgườiMượnToolStripMenuItem.Text = "Quản lý người mượn";
            // 
            // làmThẻMượnToolStripMenuItem
            // 
            this.làmThẻMượnToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.user_add;
            this.làmThẻMượnToolStripMenuItem.Name = "làmThẻMượnToolStripMenuItem";
            this.làmThẻMượnToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.làmThẻMượnToolStripMenuItem.Text = "Làm thẻ mượn";
            this.làmThẻMượnToolStripMenuItem.Click += new System.EventHandler(this.làmThẻMượnToolStripMenuItem_Click);
            // 
            // quảnLýDanhSáchThẻMượnToolStripMenuItem
            // 
            this.quảnLýDanhSáchThẻMượnToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.vcard;
            this.quảnLýDanhSáchThẻMượnToolStripMenuItem.Name = "quảnLýDanhSáchThẻMượnToolStripMenuItem";
            this.quảnLýDanhSáchThẻMượnToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.quảnLýDanhSáchThẻMượnToolStripMenuItem.Text = "Quản lý thẻ mượn";
            this.quảnLýDanhSáchThẻMượnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDanhSáchThẻMượnToolStripMenuItem_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.book_open;
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý mượn trả";
            this.quảnLýMượnTrảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnTrảToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseImage = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 563);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_stt;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnLoginout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmThẻMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhSáchThẻMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}



