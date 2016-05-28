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

namespace PresentationLayer
{
    public partial class FormTraCuuKQXS : DevExpress.XtraEditors.XtraForm
    {
        private LoaiVeBUS loaiVeBUS = null;

        public FormTraCuuKQXS()
        {
            InitializeComponent();

            this.loaiVeBUS = new LoaiVeBUS();
        }

        private void FormTraCuuKQXS_Load(object sender, EventArgs e)
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

        }

        /// <summary>
        /// Cập nhật lại khi thay đổi ngày mở thưởng
        /// </summary>
        private void dateEdit_NgayMoThuong_EditValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load KQSX
        /// </summary>
        public void LoadKQSX()
        {
            LoaiVe loaiVe = (LoaiVe)this.comboBoxEdit_LoaiVe.Properties.Items[this.comboBoxEdit_LoaiVe.SelectedIndex];
            string ngayMoThuong = this.dateEdit_NgayMoThuong.Text;


        }
    }
}