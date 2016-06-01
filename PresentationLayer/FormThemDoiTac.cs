using BusinessLogicLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormThemDoiTac : XtraForm
    {
        DoiTacBUS partnerBUS = new DoiTacBUS();
        public FormThemDoiTac()
        {
            InitializeComponent();
        }
        
        private void FormThemDoiTac_Load(object sender, EventArgs e)
        {
            //create all store procedure if not exist
            partnerBUS.CreateProcedure();

            deDate.EditValue = DateTime.Now;
            btnThemDoiTac.Enabled = false;  
        }

        private void btnThemDoiTac_Click(object sender, EventArgs e)
        {
            try
            {
                
                DoiTacObject partner = new DoiTacObject { TenDoiTac = teTenDoiTac.Text, NgayTiepNhan = deDate.DateTime, DiaChi = teDiaChi.Text, DienThoai = teDienThoai.Text, Email = teEmail.Text, Rate = int.Parse(teRate.Text) };

                var prefix = (string)checkedListCompany.SelectedValue;
                var id = GenerateID(prefix, partner.NgayTiepNhan);
                partner.MaDoiTac = id;

                int succeed = partnerBUS.InsertDoiTac(partner);

                if (succeed == 1)
                {
                    XtraMessageBox.Show(@"Thêm thành công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh status
                    Reset();
                    FormDanhSachDaiLy.Instance.RefreshTable();
                    
                }

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(@"Lỗi: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region helper method

        //auto generate new id function for partner
        string GenerateID(string prefix,DateTime date)
        {
            string id = prefix;
            var dt = date.ToString("yyyy-MM-dd HH:mm:ss");
            var convert = Regex.Replace(dt, "[-: ]", "");
            id += convert;
            return id;
        }

        void Reset()
        {
            btnThemDoiTac.Enabled = false;
            deDate.DateTime = DateTime.Now;
            teTenDoiTac.Text = "";
            teDiaChi.Text = "";
            teDienThoai.Text = "";
            teEmail.Text = "";
            teRate.Text = "";
        }

        #endregion

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListCompany_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State != CheckState.Checked) return;
            CheckedListBoxControl lb = sender as CheckedListBoxControl;
            for (int i = 0; i < lb.ItemCount; i++)
            {
                if (i != e.Index)
                    lb.SetItemChecked(i, false);
            }
        }

        #region validate user input
        private void te_Validating(object sender, CancelEventArgs e)
        {
            TextEdit te = (TextEdit)sender;
            if (te.Text == "") 
            {
                e.Cancel = true;
            }
            
        }

        private void te_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
            e.ErrorText = "Không được để trống";
            
        }


        #endregion

        void Validation()
        {
            bool name = teTenDoiTac.Text != "" ? true : false;
            bool address = teDiaChi.Text != "" ? true : false;
            bool phone = teDienThoai.Text != "" ? true : false;
            bool email = teEmail.Text != "" ? true : false;
            bool commission = teRate.Text != "" ? true : false;

            if (name && address && phone && email && commission) 
            {
                btnThemDoiTac.Enabled = true;
            }
            else
            {
                btnThemDoiTac.Enabled = false;
            }
        }

        private void te_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

    }
}
