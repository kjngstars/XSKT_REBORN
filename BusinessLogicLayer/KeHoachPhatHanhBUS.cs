using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class KeHoachPhatHanhBUS
    {
        private KeHoachPhatHanhDAL KeHoachPhatHanhDAL = null;

        public KeHoachPhatHanhBUS()
        {
            this.KeHoachPhatHanhDAL = new KeHoachPhatHanhDAL();
        }

        public DataTable GetAll()
        {
            return this.KeHoachPhatHanhDAL.GetAll();
        }

        public string Insert(KeHoachPhatHanh KeHoachPhatHanh)
        {
            string[] parameters = new string[5];

            parameters[0] = KeHoachPhatHanh.MaChiTietDotPhatHanh;
            parameters[1] = KeHoachPhatHanh.MaDotPhatHanh;
            parameters[2] = KeHoachPhatHanh.MaDoiTac;
            parameters[3] = KeHoachPhatHanh.MaLoaiVe;
            parameters[4] = KeHoachPhatHanh.SoVePhatHanh.ToString();
            return this.KeHoachPhatHanhDAL.Insert(parameters);
        }

        public void Update(KeHoachPhatHanh KeHoachPhatHanh)
        {
            string[] parameters = new string[5];

            parameters[0] = KeHoachPhatHanh.MaChiTietDotPhatHanh;
            parameters[1] = KeHoachPhatHanh.MaDotPhatHanh;
            parameters[2] = KeHoachPhatHanh.MaDoiTac;
            parameters[3] = KeHoachPhatHanh.MaLoaiVe;
            parameters[4] = KeHoachPhatHanh.SoVePhatHanh.ToString();
            this.KeHoachPhatHanhDAL.Update(parameters);
        }

        public void Delete(string maKeHoachPhatHanh)
        {
            this.KeHoachPhatHanhDAL.Delete(maKeHoachPhatHanh);
        }
    }
}
