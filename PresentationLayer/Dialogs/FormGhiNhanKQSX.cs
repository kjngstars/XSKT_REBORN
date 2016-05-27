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
    public partial class FormGhiNhanKQSX : DevExpress.XtraEditors.XtraForm
    {
        private LoaiVeBUS loaiVeBUS = null;

        public FormGhiNhanKQSX()
        {
            InitializeComponent();

            this.loaiVeBUS = new LoaiVeBUS();
        }

        private void FormGhiNhanKQSX_Load(object sender, EventArgs e)
        {
            this.FillLoaiVe();
        }

        /// <summary>
        /// Nạp danh sách loại vé của công ty
        /// </summary>
        public void FillLoaiVe()
        {
            try
            {
                DataTable dataTable = this.loaiVeBUS.GetLoaiVeCT();

                foreach(DataRow row in dataTable.Rows)
                {
                    LoaiVe loaiVe = new LoaiVe(row);

                    this.repositoryItemComboBox_LoaiVe.Items.Add(loaiVe);
                }
            }
            catch(Exception ex)
            {
                this.DialogResult = DialogResult.Abort;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}