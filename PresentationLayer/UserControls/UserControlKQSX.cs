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
using BusinessLogicLayer;

namespace PresentationLayer.UserControls
{
    public struct TextEditVe
    {
        public string MaGiaiThuong;
        public TextEdit TextEdit;

        public TextEditVe(string maGiaiThuong, TextEdit textEdit)
        {
            this.MaGiaiThuong = maGiaiThuong;
            this.TextEdit = textEdit;
        }
    }

    public partial class UserControlKQSX : DevExpress.XtraEditors.XtraUserControl
    {
        private List<TextEditVe> listTextEditVe = null;

        public List<TextEditVe> ListTextEditVe
        {
            get { return this.listTextEditVe; }
        }

        private int textEditWidth = 75;

        [Description("TextEdit Width"), Category("Other")]
        public int TextEditWidth
        {
            get { return this.textEditWidth; }
            set { this.textEditWidth = value; }
        }


        public UserControlKQSX()
        {
            InitializeComponent();

            this.listTextEditVe = new List<TextEditVe>();
        }

        public void CreateComponentControls(DataTable table)
        {
            this.Controls.Clear();
            this.listTextEditVe.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.AddLabelControl(table.Rows[i], new Point(12, 12 + i * 24));

                this.AddTextEdit(table.Rows[i], new Point(150, 10 + i * 24));
            }
        }

        public void AddLabelControl(DataRow row, Point location)
        {
            LabelControl labelControl = new LabelControl();

            labelControl.Name = row["MAGIAITHUONG"].ToString();
            labelControl.Text = row["TENGIAITHUONG"].ToString();
            labelControl.Location = location;

            this.Controls.Add(labelControl);
        }

        public void AddTextEdit(DataRow row, Point location)
        {
            string maGiaiThuong = row["MAGIAITHUONG"].ToString();
            int soChuSoTrung = int.Parse(row["SOCHUSOTRUNG"].ToString());
            int soLanQuay = 0;
            try
            {
                soLanQuay = int.Parse(row["SOLANQUAY"].ToString());
            }
            catch (Exception ex) { }

            for (int i = 0; i < soLanQuay; i++)
            {
                TextEdit textEdit = new TextEdit();

                textEdit.Name = maGiaiThuong + i;
                textEdit.Location = new Point(location.X + i * 80, location.Y);
                textEdit.Width = this.textEditWidth;
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                textEdit.Properties.Mask.EditMask = @"\d{" + soChuSoTrung + @"}";
                textEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
                textEdit.Properties.MaxLength = soChuSoTrung;

                this.listTextEditVe.Add(new TextEditVe(maGiaiThuong, textEdit));
                this.Controls.Add(textEdit);
            }
        }

        public List<ChiTietKetQuaXoSo> GetListChiTietKetQuaXoSo(string maKetQuaXoSo)
        {
            List<ChiTietKetQuaXoSo> result = new List<ChiTietKetQuaXoSo>();

            for (int i = 0; i < this.listTextEditVe.Count; i++)
            {
                string format = @"{0:" + new string('0', this.listTextEditVe[i].TextEdit.Properties.MaxLength) + "}";
                string ve = String.Format(format, this.listTextEditVe[i].TextEdit.Text);

                if (ve == string.Empty)
                    ve = new string('0', this.listTextEditVe[i].TextEdit.Properties.MaxLength);

                if (i == 0)
                {
                    result.Add(new ChiTietKetQuaXoSo(
                        maKetQuaXoSo,
                        this.listTextEditVe[i].MaGiaiThuong,
                        ve));
                }
                else
                {
                    if (this.listTextEditVe[i - 1].MaGiaiThuong == this.listTextEditVe[i].MaGiaiThuong)
                        result[result.Count - 1].Ve += @"-" + ve;
                    else
                        result.Add(new ChiTietKetQuaXoSo(
                        maKetQuaXoSo,
                        this.listTextEditVe[i].MaGiaiThuong,
                        ve));
                }
            }

            return result;
        }
    }
}
