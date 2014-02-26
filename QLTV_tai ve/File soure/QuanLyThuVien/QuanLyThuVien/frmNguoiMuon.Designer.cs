namespace QuanLyThuVien
{
    partial class frmNguoiMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiMuon));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ádf", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("sadfa", 1);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pn_list = new DevExpress.XtraEditors.PanelControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pn_thongtin = new DevExpress.XtraEditors.PanelControl();
            this.txtSoDt = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.dNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.rNu = new System.Windows.Forms.RadioButton();
            this.rNam = new System.Windows.Forms.RadioButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoi = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_chucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_capnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_them = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mngopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mngopgtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mngopdfaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pn_list)).BeginInit();
            this.pn_list.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_thongtin)).BeginInit();
            this.pn_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Office Girl.png");
            this.imageList1.Images.SetKeyName(1, "Preppy.png");
            // 
            // pn_list
            // 
            this.pn_list.Controls.Add(this.listView1);
            this.pn_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_list.Location = new System.Drawing.Point(0, 0);
            this.pn_list.Name = "pn_list";
            this.pn_list.Size = new System.Drawing.Size(289, 467);
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
            this.listView1.Size = new System.Drawing.Size(285, 463);
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
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 5;
            // 
            // pn_thongtin
            // 
            this.pn_thongtin.Controls.Add(this.btn_edit);
            this.pn_thongtin.Controls.Add(this.btn_thoi);
            this.pn_thongtin.Controls.Add(this.txtSoDt);
            this.pn_thongtin.Controls.Add(this.label5);
            this.pn_thongtin.Controls.Add(this.dNgaySinh);
            this.pn_thongtin.Controls.Add(this.label4);
            this.pn_thongtin.Controls.Add(this.rNu);
            this.pn_thongtin.Controls.Add(this.rNam);
            this.pn_thongtin.Controls.Add(this.label3);
            this.pn_thongtin.Controls.Add(this.txtTen);
            this.pn_thongtin.Controls.Add(this.label2);
            this.pn_thongtin.Controls.Add(this.txtMa);
            this.pn_thongtin.Controls.Add(this.label1);
            this.pn_thongtin.Location = new System.Drawing.Point(28, 26);
            this.pn_thongtin.Name = "pn_thongtin";
            this.pn_thongtin.Size = new System.Drawing.Size(444, 180);
            this.pn_thongtin.TabIndex = 0;
            // 
            // txtSoDt
            // 
            this.txtSoDt.Location = new System.Drawing.Point(118, 108);
            this.txtSoDt.Name = "txtSoDt";
            this.txtSoDt.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSoDt.Properties.Appearance.Options.UseBackColor = true;
            this.txtSoDt.Size = new System.Drawing.Size(313, 20);
            this.txtSoDt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số điện thoại:";
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.EditValue = new System.DateTime(2010, 6, 9, 0, 0, 0, 0);
            this.dNgaySinh.Location = new System.Drawing.Point(118, 83);
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
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày sinh:";
            // 
            // rNu
            // 
            this.rNu.AutoSize = true;
            this.rNu.Location = new System.Drawing.Point(171, 60);
            this.rNu.Name = "rNu";
            this.rNu.Size = new System.Drawing.Size(40, 17);
            this.rNu.TabIndex = 20;
            this.rNu.Text = "Nữ";
            this.rNu.UseVisualStyleBackColor = true;
            // 
            // rNam
            // 
            this.rNam.AutoSize = true;
            this.rNam.Checked = true;
            this.rNam.Location = new System.Drawing.Point(118, 60);
            this.rNam.Name = "rNam";
            this.rNam.Size = new System.Drawing.Size(51, 17);
            this.rNam.TabIndex = 19;
            this.rNam.TabStop = true;
            this.rNam.Text = "Nam";
            this.rNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giới tính:";
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
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên người mượn:";
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
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã người mượn:";
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Image = global::QuanLyThuVien.Properties.Resources.pencil_16;
            this.btn_edit.Location = new System.Drawing.Point(297, 141);
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
            this.btn_thoi.Location = new System.Drawing.Point(367, 141);
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
            this.mngopToolStripMenuItem,
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
            this.mn_capnhat.Size = new System.Drawing.Size(188, 22);
            this.mn_capnhat.Text = "Cập nhật";
            this.mn_capnhat.Click += new System.EventHandler(this.mn_capnhat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // mn_them
            // 
            this.mn_them.Image = global::QuanLyThuVien.Properties.Resources.user_add;
            this.mn_them.Name = "mn_them";
            this.mn_them.Size = new System.Drawing.Size(188, 22);
            this.mn_them.Text = "Thêm người mượn";
            this.mn_them.Click += new System.EventHandler(this.mn_them_Click);
            // 
            // mn_delete
            // 
            this.mn_delete.Image = global::QuanLyThuVien.Properties.Resources.user_delete;
            this.mn_delete.Name = "mn_delete";
            this.mn_delete.Size = new System.Drawing.Size(188, 22);
            this.mn_delete.Text = "Xóa người mượn";
            this.mn_delete.Click += new System.EventHandler(this.mn_delete_Click);
            // 
            // mngopToolStripMenuItem
            // 
            this.mngopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mngopgtToolStripMenuItem,
            this.mngopdfaultToolStripMenuItem});
            this.mngopToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.chart_organisation;
            this.mngopToolStripMenuItem.Name = "mngopToolStripMenuItem";
            this.mngopToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.mngopToolStripMenuItem.Text = "Phân nhóm";
            // 
            // mngopgtToolStripMenuItem
            // 
            this.mngopgtToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.group;
            this.mngopgtToolStripMenuItem.Name = "mngopgtToolStripMenuItem";
            this.mngopgtToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.mngopgtToolStripMenuItem.Text = "Phân nhóm theo giới tính";
            this.mngopgtToolStripMenuItem.Click += new System.EventHandler(this.mngopgtToolStripMenuItem_Click);
            // 
            // mngopdfaultToolStripMenuItem
            // 
            this.mngopdfaultToolStripMenuItem.Image = global::QuanLyThuVien.Properties.Resources.cross_octagon;
            this.mngopdfaultToolStripMenuItem.Name = "mngopdfaultToolStripMenuItem";
            this.mngopdfaultToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.mngopdfaultToolStripMenuItem.Text = "Không phân nhóm";
            this.mngopdfaultToolStripMenuItem.Click += new System.EventHandler(this.mngopdfaultToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::QuanLyThuVien.Properties.Resources.find;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 21);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 21);
            // 
            // frmNguoiMuon
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
            this.Name = "frmNguoiMuon";
            this.Text = "Quản lý người mượn";
            this.Load += new System.EventHandler(this.frmNguoiMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pn_list)).EndInit();
            this.pn_list.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pn_thongtin)).EndInit();
            this.pn_thongtin.ResumeLayout(false);
            this.pn_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem mngopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mngopgtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mngopdfaultToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl pn_list;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.PanelControl pn_thongtin;
        private DevExpress.XtraEditors.TextEdit txtSoDt;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.DateEdit dNgaySinh;
        private DevExpress.XtraEditors.LabelControl label4;
        private System.Windows.Forms.RadioButton rNu;
        private System.Windows.Forms.RadioButton rNam;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_thoi;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}