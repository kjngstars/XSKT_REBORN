using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using BusinessLogicLayer;
using System.Text.RegularExpressions;

namespace PresentationLayer.Dialogs
{
    public partial class FormPhieuTraVe : DevExpress.XtraEditors.XtraForm
    {
        private DoiTac _DoiTac;
        private DoiTacBUS _DoiTacBUS = new DoiTacBUS();

        private PublishBUS publish = new PublishBUS();

        private LoaiVeBUS _LoaiVeBUS = new LoaiVeBUS();

        private PhieuNhanVe_BUS _PhieuNhanVe_BUS = new PhieuNhanVe_BUS();

        private PhieuTraVe_BUS _PhieuTraVe_BUS = new PhieuTraVe_BUS();

        public FormPhieuTraVe()
        {
            InitializeComponent();
        }


        private void FormPhieuTraVe_Load(object sender, EventArgs e)
        {

            var tableDotPhatHanh = publish.GetAllPublishPlan();
            if (tableDotPhatHanh != null)
            {
                FillDotPhatHanh(tableDotPhatHanh);
            }
            dateEdit_NgayLap.EditValue = DateTime.Now;
            textEdit_SoPhieu.Text = autoID.getNextID("PHIEUTRAVE", "MAPHIEUTRAVE", "PTV");
        }

        void FillDanhSachDoiTac(DataTable table)
        {

            lookUpEdit_MaDoiTac.Properties.DataSource = table;
            lookUpEdit_MaDoiTac.Properties.DisplayMember = "MADOITAC";
            lookUpEdit_MaDoiTac.Properties.ValueMember = "MADOITAC";

            lookUpEdit_MaDoiTac.Properties.Columns.Add(new LookUpColumnInfo("MADOITAC", 0, "Mã Đối Tác"));
            lookUpEdit_MaDoiTac.Properties.Columns.Add(new LookUpColumnInfo("TENDOITAC", 0, "Tên Đối Tác"));

            lookUpEdit_MaDoiTac.Properties.SearchMode = SearchMode.AutoComplete;
            lookUpEdit_MaDoiTac.Properties.AutoSearchColumnIndex = 1;
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
        private void lookUpEdit_MaDoiTac_EditValueChanged(object sender, EventArgs e)
        {
            _DoiTac = _DoiTacBUS.GetDoiTacByMaDoiTac(lookUpEdit_MaDoiTac.EditValue.ToString());
            textEdit_TenDoiTac.Text = _DoiTac.TenDoiTac;
            textEdit_DiaChi.Text = _DoiTac.DiaChi;
            textEdit_DienThoai.Text = _DoiTac.DienThoai;
            textEdit_Email.Text = _DoiTac.Email;
            textEdit_TiLeHoaHong.Text = _DoiTac.Rate.ToString();

            DataTable dt_loaive = _PhieuNhanVe_BUS.get_CTPhieuNhanVe(lookUpEdit_DotPhatHanh.EditValue.ToString(), _DoiTac.MaDoiTac);
            dt_loaive.Columns.Add("SOLUONGTRA");
            this.gridControl1.DataSource = dt_loaive;
        }

        private void lookUpEdit_DotPhatHanh_EditValueChanged(object sender, EventArgs e)
        {
            FillDanhSachDoiTac(_DoiTacBUS.GetDoiTacByMaDotPhatHanh(lookUpEdit_DotPhatHanh.EditValue.ToString()));
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable doitac = _PhieuTraVe_BUS.seachPhieuTraVeByMaDotPhatHanhMaDoiTac(lookUpEdit_DotPhatHanh.EditValue.ToString(), lookUpEdit_MaDoiTac.EditValue.ToString());
                if (doitac.Rows.Count == 0)
                {
                    _PhieuTraVe_BUS.Insert_PhieuTraVe(textEdit_SoPhieu.Text, dateEdit_NgayLap.DateTime.ToString(), _DoiTac.MaDoiTac, lookUpEdit_DotPhatHanh.EditValue.ToString());
                    DataView dt = (DataView)gridView1.DataSource;
                    foreach (DataRow row in dt.Table.Rows)
                    {
                        var value = int.Parse(row["SOLUONGTRA"].ToString());
                        if (value > 0)
                        {
                            var maLoaiVe = row["MALOAIVE"].ToString();
                            _PhieuTraVe_BUS.Insert_chiTietPhieuTraVe(textEdit_SoPhieu.Text, maLoaiVe, value);

                        }
                    }
                    XtraMessageBox.Show(@"Thêm Thành Công!");
                    reset();
                }
                else
                {
                    XtraMessageBox.Show(textEdit_TenDoiTac.Text + " Đã Trả Vé!");
                    reset();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Lỗi " + ex.Message, @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        String GenerateMaDangKy(string prefix, DateTime dt)
        {
            string id = prefix;
            id += dt.Month.ToString() + dt.Day.ToString();
            var time = dt.ToString("HH:mm:ss");
            var convert = Regex.Replace(time, "[: ]", "");
            id += convert;
            return id;
        }

        private void dateEdit_NgayLap_EditValueChanged(object sender, EventArgs e)
        {
            textEdit_SoPhieu.Text = GenerateMaDangKy("PTV", dateEdit_NgayLap.DateTime);
        }

        private void reset()
        {
            textEdit_SoPhieu.Text = autoID.getNextID("PHIEUTRAVE", "MAPHIEUTRAVE", "PTV");
            _DoiTac = null;
            textEdit_TenDoiTac.Text = "";
            textEdit_DiaChi.Text = "";
            textEdit_DienThoai.Text = "";
            textEdit_Email.Text = "";
            textEdit_TiLeHoaHong.Text = "";
            lookUpEdit_MaDoiTac.Text = "";
            this.gridControl1.DataSource = null;
        }
    }
}