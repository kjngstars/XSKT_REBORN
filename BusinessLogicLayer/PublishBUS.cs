using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PublishBUS
    {
        PublishDAL publish = new PublishDAL();

        public DataTable GetAllPublishPlan()
        {
            return publish.GetAllPublishPlan();
        }
    }
}
