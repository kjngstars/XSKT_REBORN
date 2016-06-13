namespace PresentationLayer.Dialogs
{
    partial class FormLapKeHoachPhatHanh
    {  /// <summary>
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
            this.lookUpEdit_DotPhatHanh = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl_DotPhatHanh = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_DoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_DoiTac = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn_MaLoaiVe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_MaLoaiVe = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn_TenLoaiVe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_MenhGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_DotPhatHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_DoiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_MaLoaiVe)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.Image = global::PresentationLayer.Properties.Resources.Cancel;
            this.simpleButton_Cancel.Location = new System.Drawing.Point(442, 489);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_Cancel.TabIndex = 14;
            this.simpleButton_Cancel.Text = "Cancel";
            this.simpleButton_Cancel.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // simpleButton_OK
            // 
            this.simpleButton_OK.Image = global::PresentationLayer.Properties.Resources.Apply;
            this.simpleButton_OK.Location = new System.Drawing.Point(262, 489);
            this.simpleButton_OK.Name = "simpleButton_OK";
            this.simpleButton_OK.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_OK.TabIndex = 13;
            this.simpleButton_OK.Text = "OK";
            this.simpleButton_OK.Click += new System.EventHandler(this.simpleButton_OK_Click);
            // 
            // lookUpEdit_DotPhatHanh
            // 
            this.lookUpEdit_DotPhatHanh.Location = new System.Drawing.Point(111, 11);
            this.lookUpEdit_DotPhatHanh.Name = "lookUpEdit_DotPhatHanh";
            this.lookUpEdit_DotPhatHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_DotPhatHanh.Properties.NullText = "";
            this.lookUpEdit_DotPhatHanh.Size = new System.Drawing.Size(138, 20);
            this.lookUpEdit_DotPhatHanh.TabIndex = 30;
            // 
            // labelControl_DotPhatHanh
            // 
            this.labelControl_DotPhatHanh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl_DotPhatHanh.Location = new System.Drawing.Point(12, 12);
            this.labelControl_DotPhatHanh.Name = "labelControl_DotPhatHanh";
            this.labelControl_DotPhatHanh.Size = new System.Drawing.Size(91, 17);
            this.labelControl_DotPhatHanh.TabIndex = 29;
            this.labelControl_DotPhatHanh.Text = "Đợt Phát Hành";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Location = new System.Drawing.Point(12, 78);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(760, 405);
            this.groupControl2.TabIndex = 32;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_DoiTac,
            this.repositoryItemLookUpEdit_MaLoaiVe});
            this.gridControl1.Size = new System.Drawing.Size(750, 336);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_DoiTac,
            this.gridColumn_MaLoaiVe,
            this.gridColumn_TenLoaiVe,
            this.gridColumn_MenhGia,
            this.gridColumn_SoLuong});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn_DoiTac
            // 
            this.gridColumn_DoiTac.Caption = "Đối Tác";
            this.gridColumn_DoiTac.ColumnEdit = this.repositoryItemLookUpEdit_DoiTac;
            this.gridColumn_DoiTac.FieldName = "MADOITAC";
            this.gridColumn_DoiTac.Name = "gridColumn_DoiTac";
            this.gridColumn_DoiTac.Visible = true;
            this.gridColumn_DoiTac.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit_DoiTac
            // 
            this.repositoryItemLookUpEdit_DoiTac.AutoHeight = false;
            this.repositoryItemLookUpEdit_DoiTac.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_DoiTac.Name = "repositoryItemLookUpEdit_DoiTac";
            this.repositoryItemLookUpEdit_DoiTac.NullText = "";
            // 
            // gridColumn_MaLoaiVe
            // 
            this.gridColumn_MaLoaiVe.Caption = "Mã Loại Vé";
            this.gridColumn_MaLoaiVe.ColumnEdit = this.repositoryItemLookUpEdit_MaLoaiVe;
            this.gridColumn_MaLoaiVe.FieldName = "MALOAIVE";
            this.gridColumn_MaLoaiVe.Name = "gridColumn_MaLoaiVe";
            this.gridColumn_MaLoaiVe.Visible = true;
            this.gridColumn_MaLoaiVe.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit_MaLoaiVe
            // 
            this.repositoryItemLookUpEdit_MaLoaiVe.AutoHeight = false;
            this.repositoryItemLookUpEdit_MaLoaiVe.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_MaLoaiVe.Name = "repositoryItemLookUpEdit_MaLoaiVe";
            this.repositoryItemLookUpEdit_MaLoaiVe.NullText = "";
            this.repositoryItemLookUpEdit_MaLoaiVe.EditValueChanged += new System.EventHandler(this.repositoryItemLookUpEdit_MaLoaiVe_EditValueChanged);
            // 
            // gridColumn_TenLoaiVe
            // 
            this.gridColumn_TenLoaiVe.Caption = "Tên Loại Vé";
            this.gridColumn_TenLoaiVe.FieldName = "TENLOAIVE";
            this.gridColumn_TenLoaiVe.Name = "gridColumn_TenLoaiVe";
            this.gridColumn_TenLoaiVe.OptionsColumn.AllowEdit = false;
            this.gridColumn_TenLoaiVe.Visible = true;
            this.gridColumn_TenLoaiVe.VisibleIndex = 2;
            // 
            // gridColumn_MenhGia
            // 
            this.gridColumn_MenhGia.Caption = "Mệnh Giá";
            this.gridColumn_MenhGia.FieldName = "MENHGIA";
            this.gridColumn_MenhGia.Name = "gridColumn_MenhGia";
            this.gridColumn_MenhGia.OptionsColumn.AllowEdit = false;
            this.gridColumn_MenhGia.Visible = true;
            this.gridColumn_MenhGia.VisibleIndex = 3;
            // 
            // gridColumn_SoLuong
            // 
            this.gridColumn_SoLuong.Caption = "Số Lượng";
            this.gridColumn_SoLuong.FieldName = "SOVEPHATHANH";
            this.gridColumn_SoLuong.Name = "gridColumn_SoLuong";
            this.gridColumn_SoLuong.Visible = true;
            this.gridColumn_SoLuong.VisibleIndex = 4;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::PresentationLayer.Properties.Resources.Delete;
            this.simpleButton3.Location = new System.Drawing.Point(430, 17);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(80, 37);
            this.simpleButton3.TabIndex = 22;
            this.simpleButton3.Text = "Xóa";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = global::PresentationLayer.Properties.Resources.Add;
            this.simpleButton4.Location = new System.Drawing.Point(250, 17);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(80, 37);
            this.simpleButton4.TabIndex = 21;
            this.simpleButton4.Text = "Thêm";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // FormLapKeHoachPhatHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.lookUpEdit_DotPhatHanh);
            this.Controls.Add(this.labelControl_DotPhatHanh);
            this.Controls.Add(this.simpleButton_Cancel);
            this.Controls.Add(this.simpleButton_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLapKeHoachPhatHanh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Đợt Phát Hành";
            this.Load += new System.EventHandler(this.FormLapKeHoachPhatHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_DotPhatHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_DoiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_MaLoaiVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OK;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_DotPhatHanh;
        private DevExpress.XtraEditors.LabelControl labelControl_DotPhatHanh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_DoiTac;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_MaLoaiVe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_TenLoaiVe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_MenhGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_SoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_DoiTac;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_MaLoaiVe;
    }
}