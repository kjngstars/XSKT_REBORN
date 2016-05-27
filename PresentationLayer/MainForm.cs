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

namespace PresentationLayer
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AddSkin();
            this.SetSkin(Properties.Settings.Default.SkinName);
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
            {
                this.defaultLookAndFeel.LookAndFeel.SkinName = skinName;

                Properties.Settings.Default.SkinName = skinName;
            }
            else
                Properties.Settings.Default.SkinName = this.defaultLookAndFeel.LookAndFeel.SkinName;

            Properties.Settings.Default.Save();
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
            form.ShowDialog();
        }


    }
}