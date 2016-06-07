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
    public class DotPhatHanhBUS
    {
        private DotPhatHanhDAL dotPhatHanhDAL = null;

        public DotPhatHanhBUS()
        {
            this.dotPhatHanhDAL = new DotPhatHanhDAL();
        }

        public DataTable GetAll()
        {
            return this.dotPhatHanhDAL.GetAll();
        }

        public string Insert(DotPhatHanh dotPhatHanh)
        {
            string[] parameters = new string[2];

            parameters[0] = dotPhatHanh.TenDotPhatHanh;
            parameters[1] = dotPhatHanh.NgayLap;

            return this.dotPhatHanhDAL.Insert(parameters);
        }

        public void Update(DotPhatHanh dotPhatHanh)
        {
            string[] parameters = new string[3];

            parameters[0] = dotPhatHanh.MaDotPhatHanh;
            parameters[1] = dotPhatHanh.TenDotPhatHanh;
            parameters[2] = dotPhatHanh.NgayLap;

            this.dotPhatHanhDAL.Update(parameters);
        }

        public void Delete(string maDotPhatHanh)
        {
            this.dotPhatHanhDAL.Delete(maDotPhatHanh);
        }

        public DotPhatHanh GetByMaDotPhatHanh(string maDotPhatHanh)
        {
            DataRow dataRow = this.dotPhatHanhDAL.GetByMaDotPhatHanh(maDotPhatHanh);

            return new DotPhatHanh(dataRow);
        }
    }
}
