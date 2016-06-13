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
    public partial class FormEditThongTinTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private TaiKhoan taiKhoan = null;
        private TaiKhoanBUS taiKhoanBUS = null;

        public FormEditThongTinTaiKhoan()
        {
            InitializeComponent();
            this.taiKhoanBUS = new TaiKhoanBUS();
        }

        /// <summary>
        /// Khởi tạo để cập nhật loại vé
        /// </summary>
        public FormEditThongTinTaiKhoan(string maTaiKhoan)
        {
            InitializeComponent();

            this.taiKhoanBUS = new TaiKhoanBUS();

            try
            {
                this.taiKhoan = this.taiKhoanBUS.GetTaiKhoanByMaTaiKhoan(maTaiKhoan);
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            comboBoxEdit_QuyenHan.Properties.Items.Add(QuyenHan.Admin);
            comboBoxEdit_QuyenHan.Properties.Items.Add(QuyenHan.User);
            comboBoxEdit_QuyenHan.Properties.Items.Add(QuyenHan.Anonymous);
            if (this.taiKhoan != null)
            {
                this.textEdit_TenDangNhap.Text = this.taiKhoan.TenDangNhap;
                this.textEdit_MatKhau.Text = this.taiKhoan.MatKhau;
                this.comboBoxEdit_QuyenHan.SelectedItem = taiKhoan.quyenHan;
            }
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            if (this.taiKhoan == null)
                this.InsertTaiKhoan();
            else
                this.UpdateTaiKhoan();
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Thêm tài khoản
        /// </summary>
        public void InsertTaiKhoan()
        {
            try
            {
                this.taiKhoan = new TaiKhoan(
                    string.Empty,
                    this.textEdit_TenDangNhap.Text,
                    this.textEdit_MatKhau.Text,
                    this.comboBoxEdit_QuyenHan.Text);

                this.taiKhoan.MaTaiKhoan = this.taiKhoanBUS.Insert(this.taiKhoan);

                this.DialogResult = DialogResult.OK;

                XtraMessageBox.Show("Thêm Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.taiKhoan = null;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật tài khoản
        /// </summary>
        public void UpdateTaiKhoan()
        {
            try
            {
                this.taiKhoan = new TaiKhoan(
                    this.taiKhoan.MaTaiKhoan,
                    this.textEdit_TenDangNhap.Text,
                    this.textEdit_MatKhau.Text,
                    this.comboBoxEdit_QuyenHan.Text);

                this.taiKhoanBUS.Update(this.taiKhoan);

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