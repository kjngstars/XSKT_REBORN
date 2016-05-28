using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PresentationLayer.UserControls
{
    public partial class UserControlTraCuuKQXS : DevExpress.XtraEditors.XtraUserControl
    {
        private int labelControlVeX = 200;

        [Description("LabelControlVeX"), Category("Other")]
        public int TextEditWidth
        {
            get { return this.labelControlVeX; }
            set { this.labelControlVeX = value; }
        }

        public UserControlTraCuuKQXS()
        {
            InitializeComponent();
        }

        public void CreateComponentControls(DataTable table)
        {
            this.Controls.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
                this.AddLabelControl(table.Rows[i], new Point(12, 12 + i * 30));
        }

        public void AddLabelControl(DataRow row, Point location)
        {
            LabelControl labelControlTenGiaiThuong = new LabelControl();
            LabelControl labelControlVe = new LabelControl();

            labelControlTenGiaiThuong.Text = row["TENGIAITHUONG"].ToString();
            labelControlTenGiaiThuong.Font = new Font("Tahoma", 10, FontStyle.Bold);
            labelControlTenGiaiThuong.Location = location;

            this.Controls.Add(labelControlTenGiaiThuong);

            labelControlVe.Text = row["VE"].ToString();
            labelControlVe.Font = new Font("Tahoma", 10, FontStyle.Bold);
            labelControlVe.Location = new Point(this.labelControlVeX, location.Y);

            this.Controls.Add(labelControlVe);
        }
    }
}
