using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class KeHoachPhatHanh
    {
        public string MaChiTietDotPhatHanh { get; set; }
        public string MaDotPhatHanh { get; set; }
        public string MaDoiTac { get; set; }
        public string MaLoaiVe { get; set; }

        public int SoVePhatHanh { get; set; }
        public KeHoachPhatHanh(string maChiTietDotPhatHanh, string maDotPhatHanh, string maDoiTac, string maLoaiVe, int soVePhatHanh)
        {
            this.MaChiTietDotPhatHanh = maChiTietDotPhatHanh;
            this.MaDotPhatHanh = MaDotPhatHanh;
            this.MaDoiTac = maDoiTac;
            this.MaLoaiVe = maLoaiVe;
            this.SoVePhatHanh = soVePhatHanh;
        }

        public KeHoachPhatHanh(DataRow dataRow)
        {
            this.MaChiTietDotPhatHanh = dataRow["MACHITIETDOTPHATHANH"].ToString(); 
            this.MaDotPhatHanh = dataRow["MADOTPHATHANH"].ToString();
            this.MaDoiTac = dataRow["MADOITAC"].ToString(); 
            this.MaLoaiVe = dataRow["MALOAIVE"].ToString(); 
            this.SoVePhatHanh = int.Parse(dataRow["SOVEPHATHANH"].ToString()); 
        }

        public override string ToString()
        {
            return this.MaChiTietDotPhatHanh;
        }
    }
}
