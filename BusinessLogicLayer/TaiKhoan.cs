using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class TaiKhoan
    {
        public string MaTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public QuyenHan quyenHan { get; set; }
        public TaiKhoan(string MaTaiKhoan,
            string TenDangNhap,
            string MatKhau,
            string quyenHan)
        {
            this.MaTaiKhoan = MaTaiKhoan;
            this.TenDangNhap = TenDangNhap;          
            this.MatKhau = MatKhau;

            switch (quyenHan)
            {
                case "0":
                case "Admin":
                    this.quyenHan = QuyenHan.Admin;
                    break;
                case "1":
                case "User":
                    this.quyenHan = QuyenHan.User;
                    break;
                default:
                    this.quyenHan = QuyenHan.Anonymous;
                    break;
            }
        }

        public TaiKhoan(DataRow row)
        {
            this.MaTaiKhoan = row["MATAIKHOAN"].ToString();
            this.TenDangNhap = row["TENDANGNHAP"].ToString();
            this.MatKhau = row["MATKHAU"].ToString();

            switch (row["QUYENHAN"].ToString())
            {
                case "0":
                case "Admin":
                    this.quyenHan = QuyenHan.Admin;
                    break;
                case "1":
                case "User":
                    this.quyenHan = QuyenHan.User;
                    break;
                default:
                    this.quyenHan = QuyenHan.Anonymous;
                    break;
            }
        }
        public override string ToString()
        {
            return this.TenDangNhap;
        }
    }
}
