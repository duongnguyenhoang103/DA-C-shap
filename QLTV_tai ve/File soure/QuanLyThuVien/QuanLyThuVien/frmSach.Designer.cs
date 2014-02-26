namespace QuanLyThuVien
{
    partial class frmSach
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ádf", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("sadfa", 0);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pn_list = new DevExpress.XtraEditors.PanelControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pn_thongtin = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lst_nhap = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtThem = new DevExpress.XtraEditors.TextEdit();
            this.cbNXB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTacgia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbLoai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSoluong = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTrang = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoi = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_chucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_capnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_them = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pn_list)).BeginInit();
            this.pn_list.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_thongtin)).BeginInit();
            this.pn_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_nhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTacgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Book 1 (Custom).png");
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
            this.pn_thongtin.Controls.Add(this.labelControl2);
            this.pn_thongtin.Controls.Add(this.lst_nhap);
            this.pn_thongtin.Controls.Add(this.labelControl1);
            this.pn_thongtin.Controls.Add(this.txtThem);
            this.pn_thongtin.Controls.Add(this.simpleButton1);
            this.pn_thongtin.Controls.Add(this.cbNXB);
            this.pn_thongtin.Controls.Add(this.cbTacgia);
            this.pn_thongtin.Controls.Add(this.cbLoai);
            this.pn_thongtin.Controls.Add(this.txtSoluong);
            this.pn_thongtin.Controls.Add(this.txtSoTrang);
            this.pn_thongtin.Controls.Add(this.label1);
            this.pn_thongtin.Controls.Add(this.label6);
            this.pn_thongtin.Controls.Add(this.label5);
            this.pn_thongtin.Controls.Add(this.label4);
            this.pn_thongtin.Controls.Add(this.label3);
            this.pn_thongtin.Controls.Add(this.txtTen);
            this.pn_thongtin.Controls.Add(this.label7);
            this.pn_thongtin.Controls.Add(this.txtMa);
            this.pn_thongtin.Controls.Add(this.label8);
            this.pn_thongtin.Controls.Add(this.btn_edit);
            this.pn_thongtin.Controls.Add(this.btn_thoi);
            this.pn_thongtin.Location = new System.Drawing.Point(28, 26);
            this.pn_thongtin.Name = "pn_thongtin";
            this.pn_thongtin.Size = new System.Drawing.Size(444, 399);
            this.pn_thongtin.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 197);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 13);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "Chi tiết nhập sách:";
            // 
            // lst_nhap
            // 
            this.lst_nhap.Location = new System.Drawing.Point(20, 216);
            this.lst_nhap.Name = "lst_nhap";
            this.lst_nhap.Size = new System.Drawing.Size(412, 138);
            this.lst_nhap.TabIndex = 54;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Location = new System.Drawing.Point(164, 367);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "cuốn";
            // 
            // txtThem
            // 
            this.txtThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThem.EditValue = "0";
            this.txtThem.Location = new System.Drawing.Point(128, 364);
            this.txtThem.Name = "txtThem";
            this.txtThem.Properties.Mask.EditMask = "d";
            this.txtThem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtThem.Size = new System.Drawing.Size(29, 20);
            this.txtThem.TabIndex = 52;
            // 
            // cbNXB
            // 
            this.cbNXB.Location = new System.Drawing.Point(113, 118);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNXB.Size = new System.Drawing.Size(313, 20);
            this.cbNXB.TabIndex = 50;
            // 
            // cbTacgia
            // 
            this.cbTacgia.Location = new System.Drawing.Point(113, 91);
            this.cbTacgia.Name = "cbTacgia";
            this.cbTacgia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTacgia.Size = new System.Drawing.Size(313, 20);
            this.cbTacgia.TabIndex = 49;
            // 
            // cbLoai
            // 
            this.cbLoai.Location = new System.Drawing.Point(113, 64);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoai.Size = new System.Drawing.Size(313, 20);
            this.cbLoai.TabIndex = 48;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(113, 145);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(120, 20);
            this.txtSoluong.TabIndex = 42;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(113, 171);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(120, 20);
            this.txtSoTrang.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tác giả:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Số trang:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "NXB:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Loại sách:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(113, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(313, 20);
            this.txtTen.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tên sách:";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(113, 12);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(313, 20);
            this.txtMa.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mã sách:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Image = global::QuanLyThuVien.Properties.Resources.plus_16;
            this.simpleButton1.Location = new System.Drawing.Point(20, 360);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 27);
            this.simpleButton1.TabIndex = 51;
            this.simpleButton1.Text = "Nhập thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Image = global::QuanLyThuVien.Properties.Resources.pencil_16;
            this.btn_edit.Location = new System.Drawing.Point(297, 360);
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
            this.btn_thoi.Location = new System.Drawing.Point(367, 360);
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
            this.mn_capnhat.Size = new System.Drawing.Size(149, 22);
            this.mn_capnhat.Text = "Cập nhật";
            this.mn_capnhat.Click += new System.EventHandler(this.mn_capnhat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // mn_them
            // 
            this.mn_them.Image = global::QuanLyThuVien.Properties.Resources.user_add;
            this.mn_them.Name = "mn_them";
            this.mn_them.Size = new System.Drawing.Size(149, 22);
            this.mn_them.Text = "Thêm Sach";
            this.mn_them.Click += new System.EventHandler(this.mn_them_Click);
            // 
            // mn_delete
            // 
            this.mn_delete.Image = global::QuanLyThuVien.Properties.Resources.user_delete;
            this.mn_delete.Name = "mn_delete";
            this.mn_delete.Size = new System.Drawing.Size(149, 22);
            this.mn_delete.Text = "Xóa Sach";
            this.mn_delete.Click += new System.EventHandler(this.mn_delete_Click);
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
            // frmSach
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
            this.Name = "frmSach";
            this.Text = "Kho sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pn_list)).EndInit();
            this.pn_list.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pn_thongtin)).EndInit();
            this.pn_thongtin.ResumeLayout(false);
            this.pn_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_nhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTacgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTrang.Properties)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl pn_list;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.PanelControl pn_thongtin;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_thoi;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtSoTrang;
        private DevExpress.XtraEditors.TextEdit txtSoluong;
        private DevExpress.XtraEditors.ComboBoxEdit cbLoai;
        private DevExpress.XtraEditors.ComboBoxEdit cbTacgia;
        private DevExpress.XtraEditors.ComboBoxEdit cbNXB;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtThem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ListBoxControl lst_nhap;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}