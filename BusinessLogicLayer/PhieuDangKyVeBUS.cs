using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PhieuDangKyVeBUS
    {
        PhieuDangKyVeDAL registerTicket = new PhieuDangKyVeDAL();

        public void CreateProcedure()
        {
            registerTicket.CreateProcedure();
        }

        public int RegisterTicket(string[] str)
        {
            return registerTicket.RegisterTicket(str);
        }

        public DataTable GetLoaiVeInformation()
        {
            return registerTicket.GetLoaiVeInfo();
        }

        public void InsertTicketDetailRegister(List<RegisterDetailObject> listDetail)
        {
            foreach (RegisterDetailObject detail in listDetail)
            {
                string[] str = {detail.RegisterID,detail.MaLoaiVe, detail.Quantity.ToString()};
                registerTicket.InsertDetailRegister(str);
            }      
        }
    }
}
