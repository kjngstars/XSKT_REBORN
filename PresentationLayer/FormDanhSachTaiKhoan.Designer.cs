namespace PresentationLayer
{
    partial class FormDanhSachTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Them = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_CapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENDANGNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MATKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYENHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.ContextMenuStrip = this.contextMenuStrip;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 561);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Them,
            this.toolStripMenuItem_CapNhat,
            this.toolStripMenuItem_Xoa});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(125, 70);
            // 
            // toolStripMenuItem_Them
            // 
            this.toolStripMenuItem_Them.Name = "toolStripMenuItem_Them";
            this.toolStripMenuItem_Them.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem_Them.Text = "Thêm";
            this.toolStripMenuItem_Them.Click += new System.EventHandler(this.toolStripMenuItem_Them_Click);
            // 
            // toolStripMenuItem_CapNhat
            // 
            this.toolStripMenuItem_CapNhat.Name = "toolStripMenuItem_CapNhat";
            this.toolStripMenuItem_CapNhat.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem_CapNhat.Text = "Cập Nhật";
            this.toolStripMenuItem_CapNhat.Click += new System.EventHandler(this.toolStripMenuItem_CapNhat_Click);
            // 
            // toolStripMenuItem_Xoa
            // 
            this.toolStripMenuItem_Xoa.Name = "toolStripMenuItem_Xoa";
            this.toolStripMenuItem_Xoa.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem_Xoa.Text = "Xóa";
            this.toolStripMenuItem_Xoa.Click += new System.EventHandler(this.toolStripMenuItem_Xoa_Click);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENDANGNHAP,
            this.MATKHAU,
            this.QUYENHAN});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Caption = "Tên Đăng Nhập";
            this.TENDANGNHAP.FieldName = "TENDANGNHAP";
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.Visible = true;
            this.TENDANGNHAP.VisibleIndex = 0;
            // 
            // MATKHAU
            // 
            this.MATKHAU.Caption = "Mật Khẩu";
            this.MATKHAU.FieldName = "MATKHAU";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.Visible = true;
            this.MATKHAU.VisibleIndex = 1;
            // 
            // QUYENHAN
            // 
            this.QUYENHAN.Caption = "Qyền Hạn";
            this.QUYENHAN.FieldName = "QUYENHAN";
            this.QUYENHAN.Name = "QUYENHAN";
            this.QUYENHAN.Visible = true;
            this.QUYENHAN.VisibleIndex = 2;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // FormDanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl);
            this.Name = "FormDanhSachTaiKhoan";
            this.Text = "Danh Sách Tài Khoản";
            this.Load += new System.EventHandler(this.FormDanhSachTaiKhoan_Load);
            this.Shown += new System.EventHandler(this.FormDanhSachTaiKhoan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Them;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CapNhat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Xoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn TENDANGNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn MATKHAU;
        private DevExpress.XtraGrid.Columns.GridColumn QUYENHAN;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
    }
}