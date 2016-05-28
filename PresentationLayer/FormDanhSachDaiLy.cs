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
        private static FormDanhSachDaiLy instance = null;

        public static FormDanhSachDaiLy Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormDanhSachDaiLy();
                    return instance;
                }
                return instance;
            }
        }

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

        public void RefreshTable()
        {
            var dtTable = agencyFiles.GetDanhSachDaiLy();
            gcDanhSachDaiLy.DataSource = dtTable;
        }

    }
}
