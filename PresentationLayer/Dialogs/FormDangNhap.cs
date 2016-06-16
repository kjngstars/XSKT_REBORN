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
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS taikhoanBUS = new TaiKhoanBUS();
            MainForm.user = taikhoanBUS.DangNhap(textEdit_TenDangNhap.Text, textEdit_MatKhau.Text);
            if(MainForm.user.TenDangNhap == null)
            {
                XtraMessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Chính Xác!\n\nNếu có vấn đề về tài khoản xin liên hệ với người quản trị.", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                XtraMessageBox.Show("Đăng Nhập Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}