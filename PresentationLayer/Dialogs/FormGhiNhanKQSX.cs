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
using BusinessLogicLayer;
using PresentationLayer.UserControls;

namespace PresentationLayer.Dialogs
{
    public partial class FormGhiNhanKQSX : DevExpress.XtraEditors.XtraForm
    {
        private ChiTietKetQuaXoSoBUS chiTietKetQuaXoSoBUS = null;
        private GiaiThuongBUS giaiThuongBUS = null;
        private KetQuaXoSoBUS ketQuaXoSoBUS = null;
        private LoaiVeBUS loaiVeBUS = null;

        public FormGhiNhanKQSX()
        {
            InitializeComponent();

            this.chiTietKetQuaXoSoBUS = new ChiTietKetQuaXoSoBUS();
            this.giaiThuongBUS = new GiaiThuongBUS();
            this.ketQuaXoSoBUS = new KetQuaXoSoBUS();
            this.loaiVeBUS = new LoaiVeBUS();
        }

        private void FormGhiNhanKQSX_Load(object sender, EventArgs e)
        {
            this.FillLoaiVe();

            this.dateEdit_NgayMoThuong.EditValue = DateTime.Now;
        }

        /// <summary>
        /// Nạp danh sách loại vé của công ty
        /// </summary>
        public void FillLoaiVe()
        {
            try
            {
                DataTable dataTable = this.loaiVeBUS.GetLoaiVeCT();

                foreach (DataRow row in dataTable.Rows)
                {
                    LoaiVe loaiVe = new LoaiVe(row);

                    this.comboBoxEdit_LoaiVe.Properties.Items.Add(loaiVe);
                }

                if (this.comboBoxEdit_LoaiVe.Properties.Items.Count > 0)
                    this.comboBoxEdit_LoaiVe.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật lại khi thay đổi loại vé
        /// </summary>
        private void comboBoxEdit_LoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxEdit_LoaiVe.Properties.Items.Count > 0)
            {
                LoaiVe loaiVe = (LoaiVe)this.comboBoxEdit_LoaiVe.Properties.Items[this.comboBoxEdit_LoaiVe.SelectedIndex];

                try
                {
                    this.userControlKQSX.CreateComponentControls(this.giaiThuongBUS.GetGiaiThuongByMaCoCauGiaiThuong(loaiVe.MaCoCauGiaiThuong));
                }
                catch (Exception ex)
                {
                    this.DialogResult = DialogResult.Abort;

                    XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            LoaiVe loaiVe = (LoaiVe)this.comboBoxEdit_LoaiVe.Properties.Items[this.comboBoxEdit_LoaiVe.SelectedIndex];

            KetQuaXoSo ketQuaXoSo = new KetQuaXoSo(
                string.Empty,
                this.dateEdit_NgayMoThuong.Text,
                loaiVe.MaLoaiVe);
            try
            {
                try
                {
                    ketQuaXoSo.MaKetQuaXoSo = this.ketQuaXoSoBUS.Insert(ketQuaXoSo);
                }
                catch (Exception ex)
                {
                    this.DialogResult = DialogResult.Abort;

                    XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                List<ChiTietKetQuaXoSo> listChiTietKetQuaXoSo = this.userControlKQSX.GetListChiTietKetQuaXoSo(ketQuaXoSo.MaKetQuaXoSo);

                foreach (ChiTietKetQuaXoSo chiTietKetQuaXoSo in listChiTietKetQuaXoSo)
                {
                    try
                    {
                        this.chiTietKetQuaXoSoBUS.Insert(chiTietKetQuaXoSo);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;

            XtraMessageBox.Show("Thêm Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}