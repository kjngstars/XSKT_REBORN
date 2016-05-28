using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ChiTietKetQuaXoSoBUS
    {
        private ChiTietKetQuaXoSoDAL chiTietKetQuaXoSoDAL = null;

        public ChiTietKetQuaXoSoBUS()
        {
            this.chiTietKetQuaXoSoDAL = new ChiTietKetQuaXoSoDAL();
        }
        public void Insert(ChiTietKetQuaXoSo chiTietKetQuaXoSo)
        {
            string[] parameters = new string[3];

            parameters[0] = chiTietKetQuaXoSo.MaKetQuaXoSo;
            parameters[1] = chiTietKetQuaXoSo.MaGiaiThuong;
            parameters[2] = chiTietKetQuaXoSo.Ve;

            this.chiTietKetQuaXoSoDAL.Insert(parameters);
        }
    }
}
