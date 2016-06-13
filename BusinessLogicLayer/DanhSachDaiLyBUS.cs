using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAcessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class DanhSachDaiLyBUS
    {
        DanhSachDaiLyDAL agencyFile = new DanhSachDaiLyDAL();

        public DataTable GetDanhSachDaiLy()
        {
            return agencyFile.GetDanhSachDaiLy();
        }
    }
}
