using BusinessLogicLayer;
using DevExpress.XtraEditors;
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
        }

        private void btnThemDoiTac_Click(object sender, EventArgs e)
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
                FormDanhSachDaiLy.Instance.RefreshTable();
            }
            else
            {
                XtraMessageBox.Show(@"Thêm thất bại", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        #endregion

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
