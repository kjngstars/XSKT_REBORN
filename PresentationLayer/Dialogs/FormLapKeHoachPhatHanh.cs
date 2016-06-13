

using BusinessLogicLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.Dialogs
{
    public partial class FormLapKeHoachPhatHanh : DevExpress.XtraEditors.XtraForm
    {
        private DoiTacBUS _DoiTacBUS = new DoiTacBUS();
        private LoaiVeBUS _LoaiVeBUS = new LoaiVeBUS();
        private PublishBUS publish = new PublishBUS();
        private KeHoachPhatHanhBUS _KeHoachPhatHanhBUS = new KeHoachPhatHanhBUS();
        private DataTable dataTable;
        public FormLapKeHoachPhatHanh()
        {
            InitializeComponent();
        }

        void FillDanhSachDoiTac(DataTable table)
        {
            repositoryItemLookUpEdit_DoiTac.Properties.DataSource = table;
            repositoryItemLookUpEdit_DoiTac.Properties.DisplayMember = "TENDOITAC";
            repositoryItemLookUpEdit_DoiTac.Properties.ValueMember = "MADOITAC";

            repositoryItemLookUpEdit_DoiTac.Properties.Columns.Add(new LookUpColumnInfo("MADOITAC", 0, "Mã Đối Tác"));
            repositoryItemLookUpEdit_DoiTac.Properties.Columns.Add(new LookUpColumnInfo("TENDOITAC", 0, "Tên Đối Tác"));

            repositoryItemLookUpEdit_DoiTac.Properties.SearchMode = SearchMode.AutoComplete;
            repositoryItemLookUpEdit_DoiTac.Properties.AutoSearchColumnIndex = 1;
        }

        void FillDanhSachLoaiVe(DataTable table)
        {
            repositoryItemLookUpEdit_MaLoaiVe.Properties.DataSource = table;
            repositoryItemLookUpEdit_MaLoaiVe.Properties.DisplayMember = "MALOAIVE";
            repositoryItemLookUpEdit_MaLoaiVe.Properties.ValueMember = "MALOAIVE";

            repositoryItemLookUpEdit_MaLoaiVe.Properties.Columns.Add(new LookUpColumnInfo("MALOAIVE", 0, "Mã Loại Vé"));
            repositoryItemLookUpEdit_MaLoaiVe.Properties.Columns.Add(new LookUpColumnInfo("TENLOAIVE", 0, "Tên Loại Vé"));

            repositoryItemLookUpEdit_MaLoaiVe.Properties.SearchMode = SearchMode.AutoComplete;
            repositoryItemLookUpEdit_MaLoaiVe.Properties.AutoSearchColumnIndex = 1;
        }
        void FillDotPhatHanh(DataTable table)
        {

            lookUpEdit_DotPhatHanh.Properties.DataSource = table;
            lookUpEdit_DotPhatHanh.Properties.DisplayMember = "TENDOTPHATHANH";
            lookUpEdit_DotPhatHanh.Properties.ValueMember = "MADOTPHATHANH";

            lookUpEdit_DotPhatHanh.Properties.Columns.Add(new LookUpColumnInfo("TENDOTPHATHANH", 0, "Tên Đối Tác"));
            lookUpEdit_DotPhatHanh.Properties.Columns.Add(new LookUpColumnInfo("NGAYLAP", 0, "Ngày Phát Hành"));

            lookUpEdit_DotPhatHanh.Properties.SearchMode = SearchMode.AutoComplete;
            lookUpEdit_DotPhatHanh.Properties.AutoSearchColumnIndex = 1;

        }
        public void InsertLoad()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("MADOITAC");
            dataTable.Columns.Add("MALOAIVE");
            dataTable.Columns.Add("TENLOAIVE");
            dataTable.Columns.Add("MENHGIA");
            dataTable.Columns.Add("SOVEPHATHANH");
            dataTable.Columns.Add("MADOTPHATHANH");
            dataTable.Columns.Add("MACHITIETDOTPHATHANH");
            this.gridControl1.DataSource = dataTable;
        }

        private void FormLapKeHoachPhatHanh_Load(object sender, System.EventArgs e)
        {
            DataTable table;
            table = _DoiTacBUS.GetAll_CT();
            FillDanhSachDoiTac(table);

            table = _LoaiVeBUS.GetAll();
            FillDanhSachLoaiVe(table);

            table = publish.GetAllPublishPlan();
            FillDotPhatHanh(table);

            InsertLoad();
        }
        private void simpleButton4_Click(object sender, System.EventArgs e)
        {
            dataTable.Rows.Add();
            // this.gridView1.AddNewRow();
        }

        private void simpleButton3_Click(object sender, System.EventArgs e)
        {
            if (this.gridView1.FocusedRowHandle >= 0)
            {
                this.gridView1.DeleteSelectedRows();
            }
        }

        private void repositoryItemLookUpEdit_MaLoaiVe_EditValueChanged(object sender, System.EventArgs e)
        {
            var maLoaiVe = gridView1.EditingValue;
            var index = this.gridView1.FocusedRowHandle;
            LoaiVe loaive = _LoaiVeBUS.GetLoaiVeByMaLoaiVe(maLoaiVe.ToString());
            dataTable.Rows[index]["TENLOAIVE"] = loaive.TenLoaiVe;
            dataTable.Rows[index]["MENHGIA"] = loaive.MenhGia;
        }

        private void simpleButton_Cancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButton_OK_Click(object sender, System.EventArgs e)
        {
            InsertCTDPH();
        }
        public void InsertCTDPH()
        {
            try
            {
                
                for (int i = 0; i < this.gridView1.RowCount; i++)
                    this.InsertCTDPH(this.gridView1.GetDataRow(i));

                this.DialogResult = DialogResult.OK;

                XtraMessageBox.Show("Thêm Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InsertCTDPH(DataRow row)
        {
            row["MADOTPHATHANH"] = lookUpEdit_DotPhatHanh.EditValue;
            _KeHoachPhatHanhBUS.Insert(new KeHoachPhatHanh(row));
        }
    }
}