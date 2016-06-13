namespace PresentationLayer.Dialogs
{
    partial class FormDangNhap
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
            this.labelControl_DangNhap = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_MatKhau = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_TenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_OK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl_DangNhap
            // 
            this.labelControl_DangNhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl_DangNhap.Location = new System.Drawing.Point(12, 12);
            this.labelControl_DangNhap.Name = "labelControl_DangNhap";
            this.labelControl_DangNhap.Size = new System.Drawing.Size(129, 32);
            this.labelControl_DangNhap.TabIndex = 32;
            this.labelControl_DangNhap.Text = "Đăng Nhập";
            // 
            // textEdit_MatKhau
            // 
            this.textEdit_MatKhau.Location = new System.Drawing.Point(122, 101);
            this.textEdit_MatKhau.Name = "textEdit_MatKhau";
            this.textEdit_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textEdit_MatKhau.Properties.Appearance.Options.UseFont = true;
            this.textEdit_MatKhau.Properties.MaxLength = 500;
            this.textEdit_MatKhau.Properties.PasswordChar = '*';
            this.textEdit_MatKhau.Properties.UseSystemPasswordChar = true;
            this.textEdit_MatKhau.Size = new System.Drawing.Size(250, 26);
            this.textEdit_MatKhau.TabIndex = 29;
            // 
            // labelControl_MatKhau
            // 
            this.labelControl_MatKhau.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_MatKhau.Location = new System.Drawing.Point(12, 104);
            this.labelControl_MatKhau.Name = "labelControl_MatKhau";
            this.labelControl_MatKhau.Size = new System.Drawing.Size(63, 20);
            this.labelControl_MatKhau.TabIndex = 26;
            this.labelControl_MatKhau.Text = "Mật Khẩu";
            // 
            // textEdit_TenDangNhap
            // 
            this.textEdit_TenDangNhap.Location = new System.Drawing.Point(122, 69);
            this.textEdit_TenDangNhap.Name = "textEdit_TenDangNhap";
            this.textEdit_TenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textEdit_TenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.textEdit_TenDangNhap.Properties.MaxLength = 500;
            this.textEdit_TenDangNhap.Size = new System.Drawing.Size(250, 26);
            this.textEdit_TenDangNhap.TabIndex = 28;
            // 
            // labelControl_TenDangNhap
            // 
            this.labelControl_TenDangNhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_TenDangNhap.Location = new System.Drawing.Point(12, 72);
            this.labelControl_TenDangNhap.Name = "labelControl_TenDangNhap";
            this.labelControl_TenDangNhap.Size = new System.Drawing.Size(103, 20);
            this.labelControl_TenDangNhap.TabIndex = 27;
            this.labelControl_TenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_Cancel.Image = global::PresentationLayer.Properties.Resources.Cancel;
            this.simpleButton_Cancel.Location = new System.Drawing.Point(243, 169);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_Cancel.TabIndex = 34;
            this.simpleButton_Cancel.Text = "Cancel";
            this.simpleButton_Cancel.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // simpleButton_OK
            // 
            this.simpleButton_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_OK.Image = global::PresentationLayer.Properties.Resources.Apply;
            this.simpleButton_OK.Location = new System.Drawing.Point(63, 169);
            this.simpleButton_OK.Name = "simpleButton_OK";
            this.simpleButton_OK.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_OK.TabIndex = 33;
            this.simpleButton_OK.Text = "OK";
            this.simpleButton_OK.Click += new System.EventHandler(this.simpleButton_OK_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 260);
            this.Controls.Add(this.textEdit_TenDangNhap);
            this.Controls.Add(this.textEdit_MatKhau);
            this.Controls.Add(this.labelControl_MatKhau);
            this.Controls.Add(this.labelControl_DangNhap);
            this.Controls.Add(this.labelControl_TenDangNhap);
            this.Controls.Add(this.simpleButton_OK);
            this.Controls.Add(this.simpleButton_Cancel);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OK;
        private DevExpress.XtraEditors.LabelControl labelControl_DangNhap;
        private DevExpress.XtraEditors.TextEdit textEdit_MatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl_MatKhau;
        private DevExpress.XtraEditors.TextEdit textEdit_TenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl_TenDangNhap;
    }
}