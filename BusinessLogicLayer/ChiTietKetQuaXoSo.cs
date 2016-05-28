using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ChiTietKetQuaXoSo
    {
        public string MaKetQuaXoSo { get; set; }
        public string MaGiaiThuong { get; set; }
        public string Ve { get; set; }

        public ChiTietKetQuaXoSo(
            string maKetQuaXoSo,
            string maGiaiThuong,
            string ve)
        {
            this.MaKetQuaXoSo = maKetQuaXoSo;
            this.MaGiaiThuong = maGiaiThuong;
            this.Ve = ve;
        }
    }
}
