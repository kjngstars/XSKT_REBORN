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
using DevExpress.XtraLayout;
using DevExpress.XtraEditors.Controls;

namespace PresentationLayer
{
    public partial class FormDangKyNhanVe : DevExpress.XtraEditors.XtraForm
    {
        LoaiVeBUS loaiVeBUS = new LoaiVeBUS();
        DoiTacBUS doiTacBUS = new DoiTacBUS();
        public FormDangKyNhanVe()
        {
            InitializeComponent();
        }

        private void FormDangKyVe_Load(object sender, EventArgs e)
        {
            var tableLoaiVe = loaiVeBUS.GetAll();
            LoadLoaiVe(tableLoaiVe);
            deDate.DateTime = DateTime.Now;

            var tableDoiTac = FormDanhSachDaiLy.Instance.GetDoiTacTable();
            if (tableDoiTac != null) 
            {
                //FillComboBox(tableDoiTac);
            }
        }

        void LoadLoaiVe(DataTable tableLoaiVe)
        {
            var count = tableLoaiVe.Rows.Count;
            double height = 50.0;
            for (int i = 0; i < count; i++)
            {
                RowDefinition row = new RowDefinition();
                row.SizeType = SizeType.Absolute;
                row.Height = height;
                layoutControlGroupLoaiVe.OptionsTableLayoutGroup.Add(row);

                //loai ve
                LayoutControlItem item = layoutControlLoaiVe.Root.AddItem();
                item.SizeConstraintsType = SizeConstraintsType.Custom;
                item.MaxSize = new Size(0, 50);
                item.OptionsTableLayoutItem.RowIndex = i;                
                LabelControl label = new LabelControl();
                label.Text = tableLoaiVe.Rows[i]["TENLOAIVE"].ToString();
                label.Font = new System.Drawing.Font(label.Font.FontFamily, 15.0f);
                item.Control = label;
                item.TextVisible = false;
                
                //so luong
                LayoutControlItem item2 = layoutControlLoaiVe.Root.AddItem();
                item2.SizeConstraintsType = SizeConstraintsType.Custom;
                item2.MaxSize = new Size(0, 50);
                item2.OptionsTableLayoutItem.RowIndex = i;
                item2.OptionsTableLayoutItem.ColumnIndex = 1;
                item2.Text = "Số Lượng";
                item2.AppearanceItemCaption.Font = new System.Drawing.Font(item2.AppearanceItemCaption.Font.FontFamily, 15.0f);

                TextEdit textEdit = new TextEdit();
                textEdit.Dock = DockStyle.Fill;
                textEdit.Font = new Font(textEdit.Font.FontFamily, 15.0f);
                //todo: set mask for textedit

                item2.Control = textEdit;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

        }

        void FillComboBox(DataTable table)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource=table;

            for (int i = 0; i < table.Rows.Count; i++)
            {                

                lookUpEditDoiTac.Properties.DataSource = table;
                lookUpEditDoiTac.Properties.DisplayMember = "TENDOITAC";
                lookUpEditDoiTac.Properties.ValueMember = "MADOITAC";

                //add column to collection
                LookUpColumnInfoCollection col = lookUpEditDoiTac.Properties.Columns;

                col.Add(new LookUpColumnInfo("MADOITAC",0));
                col.Add(new LookUpColumnInfo("TENDOITAC", 0));

                lookUpEditDoiTac.Properties.SearchMode = SearchMode.AutoComplete;
                lookUpEditDoiTac.Properties.AutoSearchColumnIndex = 1;

            }
        }
    }
}