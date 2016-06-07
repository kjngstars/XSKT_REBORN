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
using PresentationLayer.Dialogs;

namespace PresentationLayer
{
    public partial class FormDanhSachDotPhatHanh : DevExpress.XtraEditors.XtraForm
    {
        private DotPhatHanhBUS dotPhatHanhBUS = null;

        public FormDanhSachDotPhatHanh()
        {
            InitializeComponent();
        }

        private void FormDanhSachDotPhatHanh_Load(object sender, EventArgs e)
        {
            this.dotPhatHanhBUS = new DotPhatHanhBUS();
        }

        private void FormDanhSachDotPhatHanh_Shown(object sender, EventArgs e)
        {
            try
            {
                this.gridControl.DataSource = this.dotPhatHanhBUS.GetAll();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem_Them_Click(object sender, EventArgs e)
        {
            FormEditDotPhatHanh form = new FormEditDotPhatHanh();
            form.ShowDialog();
            this.gridControl.DataSource = this.dotPhatHanhBUS.GetAll();
        }


        private void toolStripMenuItem_CapNhat_Click(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle >= 0)
            {
                string maDotPhatHanh = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MADOTPHATHANH"].ToString();

                FormEditDotPhatHanh form = new FormEditDotPhatHanh(maDotPhatHanh);
                if (form.DialogResult != DialogResult.Abort)
                {
                    form.ShowDialog();
                    this.gridControl.DataSource = this.dotPhatHanhBUS.GetAll();
                }
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {

            if (this.gridView.FocusedRowHandle >= 0)
            {
                string maDotPhatHanh = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MADOTPHATHANH"].ToString();

                FormEditDotPhatHanh form = new FormEditDotPhatHanh(maDotPhatHanh);
                if (form.DialogResult != DialogResult.Abort)
                {
                    form.ShowDialog();
                    this.gridControl.DataSource = this.dotPhatHanhBUS.GetAll();
                }
            }
        }

        private void toolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle >= 0)
            {
                string maDotPhatHanh = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MADOTPHATHANH"].ToString();

                try
                {
                    this.dotPhatHanhBUS.Delete(maDotPhatHanh);

                    this.gridControl.DataSource = this.dotPhatHanhBUS.GetAll();

                    XtraMessageBox.Show(@"Xóa Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}