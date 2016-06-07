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

namespace PresentationLayer.Dialogs
{
    public partial class FormEditDotPhatHanh : DevExpress.XtraEditors.XtraForm
    {
        private DotPhatHanh dotPhatHanh = null;
        private DotPhatHanhBUS dotPhatHanhBUS = null;

        /// <summary>
        /// Khởi tạo để thêm đợt phát hành
        /// </summary>
        public FormEditDotPhatHanh()
        {
            InitializeComponent();

            this.dotPhatHanhBUS = new DotPhatHanhBUS();
        }

        /// <summary>
        /// Khởi tạo để cập nhật đợt phát hành
        /// </summary>
        public FormEditDotPhatHanh(string maDotPhatHanh)
        {
            InitializeComponent();

            this.dotPhatHanhBUS = new DotPhatHanhBUS();

            try
            {
                this.dotPhatHanh = this.dotPhatHanhBUS.GetByMaDotPhatHanh(maDotPhatHanh);
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditDotPhatHanh_Load(object sender, EventArgs e)
        {
            if (this.dotPhatHanh == null)
                this.InsertLoad();
            else
                this.UpdateDotPhatHanh();
        }

        /// <summary>
        /// Hàm load để đợt phát hành
        /// </summary>
        public void InsertLoad()
        {
            this.dateEdit_NgayLap.EditValue = DateTime.Now;
        }

        /// <summary>
        /// Hàm load để cập nhật đợt phát hành
        /// </summary>
        public void EditLoad()
        {
            this.textEdit_TenDotPhatHanh.Text = this.dotPhatHanh.TenDotPhatHanh;
            this.dateEdit_NgayLap.Text = this.dotPhatHanh.NgayLap;
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            if (this.dotPhatHanh == null)
                this.InsertDotPhatHanh();
            else
                this.UpdateDotPhatHanh();
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Thêm đợt phát hành
        /// </summary>
        public void InsertDotPhatHanh()
        {
            try
            {
                this.dotPhatHanh = new DotPhatHanh(
                    string.Empty,
                    this.textEdit_TenDotPhatHanh.Text,
                    this.dateEdit_NgayLap.Text);

                this.dotPhatHanhBUS.Insert(this.dotPhatHanh);

                this.DialogResult = DialogResult.OK;

                XtraMessageBox.Show("Thêm Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.dotPhatHanh = null;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật loại vé
        /// </summary>
        public void UpdateDotPhatHanh()
        {
            try
            {
                this.dotPhatHanh = new DotPhatHanh(
                       this.dotPhatHanh.MaDotPhatHanh,
                       this.dotPhatHanh.TenDotPhatHanh,
                       this.dotPhatHanh.NgayLap);

                this.dotPhatHanhBUS.Update(this.dotPhatHanh);

                this.DialogResult = DialogResult.OK;

                XtraMessageBox.Show("Cập Nhật Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}