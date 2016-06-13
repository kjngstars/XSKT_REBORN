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
            string s = @" select lv.MALOAIVE,lv.TENLOAIVE,lv.MENHGIA,ctpnv.SOLUONGNHAN ,ctptv.SOLUONGTRA
                                            from PHIEUNHANVE pnv,CHITIETPHIEUNHANVE ctpnv, LOAIVE lv, PHIEUTRAVE ptv,CHITIETPHIEUTRAVE ctptv,DOTPHATHANH dph
                                            where pnv.MAPHIEUNHANVE=ctpnv.MAPHIEUNHANVE 
                                                    and lv.MALOAIVE =ctpnv.MALOAIVE 
                                                    and lv.MALOAIVE =ctptv.MALOAIVE 
                                                    and pnv.MADOTPHATHANH = dph.MADOTPHATHANH
                                                    and ptv.MADOTPHATHANH = dph.MADOTPHATHANH
                                                    and ptv.MAPHIEUTRAVE = ctptv.MAPHIEUTRAVE
                                                    and ptv.MADOITAC = '" + maDoiTac + @"'
                                                    and pnv.MADOITAC = '" + maDoiTac + @"'
                                                    and dph.MADOTPHATHANH='" + dotPhatHanh + "'";
            return phieuthu_dal.getTable(s);

        }
    }
}
