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
    public class TaiKhoanBUS
    {

        private TaiKhoanDAL TaiKhoanDAL = null;

        public TaiKhoanBUS()
        {
            this.TaiKhoanDAL = new TaiKhoanDAL();
        }

        public DataTable GetAll()
        {
            return this.TaiKhoanDAL.GetAll();
        }


        public string Insert(TaiKhoan TaiKhoan)
        {
            string[] parameter = new string[3];

            parameter[0] = TaiKhoan.TenDangNhap;
            parameter[1] = TaiKhoan.MatKhau;
            parameter[2] = TaiKhoan.quyenHan.ToString();
            return this.TaiKhoanDAL.Insert(parameter);
        }

        public void Update(TaiKhoan TaiKhoan)
        {
            string[] parameter = new string[4];

            parameter[0] = TaiKhoan.MaTaiKhoan;
            parameter[1] = TaiKhoan.TenDangNhap;
            parameter[2] = TaiKhoan.MatKhau;
            parameter[3] = TaiKhoan.quyenHan.ToString();

            this.TaiKhoanDAL.Update(parameter);
        }

        public void Delete(string maTaiKhoan)
        {
            this.TaiKhoanDAL.Delete(maTaiKhoan);
        }
        public TaiKhoan GetTaiKhoanByMaTaiKhoan(string maTaiKhoan)
        {
            DataRow dataRow = this.TaiKhoanDAL.GetTaiKhoanByMaTaiKhoan(maTaiKhoan);

            return new TaiKhoan(dataRow);
        }
        public TaiKhoan DangNhap(string TenDangNhap, string MatKhau)
        {
            DataRow dataRow = this.TaiKhoanDAL.GetByIDPass(TenDangNhap, MatKhau);
            if (dataRow != null)
                return new TaiKhoan(dataRow);
            else
                return null;
        }

    }
}
