using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAcessLayer;
using System.Data;


namespace BusinessLogicLayer
{
    public class PhieuThu_BUS
    {
        PhieuThu_DAL phieuthu_dal = new PhieuThu_DAL();
        public DataTable getDSVe(string dotPhatHanh)
        {
            return phieuthu_dal.getTable(" select lv.MALOAIVE,lv.TENLOAIVE,lv.MENHGIA,ctpnv.SOLUONGNHAN from PHIEUNHANVE pnv,CHITIETPHIEUNHANVE ctpnv, LOAIVE lv " +
                                                " where pnv.MAPHIEUNHANVE=ctpnv.MAPHIEUNHANVE and lv.MALOAIVE =ctpnv.MALOAIVE and pnv.MADOTPHATHANH='" + dotPhatHanh + "'");

        }

        public DataTable getDSVe(string dotPhatHanh, string maDoiTac)
        {
            string s = @"select A.MALOAIVE,A.TENLOAIVE,A.MENHGIA,A.SOLUONGNHAN,B.SOLUONGTRA
                        from (select lv.MALOAIVE,lv.TENLOAIVE,lv.MENHGIA,ctpnv.SOLUONGNHAN           
                        from PHIEUNHANVE pnv,CHITIETPHIEUNHANVE ctpnv, LOAIVE lv,DOTPHATHANH dph
                        where pnv.MAPHIEUNHANVE=ctpnv.MAPHIEUNHANVE
                        and lv.MALOAIVE =ctpnv.MALOAIVE                                                                                                
                        and pnv.MADOTPHATHANH = dph.MADOTPHATHANH                                                                                                                                                                                              
                        and pnv.MADOITAC = '" + maDoiTac + @"'
                        and dph.MADOTPHATHANH='" + dotPhatHanh + @"') A
                        full outer join (select lv.MALOAIVE,lv.TENLOAIVE,lv.MENHGIA ,ctptv.SOLUONGTRA             
                        from LOAIVE lv, PHIEUTRAVE ptv,CHITIETPHIEUTRAVE ctptv,DOTPHATHANH dph
                        where                                                 
                         lv.MALOAIVE =ctptv.MALOAIVE                                                                                                 
                        and ptv.MADOTPHATHANH = dph.MADOTPHATHANH                                                  
                        and ptv.MAPHIEUTRAVE = ctptv.MAPHIEUTRAVE                                                  
                        and ptv.MADOITAC = '" + maDoiTac + @"'                                                  
                        and dph.MADOTPHATHANH='" + dotPhatHanh + @"') B
                        on A.MALOAIVE = B.MALOAIVE";
            return phieuthu_dal.getTable(s);

        }
        public string Insert(DateTime ngayLap, string maDoiTac, string maDotPhatHanh, decimal soTienThu)
        {
            return phieuthu_dal.Insert(ngayLap, maDoiTac, maDotPhatHanh, soTienThu);
        }
        public DataTable seachPhieuThuByMaDotPhatHanhMaDoiTac(string MaDotPhatHanh, string MaDoiTac)
        {
            string s = @"select * 
                       from PHIEUTHU pt
                       where pt.MADOITAC = '" + MaDoiTac + "' and pt.MADOTPHATHANH = '" + MaDotPhatHanh + "'";
            return phieuthu_dal.getTable(s);
        }
    }
}
