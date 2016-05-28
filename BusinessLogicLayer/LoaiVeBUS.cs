using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LoaiVeBUS
    {
        private LoaiVeDAL loaiVeDAL = null;

        public LoaiVeBUS()
        {
            this.loaiVeDAL = new LoaiVeDAL();
        }

        public DataTable GetAll()
        {
            return this.loaiVeDAL.GetAll();
        }


        public string Insert(LoaiVe loaiVe)
        {
            string[] parameters = new string[5];

            parameters[0] = loaiVe.TenLoaiVe;
            parameters[1] = loaiVe.NgayLap;
            parameters[2] = loaiVe.MenhGia.ToString();
            parameters[3] = loaiVe.MaDoiTac;
            parameters[4] = loaiVe.MaCoCauGiaiThuong;

            return this.loaiVeDAL.Insert(parameters);
        }

        public void Update(LoaiVe loaiVe)
        {
            string[] parameters = new string[6];

            parameters[0] = loaiVe.MaLoaiVe;
            parameters[1] = loaiVe.TenLoaiVe;
            parameters[2] = loaiVe.NgayLap;
            parameters[3] = loaiVe.MenhGia.ToString();
            parameters[4] = loaiVe.MaDoiTac;
            parameters[5] = loaiVe.MaCoCauGiaiThuong;

            this.loaiVeDAL.Update(parameters);
        }

        public void Delete(string maLoaiVe)
        {
            this.loaiVeDAL.Delete(maLoaiVe);
        }

        public LoaiVe GetLoaiVeByMaLoaiVe(string maLoaiVe)
        {
            DataRow dataRow = this.loaiVeDAL.GetLoaiVeByMaLoaiVe(maLoaiVe);

            return new LoaiVe(dataRow);
        }

        public DataTable GetLoaiVeCT()
        {
            return this.loaiVeDAL.GetLoaiVeCT();
        }
    }
}
