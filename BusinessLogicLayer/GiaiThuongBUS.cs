using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class GiaiThuongBUS
    {
        private GiaiThuongDAL giaiThuongDAL = null;

        public GiaiThuongBUS()
        {
            this.giaiThuongDAL = new GiaiThuongDAL();
        }

        public string Insert(GiaiThuong giaiThuong)
        {
            string[] parameters = new string[6];

            parameters[0] = giaiThuong.TenGiaiThuong;
            parameters[1] = giaiThuong.MaCoCauGiaiThuong;
            parameters[2] = giaiThuong.TriGia.ToString();
            parameters[3] = giaiThuong.SoLuong.ToString();
            parameters[4] = giaiThuong.SoChuSoTrung.ToString();
            if (giaiThuong.SoLanQuay != 0)
                parameters[5] = giaiThuong.SoLanQuay.ToString();

            return this.giaiThuongDAL.Insert(parameters);
        }

        public void Update(GiaiThuong giaiThuong)
        {
            string[] parameters = new string[7];

            parameters[0] = giaiThuong.MaGiaiThuong;
            parameters[1] = giaiThuong.TenGiaiThuong;
            parameters[2] = giaiThuong.MaCoCauGiaiThuong;
            parameters[3] = giaiThuong.TriGia.ToString();
            parameters[4] = giaiThuong.SoLuong.ToString();
            parameters[5] = giaiThuong.SoChuSoTrung.ToString();
            parameters[6] = giaiThuong.SoLanQuay.ToString();

            this.giaiThuongDAL.Update(parameters);
        }

        public void Delete(string maGiaiThuong)
        {
            this.giaiThuongDAL.Delete(maGiaiThuong);
        }

        public DataTable GetGiaiThuongByMaCoCauGiaiThuong(string maCoCauGiaiThuong)
        {
            return this.giaiThuongDAL.GetByMaCoCauGiaiThuong(maCoCauGiaiThuong);
        }
    }
}
