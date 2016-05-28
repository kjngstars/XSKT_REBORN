using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class KetQuaXoSoBUS
    {
        private KetQuaXoSoDAL ketQuaXoSoDAL = null;

        public KetQuaXoSoBUS()
        {
            this.ketQuaXoSoDAL = new KetQuaXoSoDAL();
        }

        public string Insert(KetQuaXoSo ketQuaXoSo)
        {
            string[] parameters = new string[2];

            parameters[0] = ketQuaXoSo.NgayMoThuong;
            parameters[1] = ketQuaXoSo.MaLoaiVe;

            return this.ketQuaXoSoDAL.Insert(parameters);
        }
    }
}
