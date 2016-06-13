using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DotPhatHanh
    {
        public string MaDotPhatHanh { get; set; }
        public string TenDotPhatHanh { get; set; }
        public string NgayLap { get; set; }

        public DotPhatHanh(string maDotPhatHanh,
            string tenDotPhatHanh, string ngayLap)
        {
            this.MaDotPhatHanh = maDotPhatHanh;
            this.TenDotPhatHanh = tenDotPhatHanh;
            this.NgayLap = ngayLap;
        }

        public DotPhatHanh(DataRow dataRow)
        {
            this.MaDotPhatHanh = dataRow["MADOTPHATHANH"].ToString();
            this.TenDotPhatHanh = dataRow["TENDOTPHATHANH"].ToString();
            this.NgayLap = dataRow["NGAYLAP"].ToString();
        }

        public override string ToString()
        {
            return this.TenDotPhatHanh;
        }
    }
}
