﻿namespace QuanLyThuVien
{
    partial class frmTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ádf", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("sadfa", 0);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pn_list = new DevExpress.XtraEditors.PanelControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pn_thongtin = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.lst_sach = new System.Windows.Forms.ListBox();
            this.dNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoi = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_chucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_capnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_them = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pn_list)).BeginInit();
            this.pn_list.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_thongtin)).BeginInit();
            this.pn_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user3_32.png");
            // 
            // pn_list
            // 
            this.pn_list.Controls.Add(this.listView1);
            this.pn_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_list.Location = new System.Drawing.Point(0, 0);
            this.pn_list.Name = "pn_list";
            this.pn_list.Size = new System.Drawing.Size(293, 467);
            this.pn_list.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(289, 463);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pn_list);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pn_thongtin);
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainer1.Size = new System.Drawing.Size(869, 467);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // pn_thongtin
            // 
            this.pn_thongtin.Controls.Add(this.label3);
            this.pn_thongtin.Controls.Add(this.lst_sach);
            this.pn_thongtin.Controls.Add(this.btn_edit);
            this.pn_thongtin.Controls.Add(this.btn_thoi);
            this.pn_thongtin.Controls.Add(this.dNgaySinh);
            this.pn_thongtin.Controls.Add(this.label4);
            this.pn_thongtin.Controls.Add(this.txtTen);
            this.pn_thongtin.Controls.Add(this.label2);
            this.pn_thongtin.Controls.Add(this.txtMa);
            this.pn_thongtin.Controls.Add(this.label1);
            this.pn_thongtin.Location = new System.Drawing.Point(28, 26);
            this.pn_thongtin.Name = "pn_thongtin";
            this.pn_thongtin.Size = new System.Drawing.Size(444, 325);
            this.pn_thongtin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sách của tác giả này:";
            // 
            // lst_sach
            // 
            this.lst_sach.FormattingEnabled = true;
            this.lst_sach.Location = new System.Drawing.Point(16, 101);
            this.lst_sach.Name = "lst_sach";
            this.lst_sach.Size = new System.Drawing.Size(415, 173);
            this.lst_sach.TabIndex = 29;
            this.lst_sach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lst_sach_MouseDown);
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.EditValue = new System.DateTime(2010, 6, 9, 0, 0, 0, 0);
            this.dNgaySinh.Location = new System.Drawing.Point(118, 60);
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dNgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dNgaySinh.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dNgaySinh.Size = new System.Drawing.Size(168, 20);
            this.dNgaySinh.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(118, 33);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTen.Properties.Appearance.Options.UseBackColor = true;
            this.txtTen.Size = new System.Drawing.Size(313, 20);
            this.txtTen.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên tác giả:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(118, 7);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMa.Properties.Appearance.Options.UseBackColor = true;
            this.txtMa.Properties.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(313, 20);
            this.txtMa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã tác giả:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemToolStripMenuItem,
            this.mnDeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 48);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Image = global::QuanLyThuVien.Properties.Resources.pencil_16;
            this.btn_edit.Location = new System.Drawing.Point(297, 286);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(64, 27);
            this.btn_edit.TabIndex = 26;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_thoi
            // 
            this.btn_thoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoi.Image = global::QuanLyThuVien.Properties.Resources.cross_octagon;
            this.btn_thoi.Location = new System.Drawing.Point(367, 286);
            this.btn_thoi.Name = "btn_thoi";
            this.btn_thoi.Size = new System.Drawing.Size(64, 27);
            this.btn_thoi.TabIndex = 25;
            this.btn_thoi.Text = "Thôi";
            this.btn_thoi.Click += new System.EventHandler(this.btn_thoi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::QuanLyThuVien.Properties.Resources.menubg;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_chucnang,
            this.txtSearch,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(869, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_chucnang
            // 
            this.mn_chucnang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_capnhat,
            this.toolStripMenuItem1,
            this.mn_them,
            this.mn_delete});
            this.mn_chucnang.Image = global::QuanLyThuVien.Properties.Resources.group;
            this.mn_chucnang.Name = "mn_chucnang";
            this.mn_chucnang.Size = new System.Drawing.Size(96, 21);
            this.mn_chucnang.Text = "Chức năng";
            // 
            // mn_capnhat
            // 
            this.mn_capnhat.Image = global::QuanLyThuVien.Properties.Resources.arrow_refresh;
            this.mn_capnhat.Name = "mn_capnhat";
            this.mn_capnhat.Size = new System.Drawing.Size(159, 22);
            this.mn_capnhat.Text = "Cập nhật";
            this.mn_capnhat.Click += new System.EventHandler(this.mn_capnhat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // mn_them
            // 
            this.mn_them.Image = global::QuanLyThuVien.Properties.Resources.user_add;
            this.mn_them.Name = "mn_them";
            this.mn_them.Size = new System.Drawing.Size(159, 22);
            this.mn_them.Text = "Thêm tác giả";
            this.mn_them.Click += new System.EventHandler(this.mn_them_Click);
            // 
            // mn_delete
            // 
            this.mn_delete.Image = global::QuanLyThuVien.Properties.Resources.user_delete;
            this.mn_delete.Name = "mn_delete";
            this.mn_delete.Size = new System.Drawing.Size(159, 22);
            this.mn_delete.Text = "Xóa tác giả";
            this.mn_delete.Click += new System.EventHandler(this.mn_delete_Click);
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.book_addresses;
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.xemToolStripMenuItem.Text = "Xem";
            // 
            // mnDeleteToolStripMenuItem
            // 
            this.mnDeleteToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.cross_octagon;
            this.mnDeleteToolStripMenuItem.Name = "mnDeleteToolStripMenuItem";
            this.mnDeleteToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.mnDeleteToolStripMenuItem.Text = "Xóa";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 21);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::QuanLyThuVien.Properties.Resources.find;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 21);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // frmTacGia
            // 
            this.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 492);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTacGia";
            this.Text = "Quản lý Tác giả";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pn_list)).EndInit();
            this.pn_list.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pn_thongtin)).EndInit();
            this.pn_thongtin.ResumeLayout(false);
            this.pn_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_chucnang;
        private System.Windows.Forms.ToolStripMenuItem mn_capnhat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mn_them;
        private System.Windows.Forms.ToolStripMenuItem mn_delete;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.PanelControl pn_list;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.PanelControl pn_thongtin;
        private DevExpress.XtraEditors.DateEdit dNgaySinh;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_thoi;
        private DevExpress.XtraEditors.LabelControl label3;
        private System.Windows.Forms.ListBox lst_sach;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}