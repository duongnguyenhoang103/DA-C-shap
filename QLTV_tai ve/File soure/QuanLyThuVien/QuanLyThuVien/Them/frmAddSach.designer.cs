namespace QuanLyThuVien.Them
{
    partial class frmAddSach
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
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoluong = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTrang = new DevExpress.XtraEditors.TextEdit();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoi = new DevExpress.XtraEditors.SimpleButton();
            this.cbLoai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTacgia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbNXB = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTacgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNXB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách:";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(105, 6);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(312, 20);
            this.txtMa.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(105, 32);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(312, 20);
            this.txtTen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại sách:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NXB:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số trang:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tác giả:";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(105, 139);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Properties.Mask.EditMask = "\\d+";
            this.txtSoluong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSoluong.Size = new System.Drawing.Size(108, 20);
            this.txtSoluong.TabIndex = 45;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(105, 165);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Properties.Mask.EditMask = "\\d+";
            this.txtSoTrang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSoTrang.Size = new System.Drawing.Size(108, 20);
            this.txtSoTrang.TabIndex = 46;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Image = global::QuanLyThuVien.Properties.Resources.accept;
            this.btn_add.Location = new System.Drawing.Point(297, 203);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(57, 27);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_thoi
            // 
            this.btn_thoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoi.Image = global::QuanLyThuVien.Properties.Resources.cross_octagon;
            this.btn_thoi.Location = new System.Drawing.Point(359, 203);
            this.btn_thoi.Name = "btn_thoi";
            this.btn_thoi.Size = new System.Drawing.Size(57, 27);
            this.btn_thoi.TabIndex = 0;
            this.btn_thoi.Text = "Thôi";
            this.btn_thoi.Click += new System.EventHandler(this.btn_thoi_Click);
            // 
            // cbLoai
            // 
            this.cbLoai.Location = new System.Drawing.Point(105, 58);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoai.Size = new System.Drawing.Size(312, 20);
            this.cbLoai.TabIndex = 47;
            // 
            // cbTacgia
            // 
            this.cbTacgia.Location = new System.Drawing.Point(105, 85);
            this.cbTacgia.Name = "cbTacgia";
            this.cbTacgia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTacgia.Size = new System.Drawing.Size(312, 20);
            this.cbTacgia.TabIndex = 48;
            // 
            // cbNXB
            // 
            this.cbNXB.Location = new System.Drawing.Point(105, 112);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNXB.Size = new System.Drawing.Size(312, 20);
            this.cbNXB.TabIndex = 49;
            // 
            // frmAddSach
            // 
            this.AcceptButton = this.btn_add;
            this.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoi;
            this.ClientSize = new System.Drawing.Size(429, 244);
            this.Controls.Add(this.cbNXB);
            this.Controls.Add(this.cbTacgia);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_thoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddSach";
            this.ShowInTaskbar = false;
            this.Text = "Thêm sách mới";
            this.Load += new System.EventHandler(this.frmAddSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTacgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNXB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_thoi;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit txtSoluong;
        private DevExpress.XtraEditors.TextEdit txtSoTrang;
        private DevExpress.XtraEditors.ComboBoxEdit cbLoai;
        private DevExpress.XtraEditors.ComboBoxEdit cbTacgia;
        private DevExpress.XtraEditors.ComboBoxEdit cbNXB;
    }
}