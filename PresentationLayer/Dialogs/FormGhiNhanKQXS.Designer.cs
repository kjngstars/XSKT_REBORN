namespace PresentationLayer.Dialogs
{
    partial class FormGhiNhanKQXS
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
            this.simpleButton_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_OK = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.userControlGhiNhanKQXS = new PresentationLayer.UserControls.UserControlGhiNhanKQXS();
            this.labelControl_LoaiVe = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_NgayMoThuong = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit_LoaiVe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEdit_NgayMoThuong = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_LoaiVe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayMoThuong.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayMoThuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton_Cancel.Image = global::PresentationLayer.Properties.Resources.Cancel;
            this.simpleButton_Cancel.Location = new System.Drawing.Point(442, 489);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_Cancel.TabIndex = 16;
            this.simpleButton_Cancel.Text = "Cancel";
            this.simpleButton_Cancel.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // simpleButton_OK
            // 
            this.simpleButton_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton_OK.Image = global::PresentationLayer.Properties.Resources.Apply;
            this.simpleButton_OK.Location = new System.Drawing.Point(262, 489);
            this.simpleButton_OK.Name = "simpleButton_OK";
            this.simpleButton_OK.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_OK.TabIndex = 15;
            this.simpleButton_OK.Text = "OK";
            this.simpleButton_OK.Click += new System.EventHandler(this.simpleButton_OK_Click);
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl.Appearance.Options.UseBackColor = true;
            this.panelControl.Controls.Add(this.userControlGhiNhanKQXS);
            this.panelControl.Location = new System.Drawing.Point(0, 68);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(784, 415);
            this.panelControl.TabIndex = 18;
            // 
            // userControlGhiNhanKQXS
            // 
            this.userControlGhiNhanKQXS.AutoScroll = true;
            this.userControlGhiNhanKQXS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlGhiNhanKQXS.Location = new System.Drawing.Point(2, 2);
            this.userControlGhiNhanKQXS.Name = "userControlGhiNhanKQXS";
            this.userControlGhiNhanKQXS.Size = new System.Drawing.Size(780, 411);
            this.userControlGhiNhanKQXS.TabIndex = 0;
            this.userControlGhiNhanKQXS.TextEditWidth = 75;
            // 
            // labelControl_LoaiVe
            // 
            this.labelControl_LoaiVe.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl_LoaiVe.Location = new System.Drawing.Point(12, 15);
            this.labelControl_LoaiVe.Name = "labelControl_LoaiVe";
            this.labelControl_LoaiVe.Size = new System.Drawing.Size(43, 17);
            this.labelControl_LoaiVe.TabIndex = 19;
            this.labelControl_LoaiVe.Text = "Loại Vé";
            // 
            // labelControl_NgayMoThuong
            // 
            this.labelControl_NgayMoThuong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl_NgayMoThuong.Location = new System.Drawing.Point(12, 43);
            this.labelControl_NgayMoThuong.Name = "labelControl_NgayMoThuong";
            this.labelControl_NgayMoThuong.Size = new System.Drawing.Size(107, 17);
            this.labelControl_NgayMoThuong.TabIndex = 20;
            this.labelControl_NgayMoThuong.Text = "Ngày Mở Thưởng";
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
            this.comboBoxEdit_LoaiVe.TabIndex = 21;
            this.comboBoxEdit_LoaiVe.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_LoaiVe_SelectedIndexChanged);
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
            this.dateEdit_NgayMoThuong.TabIndex = 22;
            // 
            // FormGhiNhanKQXS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dateEdit_NgayMoThuong);
            this.Controls.Add(this.comboBoxEdit_LoaiVe);
            this.Controls.Add(this.labelControl_NgayMoThuong);
            this.Controls.Add(this.labelControl_LoaiVe);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.simpleButton_Cancel);
            this.Controls.Add(this.simpleButton_OK);
            this.Name = "FormGhiNhanKQXS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ghi Nhận Kết Quả Xổ Số";
            this.Load += new System.EventHandler(this.FormGhiNhanKQSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_LoaiVe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayMoThuong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayMoThuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OK;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.LabelControl labelControl_LoaiVe;
        private DevExpress.XtraEditors.LabelControl labelControl_NgayMoThuong;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_LoaiVe;
        private DevExpress.XtraEditors.DateEdit dateEdit_NgayMoThuong;
        private UserControls.UserControlGhiNhanKQXS userControlGhiNhanKQXS;
    }
}