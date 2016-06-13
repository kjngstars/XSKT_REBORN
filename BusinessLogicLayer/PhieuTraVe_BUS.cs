using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DatabaseAcessLayer;

namespace BusinessLogicLayer
{

    public class PhieuTraVe_BUS
    {
        PhieuTraVe_DAL PhieuTraVe_dal = new PhieuTraVe_DAL();

        public string Insert_PhieuTraVe(string maPhieuTraVe,string ngayLap, string maDoiTac, string maDotPhatHanh)
        {
            return PhieuTraVe_dal.Insert_PhieuTraVe( maPhieuTraVe,ngayLap,  maDoiTac,  maDotPhatHanh);
        }

        public string Insert_chiTietPhieuTraVe(string MAPhieuTraVe, string MALOAIVE, int SOLUONG)
        {
            return PhieuTraVe_dal.Insert_chiTietPhieuTraVe(MAPhieuTraVe, MALOAIVE, SOLUONG);
        }


        // lấy ra toàn bộ mã đối tác
        public DataTable get_TableMaDoiTac()
        {
            return PhieuTraVe_dal.getTable("select MaDoiTac from DOITAC");
        }

        // lấy ra 1 mã đối tác từ 1 tên đối tác
        public DataTable get_MaDoiTac(String tenDoiTac)
        {
            return PhieuTraVe_dal.getTable("select MaDoiTac from DOITAC  where TenDoiTac = N'" + tenDoiTac + "'");
        }


        // lấy ra toàn bộ tên đối tác
        public DataTable get_TenDoiTac(String MaDoitac)
        {

            return PhieuTraVe_dal.getTable("select TenDoiTac from DOITAC where MaDoiTac ='" + MaDoitac + "'");


        }

        // lấy ra 1 tên đối tác từ mà đối tác
        public DataTable get_TableTenDoiTac()
        {

            return PhieuTraVe_dal.getTable("select TenDoiTac from DOITAC ");


        }



        // lấy ra 1 mã vé từ bảng LoaiVe
        public DataTable get_MaveTuDPH(String MaDotPhatHanh)
        {
            //return PhieuTraVe_dal.getTable("select distinct  lv.MALOAIVE,TenLoaiVe from CHITIETDOTPHATHANH ctph,LOAIVE lv where lv.MALOAIVE=N'" + MaDotPhatHanh + "'");
            return PhieuTraVe_dal.getTable("select distinct  lv.MALOAIVE,TenLoaiVe from CHITIETDOTPHATHANH ctph,LOAIVE lv where lv.MALOAIVE=ctph.MALOAIVE and lv.MALOAIVE='LV0000000000001'");
        }

        // lấy Chi tiet phieu tra ve tu madotphathanh va madoitat
        public DataTable seachPhieuTraVeByMaDotPhatHanhMaDoiTac(string MaDotPhatHanh, string MaDoiTac)
        {
            string s = @"select * 
                       from PHIEUTRAVE pnv
                       where pnv.MADOITAC = '" + MaDoiTac + "' and pnv.MADOTPHATHANH = '" + MaDotPhatHanh + "'";
            return PhieuTraVe_dal.getTable(s);
        }

        // lấy ra 1 table mã vé từ bảng LoaiVe
        public DataTable get_TableMaVe()
        {
            return PhieuTraVe_dal.getTable("select MaLoaiVe from LoaiVe ");
        }

        // lấy ra 1 tên vé từ bảng LoaiVe
        public DataTable get_Tenve(String MaLoaiVe)
        {
            return PhieuTraVe_dal.getTable("select TenLoaiVe from LoaiVe where MaLoaiVe = '" + MaLoaiVe + "'");
        }

        // lấy ra 1 table tên vé từ bảng LoaiVe
        public DataTable get_TableTenVe()
        {
            return PhieuTraVe_dal.getTable("select TenLoaiVe from LoaiVe ");
        }



        // lấy ra 1 mã đợt phát hành từ bảng Dot phat hanh
        public DataTable get_MaDotPhatHanh(String TenDotPhatHanh)
        {
            return PhieuTraVe_dal.getTable("select MADOTPHATHANH from DOTPHATHANH where TENDOTPHATHANH = N'" + TenDotPhatHanh + "'");
        }

        // lấy ra 1 table mã đợt phát hành từ bảng Dotphat hành
        public DataTable get_TableMaDotPhatHanh()
        {
            return PhieuTraVe_dal.getTable("select MADOTPHATHANH from DOTPHATHANH ");
        }

        // lấy ra 1 tên đợt phát hành từ bảng Dot phat hanh
        public DataTable get_TenDotPhatHanh(String MaDotPhatHanh)
        {
            return PhieuTraVe_dal.getTable("select TENDOTPHATHANH from DOTPHATHANH where MADOTPHATHANH = '" + MaDotPhatHanh + "'");
        }

        // lấy ra 1 table mã đợt phát hành từ bảng Dotphat hành
        public DataTable get_TableTenDotPhatHanh()
        {
            return PhieuTraVe_dal.getTable("select TENDOTPHATHANH from DOTPHATHANH ");
        }


    }
}
