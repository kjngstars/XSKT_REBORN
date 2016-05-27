namespace PresentationLayer.Dialogs
{
    partial class FormGhiNhanKQSX
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItem_LoaiVe = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox_LoaiVe = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem_NgayMoThuong = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit_NgayMoThuong = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPage_KQSX = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_LoaiVe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_NgayMoThuong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox_NgayLap = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.simpleButton_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_OK = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_LoaiVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_NgayMoThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_NgayMoThuong.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_NgayLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barEditItem_LoaiVe,
            this.barEditItem_NgayMoThuong});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 5;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_KQSX});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox_LoaiVe,
            this.repositoryItemComboBox_NgayLap,
            this.repositoryItemDateEdit_NgayMoThuong});
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(784, 119);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // barEditItem_LoaiVe
            // 
            this.barEditItem_LoaiVe.Caption = "Loại Vé";
            this.barEditItem_LoaiVe.Edit = this.repositoryItemComboBox_LoaiVe;
            this.barEditItem_LoaiVe.Id = 1;
            this.barEditItem_LoaiVe.Name = "barEditItem_LoaiVe";
            this.barEditItem_LoaiVe.Width = 150;
            // 
            // repositoryItemComboBox_LoaiVe
            // 
            this.repositoryItemComboBox_LoaiVe.AutoHeight = false;
            this.repositoryItemComboBox_LoaiVe.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox_LoaiVe.Name = "repositoryItemComboBox_LoaiVe";
            this.repositoryItemComboBox_LoaiVe.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barEditItem_NgayMoThuong
            // 
            this.barEditItem_NgayMoThuong.Caption = "Ngày Lập";
            this.barEditItem_NgayMoThuong.Edit = this.repositoryItemDateEdit_NgayMoThuong;
            this.barEditItem_NgayMoThuong.Id = 4;
            this.barEditItem_NgayMoThuong.Name = "barEditItem_NgayMoThuong";
            this.barEditItem_NgayMoThuong.Width = 150;
            // 
            // repositoryItemDateEdit_NgayMoThuong
            // 
            this.repositoryItemDateEdit_NgayMoThuong.AutoHeight = false;
            this.repositoryItemDateEdit_NgayMoThuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_NgayMoThuong.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_NgayMoThuong.Name = "repositoryItemDateEdit_NgayMoThuong";
            this.repositoryItemDateEdit_NgayMoThuong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // ribbonPage_KQSX
            // 
            this.ribbonPage_KQSX.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_LoaiVe,
            this.ribbonPageGroup_NgayMoThuong});
            this.ribbonPage_KQSX.Name = "ribbonPage_KQSX";
            this.ribbonPage_KQSX.Text = "Kết Quả  Sổ Xố";
            // 
            // ribbonPageGroup_LoaiVe
            // 
            this.ribbonPageGroup_LoaiVe.ItemLinks.Add(this.barEditItem_LoaiVe, true);
            this.ribbonPageGroup_LoaiVe.Name = "ribbonPageGroup_LoaiVe";
            this.ribbonPageGroup_LoaiVe.ShowCaptionButton = false;
            this.ribbonPageGroup_LoaiVe.Text = "Loại Vé";
            // 
            // ribbonPageGroup_NgayMoThuong
            // 
            this.ribbonPageGroup_NgayMoThuong.ItemLinks.Add(this.barEditItem_NgayMoThuong);
            this.ribbonPageGroup_NgayMoThuong.Name = "ribbonPageGroup_NgayMoThuong";
            this.ribbonPageGroup_NgayMoThuong.ShowCaptionButton = false;
            this.ribbonPageGroup_NgayMoThuong.Text = "Ngày Mở Thưởng";
            // 
            // repositoryItemComboBox_NgayLap
            // 
            this.repositoryItemComboBox_NgayLap.AutoHeight = false;
            this.repositoryItemComboBox_NgayLap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox_NgayLap.Name = "repositoryItemComboBox_NgayLap";
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_Cancel.Image = global::PresentationLayer.Properties.Resources.Cancel;
            this.simpleButton_Cancel.Location = new System.Drawing.Point(442, 489);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_Cancel.TabIndex = 16;
            this.simpleButton_Cancel.Text = "Cancel";
            // 
            // simpleButton_OK
            // 
            this.simpleButton_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_OK.Image = global::PresentationLayer.Properties.Resources.Apply;
            this.simpleButton_OK.Location = new System.Drawing.Point(262, 489);
            this.simpleButton_OK.Name = "simpleButton_OK";
            this.simpleButton_OK.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_OK.TabIndex = 15;
            this.simpleButton_OK.Text = "OK";
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl.Appearance.Options.UseBackColor = true;
            this.panelControl.ContentImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.panelControl.Location = new System.Drawing.Point(0, 119);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(784, 364);
            this.panelControl.TabIndex = 18;
            // 
            // FormGhiNhanKQSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.simpleButton_Cancel);
            this.Controls.Add(this.simpleButton_OK);
            this.Controls.Add(this.ribbonControl);
            this.Name = "FormGhiNhanKQSX";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ghi Nhận Kết Quả Xổ Số";
            this.Load += new System.EventHandler(this.FormGhiNhanKQSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_LoaiVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_NgayMoThuong.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_NgayMoThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_NgayLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_KQSX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_LoaiVe;
        private DevExpress.XtraBars.BarEditItem barEditItem_LoaiVe;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox_LoaiVe;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox_NgayLap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_NgayMoThuong;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OK;
        private DevExpress.XtraBars.BarEditItem barEditItem_NgayMoThuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_NgayMoThuong;
        private DevExpress.XtraEditors.PanelControl panelControl;
    }
}