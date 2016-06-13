using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using PresentationLayer.Dialogs;
using DevExpress.Skins;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static TaiKhoan user = null;
        DoiTacBUS partner = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AddSkin();
            this.SetSkin(Properties.Settings.Default.SkinName);
            partner = new DoiTacBUS();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.SkinName = this.defaultLookAndFeel.LookAndFeel.SkinName;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Nạp danh sách SkinName vào repositoryItemComboBox_Skin 
        /// </summary>
        public void AddSkin()
        {
            SkinContainerCollection skinContainerCollection = SkinManager.Default.Skins;
            foreach (SkinContainer skinContainer in skinContainerCollection)
                this.repositoryItemComboBox_Skin.Items.Add(skinContainer.SkinName);

            if (Properties.Settings.Default.SkinName != string.Empty)
                this.barEditItem_Skin.EditValue = Properties.Settings.Default.SkinName;
            else
                this.barEditItem_Skin.EditValue = this.defaultLookAndFeel.LookAndFeel.SkinName;
        }

        /// <summary>
        /// Set Skin
        /// </summary>
        public void SetSkin(string skinName)
        {
            if (skinName != string.Empty)
                this.defaultLookAndFeel.LookAndFeel.SkinName = skinName;
        }

        private void barEditItem_Skin_EditValueChanged(object sender, EventArgs e)
        {
            this.SetSkin(this.barEditItem_Skin.EditValue.ToString());
        }

        /// <summary>
        /// Kiểm tra tab tồn tại chưa
        /// </summary>
        public bool CheckExist(XtraForm form)
        {
            foreach (XtraForm child in this.MdiChildren)
            {
                if (form.Name == child.Name)
                {
                    child.Activate();
                    child.Show();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Thêm tab Danh sách loại vé
        /// </summary>
        private void barButtonItem_DanhSachLoaiVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDanhSachLoaiVe form = new FormDanhSachLoaiVe();

            if (!this.CheckExist(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Mở form thêm loại vé
        /// </summary>
        private void barButtonItem_ThemLoaiVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEditLoaiVe form = new FormEditLoaiVe();

            if (form.DialogResult != DialogResult.Abort)
                form.ShowDialog();
        }

        /// <summary>
        /// Thêm tab Danh sách cơ cấu giải thưởng
        /// </summary>
        private void barButtonItem_DanhSachCCGT_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDanhSachCCGT form = new FormDanhSachCCGT();

            if (!this.CheckExist(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Mở form thêm CCGT
        /// </summary>
        private void barButtonItem_ThemCCGT_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEditCCGT form = new FormEditCCGT();

            if (form.DialogResult != DialogResult.Abort)
                form.ShowDialog();
        }

        /// <summary>
        /// Mở form ghi nhận KQSX
        /// </summary>
        private void barButtonItem_GhiNhanKQXS_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormGhiNhanKQXS form = new FormGhiNhanKQXS();

            if (form.DialogResult != DialogResult.Abort)
                form.ShowDialog();
        }

        /// <summary>
        /// Thêm tab Tra cứu KQSX
        /// </summary>
        private void barButtonItem_TraCuuKQXS_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormTraCuuKQXS form = new FormTraCuuKQXS();

            if (!this.CheckExist(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem_DanhSachDoiTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDanhSachDaiLy f = new FormDanhSachDaiLy();

            if (!this.CheckExist(f)) 
            {
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_TiepNhanDoiTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new FormThemDoiTac();
            f.Show();
        }

        private void barButtonItem_PhieuDangKyVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new FormDangKyNhanVe();
            f.Show();
        }

        /// <summary>
        /// Thêm tab danh sách đợt phát hành
        /// </summary>
        private void barButtonItem_DanhSachDotPhatHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDanhSachDotPhatHanh form = new FormDanhSachDotPhatHanh();

            if (!this.CheckExist(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Mở form thêm đợt phát hành
        /// </summary>
        private void barButtonItem_ThemDotPhatHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEditDotPhatHanh form = new FormEditDotPhatHanh();

            if (form.DialogResult != DialogResult.Abort)
                form.ShowDialog();
        }

        private void barButtonItem_BaoCaoCongNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var dt = partner.GetCongNoDoiTac();

            //ReportingManager rp = new ReportingManager(new ReportCongNo(), dt);

            //rp.ShowReportPreview();
        }

        /// <summary>
        /// Thêm tab Danh sách tài khoản
        /// </summary>
        
        private void barButtonItem_DanhSachTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDanhSachTaiKhoan form = new FormDanhSachTaiKhoan();

            if (!this.CheckExist(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Mở form đổi mật khẩu
        /// </summary>
        private void barButtonItem_DoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEditMatKhau form = new FormEditMatKhau();
            if (form.DialogResult != DialogResult.Abort)
            {
                form.ShowDialog();              
            }
        }

        /// <summary>
        /// Mở form đăng nhập
        /// </summary>
        private void barButtonItem_DangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDangNhap form = new FormDangNhap();
            if (form.DialogResult != DialogResult.Abort)
            {
                form.ShowDialog();
            }
        }

        private void barButtonItem_PhieuNhanVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormPhieuNhanVe form = new FormPhieuNhanVe();
            if (form.DialogResult != DialogResult.Abort)
            {
                form.ShowDialog();
            }
        }

        private void barButtonItem_PhieuTraVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormPhieuTraVe form = new FormPhieuTraVe();
            if (form.DialogResult != DialogResult.Abort)
            {
                form.ShowDialog();
            }
        }

       

        private void barButtonItem_PhieuThanhToan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormPhieuThu();
            if (form.DialogResult != DialogResult.Abort)
            {
                form.ShowDialog();
            }
        }

        private void barButtonItem_LapKeHoachPhatHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new FormLapKeHoachPhatHanh();
            if (form.DialogResult != DialogResult.Abort)
            {
                form.ShowDialog();
            }
        }
    }
}