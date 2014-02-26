namespace QuanLyThuVien.Them
{
    partial class frmAddMuonSach
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
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.so_luong = new DevExpress.XtraEditors.SpinEdit();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoi = new DevExpress.XtraEditors.SimpleButton();
            this.cb_nguoimuon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cb_sach = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ngay_muon = new DevExpress.XtraEditors.DateEdit();
            this.hen_tra = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.so_luong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_nguoimuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_sach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngay_muon.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngay_muon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hen_tra.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hen_tra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Người mượn:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sách:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(201, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "cuốn";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày mượn:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hẹn ngày trả:";
            // 
            // so_luong
            // 
            this.so_luong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.so_luong.Location = new System.Drawing.Point(98, 59);
            this.so_luong.Name = "so_luong";
            this.so_luong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.so_luong.Size = new System.Drawing.Size(97, 20);
            this.so_luong.TabIndex = 15;
            this.so_luong.EditValueChanged += new System.EventHandler(this.so_luong_EditValueChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Image = global::QuanLyThuVien.Properties.Resources.accept;
            this.btn_add.Location = new System.Drawing.Point(322, 146);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 27);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_thoi
            // 
            this.btn_thoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoi.Image = global::QuanLyThuVien.Properties.Resources.cross_octagon;
            this.btn_thoi.Location = new System.Drawing.Point(392, 146);
            this.btn_thoi.Name = "btn_thoi";
            this.btn_thoi.Size = new System.Drawing.Size(64, 27);
            this.btn_thoi.TabIndex = 2;
            this.btn_thoi.Text = "Thôi";
            // 
            // cb_nguoimuon
            // 
            this.cb_nguoimuon.Location = new System.Drawing.Point(98, 6);
            this.cb_nguoimuon.Name = "cb_nguoimuon";
            this.cb_nguoimuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_nguoimuon.Size = new System.Drawing.Size(358, 20);
            this.cb_nguoimuon.TabIndex = 16;
            // 
            // cb_sach
            // 
            this.cb_sach.Location = new System.Drawing.Point(98, 33);
            this.cb_sach.Name = "cb_sach";
            this.cb_sach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_sach.Size = new System.Drawing.Size(358, 20);
            this.cb_sach.TabIndex = 17;
            // 
            // ngay_muon
            // 
            this.ngay_muon.EditValue = null;
            this.ngay_muon.Location = new System.Drawing.Point(98, 88);
            this.ngay_muon.Name = "ngay_muon";
            this.ngay_muon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngay_muon.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngay_muon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngay_muon.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.ngay_muon.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngay_muon.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.ngay_muon.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ngay_muon.Size = new System.Drawing.Size(136, 20);
            this.ngay_muon.TabIndex = 18;
            // 
            // hen_tra
            // 
            this.hen_tra.EditValue = null;
            this.hen_tra.Location = new System.Drawing.Point(98, 115);
            this.hen_tra.Name = "hen_tra";
            this.hen_tra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hen_tra.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.hen_tra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.hen_tra.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.hen_tra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.hen_tra.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.hen_tra.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.hen_tra.Size = new System.Drawing.Size(136, 20);
            this.hen_tra.TabIndex = 19;
            // 
            // frmAddMuonSach
            // 
            this.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::QuanLyThuVien.Properties.Resources.previewbackground;
            this.ClientSize = new System.Drawing.Size(468, 185);
            this.Controls.Add(this.hen_tra);
            this.Controls.Add(this.ngay_muon);
            this.Controls.Add(this.cb_sach);
            this.Controls.Add(this.cb_nguoimuon);
            this.Controls.Add(this.so_luong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_thoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn sách";
            this.Load += new System.EventHandler(this.frmAddMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.so_luong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_nguoimuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_sach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngay_muon.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngay_muon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hen_tra.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hen_tra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_thoi;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.SpinEdit so_luong;
        private DevExpress.XtraEditors.ComboBoxEdit cb_nguoimuon;
        private DevExpress.XtraEditors.ComboBoxEdit cb_sach;
        private DevExpress.XtraEditors.DateEdit ngay_muon;
        private DevExpress.XtraEditors.DateEdit hen_tra;
    }
}