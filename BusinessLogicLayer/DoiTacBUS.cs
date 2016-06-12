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

        public void CreateProcedure()
        {
            doiTacDAL.CreateProcedure();
        }

        public int InsertDoiTac(DoiTacObject partner)
        {
            string[] data = { partner.MaDoiTac, partner.TenDoiTac, partner.GetDateTime(), partner.DiaChi, partner.DienThoai, partner.Email, partner.Rate.ToString() };
            return doiTacDAL.Insert(data);
        }

        public DataTable GetCongNoDoiTac()
        {
            return doiTacDAL.GetCongNoDoiTac();
        }
    }
}
