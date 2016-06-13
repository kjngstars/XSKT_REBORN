using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAcessLayer;
using System.Data;


namespace BusinessLogicLayer
{
    public class DoiTacBUS
    {
        private DoiTacDAL doiTacDAL = null;

        public DoiTacBUS()
        {
            this.doiTacDAL = new DoiTacDAL();
        }

        public DataTable GetAll_CT()
        {
            return this.doiTacDAL.GetAllCT();
        }
        public DataTable GetAll()
        {
            return this.doiTacDAL.GetAll();
        }
        public DataTable GetDoiTacByMaDotPhatHanh(string maDotPhatHanh)
        {
            return this.doiTacDAL.GetDoiTacByMaDotPhatHanh(maDotPhatHanh);
        }

        public void CreateProcedure()
        {
            doiTacDAL.CreateProcedure();
        }

        public int InsertDoiTac(DoiTacObject partner)
        {
            string[] data = { partner.MaDoiTac, partner.TenDoiTac, partner.GetDateTime(), partner.DiaChi, partner.DienThoai, partner.Email, partner.Rate.ToString(),partner.CongNo.ToString() };
            return doiTacDAL.Insert(data);
        }
        public DoiTac GetDoiTacByMaDoiTac(string maDoiTac)
        {
            DataRow dataRow = this.doiTacDAL.GetDoiTacByMaDoiTac(maDoiTac);

            return new DoiTac(dataRow);
    }
        public DoiTac GetDoiTacByMaDoiTacMaDotPhatHanh(string maDoiTac,string maDotPhatHanh)
        {
            DataRow dataRow = this.doiTacDAL.GetDoiTacByMaDoiTacMaDotPhatHanh(maDoiTac,maDotPhatHanh);

            return new DoiTac(dataRow);
        }

        public string GetTongCongNo()
        {
            return doiTacDAL.SumaryCongNo();
        }
    }
}

