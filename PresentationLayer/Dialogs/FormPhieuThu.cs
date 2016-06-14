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
    public partial class FormPhieuThu : DevExpress.XtraEditors.XtraForm
    {
        private DoiTac _DoiTac;
        private DoiTacBUS _DoiTacBUS = new DoiTacBUS();

        private PublishBUS publish = new PublishBUS();

        private LoaiVeBUS _LoaiVeBUS = new LoaiVeBUS();

        private PhieuNhanVe_BUS _PhieuNhanVe_BUS = new PhieuNhanVe_BUS();

        private PhieuThu_BUS _PhieuThu_BUS = new PhieuThu_BUS();

        private DataTable dt_loaive;

        private int TongVe;
        private decimal ThanhTien;
        private decimal HoaHong;
        private decimal CongNo;

        public FormPhieuThu()
        {
            InitializeComponent();
        }


        private void FormPhieuThu_Load(object sender, EventArgs e)
        {

            var tableDotPhatHanh = publish.GetAllPublishPlan();
            if (tableDotPhatHanh != null)
            {
                FillDotPhatHanh(tableDotPhatHanh);
            }
            dateEdit_NgayLap.EditValue = DateTime.Now;
            textEdit_SoPhieu.Text = autoID.getNextID("PhieuThu", "MAPhieuThu", "PTT");
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

            dt_loaive = _PhieuThu_BUS.getDSVe(lookUpEdit_DotPhatHanh.EditValue.ToString(), _DoiTac.MaDoiTac);
            this.gridControl1.DataSource = dt_loaive;
            int slNhan, slTra;
            decimal DonGia;
            float hhong;
            for (int i = 0; i < dt_loaive.Rows.Count; i++)
            {
                slNhan = int.Parse(dt_loaive.Rows[i]["SOLUONGNHAN"].ToString());
                DonGia = decimal.Parse(dt_loaive.Rows[i]["MENHGIA"].ToString());
                hhong = float.Parse(textEdit_TiLeHoaHong.Text);
                if (dt_loaive.Rows[i]["SOLUONGTRA"].ToString() == "")
                    slTra = 0;
                else
                    slTra = int.Parse(dt_loaive.Rows[i]["SOLUONGTRA"].ToString());
                TongVe += slNhan - slTra;
                ThanhTien = (long)((slNhan - slTra) * DonGia);
                HoaHong = (long)((long)ThanhTien * hhong);
                CongNo = (long)(ThanhTien - (long)HoaHong);

                textEdit_TongVe.Text = TongVe.ToString();
                textEdit_HoaHong.Text = HoaHong.ToString();
                textEdit_ThanhTien.Text = ThanhTien.ToString();
                textEdit_CongNo.Text = CongNo.ToString();

            }
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
                DataTable phieuthu = _PhieuThu_BUS.seachPhieuThuByMaDotPhatHanhMaDoiTac(lookUpEdit_DotPhatHanh.EditValue.ToString(), lookUpEdit_MaDoiTac.EditValue.ToString());
                if (phieuthu.Rows.Count == 0)
                {
                    _PhieuThu_BUS.Insert(dateEdit_NgayLap.DateTime, lookUpEdit_MaDoiTac.EditValue.ToString(), lookUpEdit_DotPhatHanh.EditValue.ToString(), CongNo);
                    _DoiTacBUS.UpdateCongNo(decimal.Parse("-"+textEdit_CongNo.Text), lookUpEdit_MaDoiTac.EditValue.ToString());
                    XtraMessageBox.Show(@"Thêm Thành Công!");
                    reset();
                }
               else
                {
                    XtraMessageBox.Show(textEdit_TenDoiTac.Text + " Đã Thanh Toán!");
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
            textEdit_SoPhieu.Text = GenerateMaDangKy("PT", dateEdit_NgayLap.DateTime);
        }

        private void reset()
        {
            textEdit_SoPhieu.Text = autoID.getNextID("PhieuThu", "MAPhieuThu", "PTT");
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