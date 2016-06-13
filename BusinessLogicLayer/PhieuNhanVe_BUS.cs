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

    public class PhieuNhanVe_BUS
    {
        PhieuNhanVe_DAL phieuNhanVe_dal = new PhieuNhanVe_DAL();

        public string Insert_PhieuNhanVe(string maPhieuNhanVe,string ngayLap, string maDoiTac, string maDotPhatHanh)
        {
            return phieuNhanVe_dal.Insert_PhieuNhanVe( maPhieuNhanVe,ngayLap,  maDoiTac,  maDotPhatHanh);
        }

        public string Insert_chiTietPhieuNhanVe(string MAPHIEUNHANVE, string MALOAIVE, int SOLUONG)
        {
            return phieuNhanVe_dal.Insert_chiTietPhieuNhanVe(MAPHIEUNHANVE, MALOAIVE, SOLUONG);
        }


        // lấy ra toàn bộ mã đối tác
        public DataTable get_TableMaDoiTac()
        {
            return phieuNhanVe_dal.getTable("select MaDoiTac from DOITAC");
        }

        // lấy ra 1 mã đối tác từ 1 tên đối tác
        public DataTable get_MaDoiTac(String tenDoiTac)
        {
            return phieuNhanVe_dal.getTable("select MaDoiTac from DOITAC  where TenDoiTac = N'" + tenDoiTac + "'");
        }


        // lấy ra toàn bộ tên đối tác
        public DataTable get_TenDoiTac(String MaDoitac)
        {

            return phieuNhanVe_dal.getTable("select TenDoiTac from DOITAC where MaDoiTac ='" + MaDoitac + "'");


        }

        // lấy ra 1 tên đối tác từ mà đối tác
        public DataTable get_TableTenDoiTac()
        {

            return phieuNhanVe_dal.getTable("select TenDoiTac from DOITAC ");


        }



        // lấy ra 1 mã vé từ bảng LoaiVe
        public DataTable get_MaveTuDPH(String MaDotPhatHanh)
        {
            return phieuNhanVe_dal.getTable("select distinct  lv.MALOAIVE,TenLoaiVe from CHITIETDOTPHATHANH ctph,LOAIVE lv where lv.MALOAIVE=N'" + MaDotPhatHanh + "'");
            //return phieuNhanVe_dal.getTable("select distinct  lv.MALOAIVE,TenLoaiVe from CHITIETDOTPHATHANH ctph,LOAIVE lv where lv.MALOAIVE=ctph.MALOAIVE and lv.MALOAIVE='LV0000000000001'");
        }

        // lấy Chi tiet phieu nhan ve tu madotphathanh va madoitat
        public DataTable get_CTPhieuNhanVe(string MaDotPhatHanh, string MaDoiTac)
        {
            string s = @"select * 
                       from CHITIETPHIEUNHANVE ctpnv,PHIEUNHANVE pnv ,LOAIVE lv
                       where ctpnv.MAPHIEUNHANVE = pnv.MAPHIEUNHANVE and ctpnv.MALOAIVE = lv.MALOAIVE and pnv.MADOITAC = '" + MaDoiTac + "' and pnv.MADOTPHATHANH = '" + MaDotPhatHanh + "'";
            return phieuNhanVe_dal.getTable(s);
        }

        // lấy Chi tiet phieu nhan ve tu madotphathanh va madoitat
        public DataTable seachPhieuNhanVeByMaDotPhatHanhMaDoiTac(string MaDotPhatHanh, string MaDoiTac)
        {
            string s = @"select * 
                       from PHIEUNHANVE pnv
                       where pnv.MADOITAC = '" + MaDoiTac + "' and pnv.MADOTPHATHANH = '" + MaDotPhatHanh + "'";
            return phieuNhanVe_dal.getTable(s);
        }

        // lấy ra 1 table mã vé từ bảng LoaiVe
        public DataTable get_TableMaVe()
        {
            return phieuNhanVe_dal.getTable("select MaLoaiVe from LoaiVe ");
        }

        // lấy ra 1 tên vé từ bảng LoaiVe
        public DataTable get_Tenve(String MaLoaiVe)
        {
            return phieuNhanVe_dal.getTable("select TenLoaiVe from LoaiVe where MaLoaiVe = '" + MaLoaiVe + "'");
        }

        // lấy ra 1 table tên vé từ bảng LoaiVe
        public DataTable get_TableTenVe()
        {
            return phieuNhanVe_dal.getTable("select TenLoaiVe from LoaiVe ");
        }



        // lấy ra 1 mã đợt phát hành từ bảng Dot phat hanh
        public DataTable get_MaDotPhatHanh(String TenDotPhatHanh)
        {
            return phieuNhanVe_dal.getTable("select MADOTPHATHANH from DOTPHATHANH where TENDOTPHATHANH = N'" + TenDotPhatHanh + "'");
        }

        // lấy ra 1 table mã đợt phát hành từ bảng Dotphat hành
        public DataTable get_TableMaDotPhatHanh()
        {
            return phieuNhanVe_dal.getTable("select MADOTPHATHANH from DOTPHATHANH ");
        }

        // lấy ra 1 tên đợt phát hành từ bảng Dot phat hanh
        public DataTable get_TenDotPhatHanh(String MaDotPhatHanh)
        {
            return phieuNhanVe_dal.getTable("select TENDOTPHATHANH from DOTPHATHANH where MADOTPHATHANH = '" + MaDotPhatHanh + "'");
        }

        // lấy ra 1 table mã đợt phát hành từ bảng Dotphat hành
        public DataTable get_TableTenDotPhatHanh()
        {
            return phieuNhanVe_dal.getTable("select TENDOTPHATHANH from DOTPHATHANH ");
        }


    }
}
