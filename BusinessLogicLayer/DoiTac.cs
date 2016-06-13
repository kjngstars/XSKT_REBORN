using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DoiTac
    {
        public string MaDoiTac { get; set; }
        public string TenDoiTac { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public float Rate { get; set; }

        public decimal CongNo { get; set; }

        public string GetDateTime()
        {
            return NgayTiepNhan.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public DoiTac(string MaDoiTac, string TenDoiTac)
        {
            this.MaDoiTac = MaDoiTac;
            this.TenDoiTac = TenDoiTac;
        }

        public DoiTac(DataRow row)
        {
            this.MaDoiTac = row["MADOITAC"].ToString();
            this.TenDoiTac = row["TENDOITAC"].ToString();
            this.NgayTiepNhan =DateTime.Parse(row["NGAYTIEPNHAN"].ToString());
            this.DiaChi = row["DIACHI"].ToString();
            this.DienThoai = row["DIENTHOAI"].ToString();
            this.Email = row["EMAIL"].ToString();
            this.Rate = float.Parse(row["TYLEHOAHONG"].ToString());
            this.CongNo = decimal.Parse(row["CONGNO"].ToString());
        }

        public override string ToString()
        {
            return this.TenDoiTac;
        }
    }
}
