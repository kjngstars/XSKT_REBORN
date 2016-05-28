namespace PresentationLayer
{
    partial class FormTraCuuKQXS
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
            this.dateEdit_NgayMoThuong = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxEdit_LoaiVe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl_NgayMoThuong = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_LoaiVe = new DevExpress.XtraEditors.LabelControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.userControlTraCuuKQXS = new PresentationLayer.UserControls.UserControlTraCuuKQXS();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayMoThuong.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayMoThuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_LoaiVe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateEdit_NgayMoThuong
            // 
            this.dateEdit_NgayMoThuong.EditValue = null;
            this.dateEdit_NgayMoThuong.Location = new System.Drawing.Point(150, 40);
            this.dateEdit_NgayMoThuong.Name = "dateEdit_NgayMoThuong";
            this.dateEdit_NgayMoThuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateEdit_NgayMoThuong.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NgayMoThuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayMoThuong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayMoThuong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit_NgayMoThuong.Size = new System.Drawing.Size(200, 22);
            this.dateEdit_NgayMoThuong.TabIndex = 26;
            this.dateEdit_NgayMoThuong.EditValueChanged += new System.EventHandler(this.dateEdit_NgayMoThuong_EditValueChanged);
            // 
            // comboBoxEdit_LoaiVe
            // 
            this.comboBoxEdit_LoaiVe.Location = new System.Drawing.Point(150, 12);
            this.comboBoxEdit_LoaiVe.Name = "comboBoxEdit_LoaiVe";
            this.comboBoxEdit_LoaiVe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxEdit_LoaiVe.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit_LoaiVe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_LoaiVe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_LoaiVe.Size = new System.Drawing.Size(200, 22);
            this.comboBoxEdit_LoaiVe.TabIndex = 25;
            this.comboBoxEdit_LoaiVe.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_LoaiVe_SelectedIndexChanged);
            // 
            // labelControl_NgayMoThuong
            // 
            this.labelControl_NgayMoThuong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl_NgayMoThuong.Location = new System.Drawing.Point(12, 43);
            this.labelControl_NgayMoThuong.Name = "labelControl_NgayMoThuong";
            this.labelControl_NgayMoThuong.Size = new System.Drawing.Size(107, 17);
            this.labelControl_NgayMoThuong.TabIndex = 24;
            this.labelControl_NgayMoThuong.Text = "Ngày Mở Thưởng";
            // 
            // labelControl_LoaiVe
            // 
            this.labelControl_LoaiVe.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl_LoaiVe.Location = new System.Drawing.Point(12, 15);
            this.labelControl_LoaiVe.Name = "labelControl_LoaiVe";
            this.labelControl_LoaiVe.Size = new System.Drawing.Size(43, 17);
            this.labelControl_LoaiVe.TabIndex = 23;
            this.labelControl_LoaiVe.Text = "Loại Vé";
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl.Appearance.Options.UseBackColor = true;
            this.panelControl.Controls.Add(this.userControlTraCuuKQXS);
            this.panelControl.Location = new System.Drawing.Point(0, 68);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(784, 493);
            this.panelControl.TabIndex = 27;
            // 
            // userControlTraCuuKQXS
            // 
            this.userControlTraCuuKQXS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTraCuuKQXS.Location = new System.Drawing.Point(2, 2);
            this.userControlTraCuuKQXS.Name = "userControlTraCuuKQXS";
            this.userControlTraCuuKQXS.Size = new System.Drawing.Size(780, 489);
            this.userControlTraCuuKQXS.TabIndex = 0;
            // 
            // FormTraCuuKQXS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.dateEdit_NgayMoThuong);
            this.Controls.Add(this.comboBoxEdit_LoaiVe);
            this.Controls.Add(this.labelControl_NgayMoThuong);
            this.Controls.Add(this.labelControl_LoaiVe);
            this.Name = "FormTraCuuKQXS";
            this.Text = "Tra Cứu Kết Quả Xổ Số";
            this.Load += new System.EventHandler(this.FormTraCuuKQXS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayMoThuong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayMoThuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_LoaiVe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit_NgayMoThuong;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_LoaiVe;
        private DevExpress.XtraEditors.LabelControl labelControl_NgayMoThuong;
        private DevExpress.XtraEditors.LabelControl labelControl_LoaiVe;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private UserControls.UserControlTraCuuKQXS userControlTraCuuKQXS;
    }
}