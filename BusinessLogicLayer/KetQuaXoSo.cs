using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class KetQuaXoSo
    {
        public string MaKetQuaXoSo { get; set; }
        public string NgayMoThuong { get; set; }
        public string MaLoaiVe { get; set; }

        public KetQuaXoSo(
            string maKetQuaXoSo,
            string ngayMoThuong,
            string maLoaiVe)
        {
            this.MaKetQuaXoSo = maKetQuaXoSo;
            this.NgayMoThuong = ngayMoThuong;
            this.MaLoaiVe = maLoaiVe;
        }
    }
}
