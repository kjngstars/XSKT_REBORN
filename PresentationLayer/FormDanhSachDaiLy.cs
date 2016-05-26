using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class FormDanhSachDaiLy : XtraForm
    {
        DanhSachDaiLyBUS agencyFiles = new DanhSachDaiLyBUS();
        public FormDanhSachDaiLy()
        {
            InitializeComponent();
        }

        private void FormDanhSachDaiLy_Load(object sender, EventArgs e)
        {
            var dtTable = agencyFiles.GetDanhSachDaiLy();
            gcDanhSachDaiLy.DataSource = dtTable;
            
        }


    }
}
