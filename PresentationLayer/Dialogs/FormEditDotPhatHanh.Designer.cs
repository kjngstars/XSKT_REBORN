namespace PresentationLayer.Dialogs
{
    partial class FormEditDotPhatHanh
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
            this.labelControl_DotPhatHanh = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit_NgayLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl_NgayLap = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TenDotPhatHanh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_TenDotPhatHanh = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_OK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenDotPhatHanh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl_DotPhatHanh
            // 
            this.labelControl_DotPhatHanh.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl_DotPhatHanh.Location = new System.Drawing.Point(12, 20);
            this.labelControl_DotPhatHanh.Name = "labelControl_DotPhatHanh";
            this.labelControl_DotPhatHanh.Size = new System.Drawing.Size(167, 32);
            this.labelControl_DotPhatHanh.TabIndex = 5;
            this.labelControl_DotPhatHanh.Text = "Đợt Phát Hành";
            // 
            // dateEdit_NgayLap
            // 
            this.dateEdit_NgayLap.EditValue = null;
            this.dateEdit_NgayLap.Location = new System.Drawing.Point(122, 117);
            this.dateEdit_NgayLap.Name = "dateEdit_NgayLap";
            this.dateEdit_NgayLap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateEdit_NgayLap.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayLap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit_NgayLap.Size = new System.Drawing.Size(250, 26);
            this.dateEdit_NgayLap.TabIndex = 9;
            // 
            // labelControl_NgayLap
            // 
            this.labelControl_NgayLap.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_NgayLap.Location = new System.Drawing.Point(12, 120);
            this.labelControl_NgayLap.Name = "labelControl_NgayLap";
            this.labelControl_NgayLap.Size = new System.Drawing.Size(63, 20);
            this.labelControl_NgayLap.TabIndex = 8;
            this.labelControl_NgayLap.Text = "Ngày Lập";
            // 
            // textEdit_TenDotPhatHanh
            // 
            this.textEdit_TenDotPhatHanh.Location = new System.Drawing.Point(122, 77);
            this.textEdit_TenDotPhatHanh.Name = "textEdit_TenDotPhatHanh";
            this.textEdit_TenDotPhatHanh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textEdit_TenDotPhatHanh.Properties.Appearance.Options.UseFont = true;
            this.textEdit_TenDotPhatHanh.Properties.MaxLength = 500;
            this.textEdit_TenDotPhatHanh.Size = new System.Drawing.Size(250, 26);
            this.textEdit_TenDotPhatHanh.TabIndex = 7;
            // 
            // labelControl_TenDotPhatHanh
            // 
            this.labelControl_TenDotPhatHanh.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_TenDotPhatHanh.Location = new System.Drawing.Point(12, 80);
            this.labelControl_TenDotPhatHanh.Name = "labelControl_TenDotPhatHanh";
            this.labelControl_TenDotPhatHanh.Size = new System.Drawing.Size(62, 20);
            this.labelControl_TenDotPhatHanh.TabIndex = 6;
            this.labelControl_TenDotPhatHanh.Text = "Tên  ĐPH";
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.Image = global::PresentationLayer.Properties.Resources.Cancel;
            this.simpleButton_Cancel.Location = new System.Drawing.Point(242, 189);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_Cancel.TabIndex = 14;
            this.simpleButton_Cancel.Text = "Cancel";
            this.simpleButton_Cancel.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // simpleButton_OK
            // 
            this.simpleButton_OK.Image = global::PresentationLayer.Properties.Resources.Apply;
            this.simpleButton_OK.Location = new System.Drawing.Point(62, 189);
            this.simpleButton_OK.Name = "simpleButton_OK";
            this.simpleButton_OK.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_OK.TabIndex = 13;
            this.simpleButton_OK.Text = "OK";
            this.simpleButton_OK.Click += new System.EventHandler(this.simpleButton_OK_Click);
            // 
            // FormEditDotPhatHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.simpleButton_Cancel);
            this.Controls.Add(this.simpleButton_OK);
            this.Controls.Add(this.dateEdit_NgayLap);
            this.Controls.Add(this.labelControl_NgayLap);
            this.Controls.Add(this.textEdit_TenDotPhatHanh);
            this.Controls.Add(this.labelControl_TenDotPhatHanh);
            this.Controls.Add(this.labelControl_DotPhatHanh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditDotPhatHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đợt Phát Hành";
            this.Load += new System.EventHandler(this.FormEditDotPhatHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenDotPhatHanh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl_DotPhatHanh;
        private DevExpress.XtraEditors.DateEdit dateEdit_NgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl_NgayLap;
        private DevExpress.XtraEditors.TextEdit textEdit_TenDotPhatHanh;
        private DevExpress.XtraEditors.LabelControl labelControl_TenDotPhatHanh;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OK;
    }
}