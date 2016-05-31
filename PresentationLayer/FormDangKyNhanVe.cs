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
using System.Text.RegularExpressions;

namespace PresentationLayer
{
    public partial class FormDangKyNhanVe : DevExpress.XtraEditors.XtraForm
    {
        DoiTacBUS doiTacBUS = new DoiTacBUS();
        PhieuDangKyVeBUS registerTicket = new PhieuDangKyVeBUS();
        PublishBUS publish = new PublishBUS();
        public FormDangKyNhanVe()
        {
            InitializeComponent();
        }

        private void FormDangKyVe_Load(object sender, EventArgs e)
        {
            deDate.DateTime = DateTime.Now;
            registerTicket.CreateProcedure();

            var tableInfoLoaiVe = registerTicket.GetLoaiVeInformation();
            if (tableInfoLoaiVe != null) 
            {
                FillGridControlLoaiVe(tableInfoLoaiVe);
            }

            var tableDoiTac = FormDanhSachDaiLy.Instance.GetDoiTacTable();
            if (tableDoiTac != null)
            {
                FillDanhSachDoiTac(tableDoiTac);
            }

            var tableDotPhatHanh = publish.GetAllPublishPlan();
            if (tableDotPhatHanh != null) 
            {
                FillDotPhatHanh(tableDotPhatHanh);
            }
        }

        private void FillGridControlLoaiVe(DataTable tableLoaiVe)
        {
            gridControlLoaiVe.DataSource = tableLoaiVe;
        }

        //void LoadLoaiVe(DataTable tableLoaiVe)
        //{
        //    var count = tableLoaiVe.Rows.Count;
        //    double height = 50.0;
        //    for (int i = 0; i < count; i++)
        //    {
        //        RowDefinition row = new RowDefinition();
        //        row.SizeType = SizeType.Absolute;
        //        row.Height = height;
        //        layoutControlGroupLoaiVe.OptionsTableLayoutGroup.Add(row);
                
        //        loai ve
        //        LayoutControlItem item = layoutControlLoaiVe.Root.AddItem();
        //        item.SizeConstraintsType = SizeConstraintsType.Custom;
        //        item.MaxSize = new Size(0, 50);
        //        item.OptionsTableLayoutItem.RowIndex = i;
        //        LabelControl label = new LabelControl();
        //        label.Text = tableLoaiVe.Rows[i]["TENLOAIVE"].ToString();
        //        label.Font = new System.Drawing.Font(label.Font.FontFamily, 15.0f);
        //        item.Control = label;
        //        item.TextVisible = false;

        //        so luong
        //        LayoutControlItem item2 = layoutControlLoaiVe.Root.AddItem();
        //        item2.SizeConstraintsType = SizeConstraintsType.Custom;
        //        item2.MaxSize = new Size(0, 50);
        //        item2.OptionsTableLayoutItem.RowIndex = i;
        //        item2.OptionsTableLayoutItem.ColumnIndex = 1;
        //        item2.Text = "Số Lượng";
        //        item2.AppearanceItemCaption.Font = new System.Drawing.Font(item2.AppearanceItemCaption.Font.FontFamily, 15.0f);

        //        TextEdit textEdit = new TextEdit();
        //        textEdit.Dock = DockStyle.Fill;
        //        textEdit.Font = new Font(textEdit.Font.FontFamily, 15.0f);
        //        todo: set mask for textedit

        //        item2.Control = textEdit;
        //    }
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var dateRegister = deDate.DateTime.ToString("yyyy-MM-dd HH:mm:ss");
                var registerID = GenerateMaDangKy("REG", deDate.DateTime);
                var partnerID = lookUpEditDoiTac.EditValue.ToString();
                var publishID = lookUpEditPublish.EditValue.ToString();

                string[] str = { registerID, dateRegister, partnerID, publishID };

                var succeed = registerTicket.RegisterTicket(str);

                if (succeed == 1)
                {

                    List<RegisterDetailObject> registerDetail = new List<RegisterDetailObject>();
                    DataView dt = (DataView)gridView1.DataSource;
                    foreach (DataRow item in dt.Table.Rows)
                    {
                        var value = int.Parse(item["SOLUONG"].ToString());
                        if (value > 0)
                        {
                            var maLoaiVe = item["MALOAIVE"].ToString();
                            registerDetail.Add(new RegisterDetailObject { RegisterID = registerID, MaLoaiVe = maLoaiVe, Quantity = value });
                            
                        }                        
                    }
                    //chi tiet dang ky ve
                    registerTicket.InsertTicketDetailRegister(registerDetail);

                    XtraMessageBox.Show(@"Đăng ký nhận thành công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(@"Lỗi " + ex.Message, @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        void FillDanhSachDoiTac(DataTable table)
        {

            lookUpEditDoiTac.Properties.DataSource = table;
            lookUpEditDoiTac.Properties.DisplayMember = "TENDOITAC";
            lookUpEditDoiTac.Properties.ValueMember = "MADOITAC";

            lookUpEditDoiTac.Properties.Columns.Add(new LookUpColumnInfo("TENDOITAC", 0, "Tên Đối Tác"));
            lookUpEditDoiTac.Properties.Columns.Add(new LookUpColumnInfo("MADOITAC", 0, "Mã Đối Tác"));

            lookUpEditDoiTac.Properties.SearchMode = SearchMode.AutoComplete;
            lookUpEditDoiTac.Properties.AutoSearchColumnIndex = 1;

        }

        void FillDotPhatHanh(DataTable table)
        {
            lookUpEditPublish.Properties.DataSource = table;
            lookUpEditPublish.Properties.DisplayMember = "TENDOTPHATHANH";
            lookUpEditPublish.Properties.ValueMember = "MADOTPHATHANH";

            lookUpEditPublish.Properties.Columns.Add(new LookUpColumnInfo("TENDOTPHATHANH", 0, "Tên Đối Tác"));
            lookUpEditPublish.Properties.Columns.Add(new LookUpColumnInfo("NGAYLAP", 0, "Ngày Phát Hành"));

            lookUpEditPublish.Properties.SearchMode = SearchMode.AutoComplete;
            lookUpEditPublish.Properties.AutoSearchColumnIndex = 1;

        }

        String GenerateMaDangKy(string prefix, DateTime dt)
        {
            string id = prefix;
            id += dt.Month.ToString() + dt.Day.ToString(); 
            var time =  dt.ToString("HH:mm:ss");
            var convert = Regex.Replace(time, "[: ]", "");
            id += convert;
            return id;
        }
    }
}