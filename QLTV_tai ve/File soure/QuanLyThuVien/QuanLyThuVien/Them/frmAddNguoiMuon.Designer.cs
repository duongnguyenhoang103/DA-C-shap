namespace QuanLyThuVien.Them
{
    partial class frmAddNguoiMuon
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
            this.rNam = new System.Windows.Forms.RadioButton();
            this.rNu = new System.Windows.Forms.RadioButton();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.dNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtSoDt = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã người mượn:";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(105, 6);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(313, 20);
            this.txtMa.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(105, 32);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(313, 20);
            this.txtTen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên người mượn:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giới tính:";
            // 
            // rNam
            // 
            this.rNam.AutoSize = true;
            this.rNam.Checked = true;
            this.rNam.Location = new System.Drawing.Point(105, 59);
            this.rNam.Name = "rNam";
            this.rNam.Size = new System.Drawing.Size(46, 17);
            this.rNam.TabIndex = 7;
            this.rNam.TabStop = true;
            this.rNam.Text = "Nam";
            this.rNam.UseVisualStyleBackColor = true;
            // 
            // rNu
            // 
            this.rNu.AutoSize = true;
            this.rNu.Location = new System.Drawing.Point(158, 59);
            this.rNu.Name = "rNu";
            this.rNu.Size = new System.Drawing.Size(39, 17);
            this.rNu.TabIndex = 8;
            this.rNu.Text = "Nữ";
            this.rNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh:";
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.EditValue = new System.DateTime(2010, 6, 9, 0, 0, 0, 0);
            this.dNgaySinh.Location = new System.Drawing.Point(105, 81);
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dNgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dNgaySinh.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dNgaySinh.Size = new System.Drawing.Size(167, 20);
            this.dNgaySinh.TabIndex = 11;
            // 
            // txtSoDt
            // 
            this.txtSoDt.Location = new System.Drawing.Point(105, 107);
            this.txtSoDt.Name = "txtSoDt";
            this.txtSoDt.Size = new System.Drawing.Size(313, 20);
            this.txtSoDt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại:";
            // 
            // btn_add
            // 
            this.btn_add.Image = global::QuanLyThuVien.Properties.Resources.accept;
            this.btn_add.Location = new System.Drawing.Point(284, 133);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 27);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_thoi
            // 
            this.btn_thoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoi.Image = global::QuanLyThuVien.Properties.Resources.cross_octagon;
            this.btn_thoi.Location = new System.Drawing.Point(354, 133);
            this.btn_thoi.Name = "btn_thoi";
            this.btn_thoi.Size = new System.Drawing.Size(64, 27);
            this.btn_thoi.TabIndex = 0;
            this.btn_thoi.Text = "Thôi";
            this.btn_thoi.Click += new System.EventHandler(this.btn_thoi_Click);
            // 
            // frmAddNguoiMuon
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoi;
            this.ClientSize = new System.Drawing.Size(429, 174);
            this.Controls.Add(this.txtSoDt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rNu);
            this.Controls.Add(this.rNam);
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
            this.Name = "frmAddNguoiMuon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm thẻ mượn";
            this.Load += new System.EventHandler(this.frmAddNguoiMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDt.Properties)).EndInit();
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
        private System.Windows.Forms.RadioButton rNam;
        private System.Windows.Forms.RadioButton rNu;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.DateEdit dNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtSoDt;
        private DevExpress.XtraEditors.LabelControl label5;
    }
}