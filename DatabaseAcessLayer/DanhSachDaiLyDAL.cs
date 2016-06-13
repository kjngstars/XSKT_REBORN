using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class DanhSachDaiLyDAL : DBConnection
    {
        public DataTable GetDanhSachDaiLy()
        {
            string query = "SELECT * FROM DOITAC";
            var dtTable = getTable(query, "");
            return dtTable;
        }
    }
}
