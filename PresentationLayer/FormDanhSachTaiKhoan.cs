using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;
using PresentationLayer.Dialogs;
using DevExpress.XtraEditors.Repository;

namespace PresentationLayer
{
    public partial class FormDanhSachTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private TaiKhoanBUS TaiKhoanBUS = null;
        public FormDanhSachTaiKhoan()
        {
            InitializeComponent();
        }
        private void FormDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            this.TaiKhoanBUS = new TaiKhoanBUS();
        }

        private void FormDanhSachTaiKhoan_Shown(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = this.TaiKhoanBUS.GetAll();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    switch (dt.Rows[i][3].ToString())
                    {
                        case "0":
                            dt.Rows[i][3] = "Admin";
                            break;
                        case "1":
                            dt.Rows[i][3] = "User";
                            break;
                        default:
                            dt.Rows[i][3] = "Anonymous";
                            break;
                    }
                }
                this.gridControl.DataSource = dt;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem_Them_Click(object sender, EventArgs e)
        {
            FormEditThongTinTaiKhoan form = new FormEditThongTinTaiKhoan();
            form.ShowDialog();
            try
            {
                DataTable dt = this.TaiKhoanBUS.GetAll();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    switch (dt.Rows[i][3].ToString())
                    {
                        case "0":
                            dt.Rows[i][3] = "Admin";
                            break;
                        case "1":
                            dt.Rows[i][3] = "User";
                            break;
                        default:
                            dt.Rows[i][3] = "Anonymous";
                            break;
                    }
                }
                this.gridControl.DataSource = dt;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem_CapNhat_Click(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle >= 0)
            {
                string maTaiKhoan = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MATaiKhoan"].ToString();

                FormEditThongTinTaiKhoan form = new FormEditThongTinTaiKhoan(maTaiKhoan);
                if (form.DialogResult != DialogResult.Abort)
                {
                    form.ShowDialog();

                    try
                    {
                        DataTable dt = this.TaiKhoanBUS.GetAll();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            switch (dt.Rows[i][3].ToString())
                            {
                                case "0":
                                    dt.Rows[i][3] = "Admin";
                                    break;
                                case "1":
                                    dt.Rows[i][3] = "User";
                                    break;
                                default:
                                    dt.Rows[i][3] = "Anonymous";
                                    break;
                            }
                        }
                        this.gridControl.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.gridView.FocusedRowHandle >= 0)
            {
                string maTaiKhoan = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MATaiKhoan"].ToString();

                FormEditThongTinTaiKhoan form = new FormEditThongTinTaiKhoan(maTaiKhoan);// maTaiKhoan);
                if (form.DialogResult != DialogResult.Abort)
                {
                    form.ShowDialog();

                    try
                    {
                        DataTable dt = this.TaiKhoanBUS.GetAll();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            switch (dt.Rows[i][3].ToString())
                            {
                                case "0":
                                    dt.Rows[i][3] = "Admin";
                                    break;
                                case "1":
                                    dt.Rows[i][3] = "User";
                                    break;
                                default:
                                    dt.Rows[i][3] = "Anonymous";
                                    break;
                            }
                        }
                        this.gridControl.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle >= 0)
            {
                string maTaiKhoan = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MATaiKhoan"].ToString();

                try
                {
                    this.TaiKhoanBUS.Delete(maTaiKhoan);

                    try
                    {
                        DataTable dt = this.TaiKhoanBUS.GetAll();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            switch (dt.Rows[i][3].ToString())
                            {
                                case "0":
                                    dt.Rows[i][3] = "Admin";
                                    break;
                                case "1":
                                    dt.Rows[i][3] = "User";
                                    break;
                                default:
                                    dt.Rows[i][3] = "Anonymous";
                                    break;
                            }
                        }
                        this.gridControl.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    XtraMessageBox.Show(@"Xóa Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}