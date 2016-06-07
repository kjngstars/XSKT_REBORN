namespace PresentationLayer
{
    partial class FormDanhSachDotPhatHanh
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
            this.MADOTPHATHANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            this.gridControl.TabIndex = 0;
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
            this.MADOTPHATHANH,
            this.TENLOAIVE,
            this.NGAYLAP});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // MADOTPHATHANH
            // 
            this.MADOTPHATHANH.Caption = "Mã Đợt Phát Hành";
            this.MADOTPHATHANH.FieldName = "MADOTPHATHANH";
            this.MADOTPHATHANH.Name = "MADOTPHATHANH";
            this.MADOTPHATHANH.Visible = true;
            this.MADOTPHATHANH.VisibleIndex = 0;
            // 
            // TENLOAIVE
            // 
            this.TENLOAIVE.Caption = "Tên Đợt Phát Hành";
            this.TENLOAIVE.FieldName = "TENDOTPHATHANH";
            this.TENLOAIVE.Name = "TENLOAIVE";
            this.TENLOAIVE.Visible = true;
            this.TENLOAIVE.VisibleIndex = 1;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Caption = "Ngày Lập";
            this.NGAYLAP.FieldName = "NGAYLAP";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Visible = true;
            this.NGAYLAP.VisibleIndex = 2;
            // 
            // FormDanhSachDotPhatHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl);
            this.Name = "FormDanhSachDotPhatHanh";
            this.Text = "Danh Sách Loại Vé";
            this.Load += new System.EventHandler(this.FormDanhSachDotPhatHanh_Load);
            this.Shown += new System.EventHandler(this.FormDanhSachDotPhatHanh_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Them;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CapNhat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Xoa;
        private DevExpress.XtraGrid.Columns.GridColumn MADOTPHATHANH;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIVE;
    }
}