using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BusinessLogicLayer;

namespace PresentationLayer.Reports
{
    public partial class ReportCongNo : DevExpress.XtraReports.UI.XtraReport
    {
        DoiTacBUS partner = new DoiTacBUS();
        public ReportCongNo()
        {
            InitializeComponent();

            var sum =  partner.GetTongCongNo();
            SumaryLabel.Text = "TỔNG CỘNG : " + sum;
        }

    }
}
