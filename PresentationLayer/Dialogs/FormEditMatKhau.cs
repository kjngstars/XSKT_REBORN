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
    public partial class FormEditMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FormEditMatKhau()
        {
            InitializeComponent();
        }
        private void FormEditMatKhau_Load(object sender, EventArgs e)
        {
            if (MainForm.user != null)
            {
                this.textEdit_TenDangNhap.Text = MainForm.user.TenDangNhap;
            }
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            UpdateMatKhau();
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Cập nhật tài khoản
        /// </summary>
        public void UpdateMatKhau()
        {
            TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
            TaiKhoan taiKhoan = taiKhoanBUS.DangNhap(this.textEdit_TenDangNhap.Text, this.textEdit_MatKhau.Text);
            if (taiKhoan == null)
            {
                XtraMessageBox.Show("Mật Khẩu Không Chính Xác!", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textEdit_MatKhauMoi.Text == textEdit_XacNhanMatKhau.Text)
                {

                    try
                    {
                        taiKhoan = new TaiKhoan(
                           MainForm.user.MaTaiKhoan,
                           this.textEdit_TenDangNhap.Text,
                           this.textEdit_MatKhauMoi.Text,
                           MainForm.user.quyenHan.ToString());


                        taiKhoanBUS.Update(taiKhoan);

                        this.DialogResult = DialogResult.OK;

                        XtraMessageBox.Show("Cập Nhật Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Mật Khẩu Không Khớp!", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}