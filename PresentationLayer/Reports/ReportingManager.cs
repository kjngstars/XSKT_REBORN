using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class ReportingManager
    {
        public XtraReport rep;
        public ReportingManager()
        {
        }

        public ReportingManager(XtraReport report, DataTable dt)
        {
            rep = report;
            
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            rep.DataSource = ds;
            InitBands(rep);
            InitStyles(rep);
            InitDetailsBasedonXRTable();
            
        }

        public void ShowReportPreview()
        {
            rep.ShowPreviewDialog();
        }

        public void InitStyles(XtraReport rep)
        {
            // Create different odd and even styles
            XRControlStyle oddStyle = new XRControlStyle();
            XRControlStyle evenStyle = new XRControlStyle();

            // Specify the odd style appearance
            oddStyle.BackColor = Color.WhiteSmoke;
            oddStyle.StyleUsing.UseBackColor = true;
            oddStyle.StyleUsing.UseBorders = false;
            oddStyle.Name = "OddStyle";

            // Specify the even style appearance
            evenStyle.BackColor = Color.White;
            evenStyle.StyleUsing.UseBackColor = true;
            evenStyle.StyleUsing.UseBorders = false;
            evenStyle.Name = "EvenStyle";

            // Add styles to report's style sheet
            rep.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] { oddStyle, evenStyle });
        }

        public void InitBands(XtraReport rep)
        {
            // Create bands
            DetailBand detail = new DetailBand();
            PageHeaderBand pageHeader = new PageHeaderBand();
            ReportFooterBand reportFooter = new ReportFooterBand();
            detail.Height = 40;
            reportFooter.Height = 380;
            pageHeader.Height = 20;

            // Place the bands onto a report
            rep.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] { detail, pageHeader, reportFooter });
        }
        public void InitDetailsBasedonXRTable()
        {
            DataSet ds = ((DataSet)rep.DataSource);
            int colCount = ds.Tables[0].Columns.Count;
            int colWidth = (rep.PageWidth - (rep.Margins.Left + rep.Margins.Right)) / colCount;
            
            // Create a table to represent headers
            XRTable tableHeader = new XRTable();
            tableHeader.Height = 25;
            tableHeader.Width = (rep.PageWidth - (rep.Margins.Left + rep.Margins.Right));
            tableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            tableHeader.Font = new Font(tableHeader.Font.FontFamily,12.0f, FontStyle.Bold);
            XRTableRow headerRow = new XRTableRow(); 
            headerRow.Width = tableHeader.Width;
            tableHeader.Rows.Add(headerRow);

            tableHeader.BeginInit();
            
            // Create a table to display data
            XRTable tableDetail = new XRTable();
            tableDetail.Height = 50;
            tableDetail.Width = (rep.PageWidth - (rep.Margins.Left + rep.Margins.Right));
            XRTableRow detailRow = new XRTableRow();
            detailRow.Width = tableDetail.Width;
            tableDetail.Rows.Add(detailRow);
            tableDetail.EvenStyleName = "EvenStyle";
            tableDetail.OddStyleName = "OddStyle";
            tableDetail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            tableDetail.Font = new Font(tableDetail.Font.FontFamily, 11.0f, FontStyle.Regular);
            tableDetail.BeginInit();

            // Create table cells, fill the header cells with text, bind the cells to data
            for (int i = 0; i < colCount; i++)
            {
                XRTableCell headerCell = new XRTableCell();
                headerCell.Width = colWidth;
                
                headerCell.Text = ds.Tables[0].Columns[i].Caption;
                
                XRTableCell detailCell = new XRTableCell();
                detailCell.Width = colWidth;
                detailCell.DataBindings.Add("Text", null, ds.Tables[0].Columns[i].Caption);

                if (ds.Tables[0].Columns[i].Caption == "TÊN ĐỐI TÁC")
                {
                    headerCell.Width = colWidth + 70;
                    detailCell.Width = colWidth + 70;
                }

                if (i == 0)
                {
                    headerCell.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
                    detailCell.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
                }
                else
                {
                    headerCell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                    detailCell.Borders = DevExpress.XtraPrinting.BorderSide.All;
                }

                // Place the cells into the corresponding tables
                headerRow.Cells.Add(headerCell);
                detailRow.Cells.Add(detailCell);
            }
            tableHeader.EndInit();
            tableDetail.EndInit();
            // Place the table onto a report's Detail band
            rep.Bands[BandKind.PageHeader].Controls.Add(tableHeader);
            rep.Bands[BandKind.Detail].Controls.Add(tableDetail);
            
        }
  
    }
}
