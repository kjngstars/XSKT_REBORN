using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class PublishDAL : DBConnection
    {
        public DataTable GetAllPublishPlan()
        {
            string query = "SELECT * FROM DOTPHATHANH";
            return getTable(query, "");
        }
    }
}
