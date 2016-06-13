namespace PresentationLayer.Dialogs
{
    partial class FormEditThongTinTaiKhoan
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
            this.labelControl_ThongTinTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_TenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_MatKhau = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_QuyenHan = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit_QuyenHan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_OK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_QuyenHan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl_ThongTinTaiKhoan
            // 
            this.labelControl_ThongTinTaiKhoan.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl_ThongTinTaiKhoan.Location = new System.Drawing.Point(13, 7);
            this.labelControl_ThongTinTaiKhoan.Name = "labelControl_ThongTinTaiKhoan";
            this.labelControl_ThongTinTaiKhoan.Size = new System.Drawing.Size(235, 32);
            this.labelControl_ThongTinTaiKhoan.TabIndex = 17;
            this.labelControl_ThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // labelControl_TenDangNhap
            // 
            this.labelControl_TenDangNhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_TenDangNhap.Location = new System.Drawing.Point(13, 67);
            this.labelControl_TenDangNhap.Name = "labelControl_TenDangNhap";
            this.labelControl_TenDangNhap.Size = new System.Drawing.Size(103, 20);
            this.labelControl_TenDangNhap.TabIndex = 13;
            this.labelControl_TenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // textEdit_TenDangNhap
            // 
            this.textEdit_TenDangNhap.Location = new System.Drawing.Point(123, 64);
            this.textEdit_TenDangNhap.Name = "textEdit_TenDangNhap";
            this.textEdit_TenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textEdit_TenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.textEdit_TenDangNhap.Properties.MaxLength = 500;
            this.textEdit_TenDangNhap.Size = new System.Drawing.Size(201, 26);
            this.textEdit_TenDangNhap.TabIndex = 14;
            // 
            // labelControl_MatKhau
            // 
            this.labelControl_MatKhau.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_MatKhau.Location = new System.Drawing.Point(13, 99);
            this.labelControl_MatKhau.Name = "labelControl_MatKhau";
            this.labelControl_MatKhau.Size = new System.Drawing.Size(63, 20);
            this.labelControl_MatKhau.TabIndex = 13;
            this.labelControl_MatKhau.Text = "Mật Khẩu";
            // 
            // textEdit_MatKhau
            // 
            this.textEdit_MatKhau.Location = new System.Drawing.Point(123, 96);
            this.textEdit_MatKhau.Name = "textEdit_MatKhau";
            this.textEdit_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textEdit_MatKhau.Properties.Appearance.Options.UseFont = true;
            this.textEdit_MatKhau.Properties.MaxLength = 500;
            this.textEdit_MatKhau.Size = new System.Drawing.Size(201, 26);
            this.textEdit_MatKhau.TabIndex = 15;
            // 
            // labelControl_QuyenHan
            // 
            this.labelControl_QuyenHan.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_QuyenHan.Location = new System.Drawing.Point(13, 131);
            this.labelControl_QuyenHan.Name = "labelControl_QuyenHan";
            this.labelControl_QuyenHan.Size = new System.Drawing.Size(73, 20);
            this.labelControl_QuyenHan.TabIndex = 15;
            this.labelControl_QuyenHan.Text = "Quyền Hạn";
            // 
            // comboBoxEdit_QuyenHan
            // 
            this.comboBoxEdit_QuyenHan.Location = new System.Drawing.Point(123, 130);
            this.comboBoxEdit_QuyenHan.Name = "comboBoxEdit_QuyenHan";
            this.comboBoxEdit_QuyenHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_QuyenHan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_QuyenHan.Size = new System.Drawing.Size(138, 20);
            this.comboBoxEdit_QuyenHan.TabIndex = 16;
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_Cancel.Image = global::PresentationLayer.Properties.Resources.Cancel;
            this.simpleButton_Cancel.Location = new System.Drawing.Point(213, 191);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_Cancel.TabIndex = 18;
            this.simpleButton_Cancel.Text = "Cancel";
            this.simpleButton_Cancel.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // simpleButton_OK
            // 
            this.simpleButton_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_OK.Image = global::PresentationLayer.Properties.Resources.Apply;
            this.simpleButton_OK.Location = new System.Drawing.Point(64, 191);
            this.simpleButton_OK.Name = "simpleButton_OK";
            this.simpleButton_OK.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_OK.TabIndex = 17;
            this.simpleButton_OK.Text = "OK";
            this.simpleButton_OK.Click += new System.EventHandler(this.simpleButton_OK_Click);
            // 
            // FormEditThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 264);
            this.Controls.Add(this.comboBoxEdit_QuyenHan);
            this.Controls.Add(this.simpleButton_Cancel);
            this.Controls.Add(this.simpleButton_OK);
            this.Controls.Add(this.labelControl_ThongTinTaiKhoan);
            this.Controls.Add(this.labelControl_QuyenHan);
            this.Controls.Add(this.textEdit_MatKhau);
            this.Controls.Add(this.labelControl_MatKhau);
            this.Controls.Add(this.textEdit_TenDangNhap);
            this.Controls.Add(this.labelControl_TenDangNhap);
            this.Name = "FormEditThongTinTaiKhoan";
            this.Text = "FormEditThongTinTaiKhoan";
            this.Load += new System.EventHandler(this.FormEditThongTinTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_QuyenHan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl_ThongTinTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl_TenDangNhap;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OK;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
        private DevExpress.XtraEditors.TextEdit textEdit_TenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl_MatKhau;
        private DevExpress.XtraEditors.TextEdit textEdit_MatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl_QuyenHan;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_QuyenHan;
    }
}