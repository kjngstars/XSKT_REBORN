using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class PhieuNhanVe_DAL : DBConnection
    {
        public string Insert_chiTietPhieuNhanVe(string MAPHIEUNHANVE, string MALOAIVE, int SOLUONG)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"CHITIETPHIEUNHANVE_INSERT";

            //cmd.Parameters.Add("@p_MACHITIETPHIEUNHANVE", SqlDbType.VarChar, 15);
           // cmd.Parameters["@p_MACHITIETPHIEUNHANVE"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@P_MAPHIEUNHANVE", MAPHIEUNHANVE);
            cmd.Parameters.Add("@P_MALOAIVE", MALOAIVE);
            cmd.Parameters.Add("@p_SOLUONGNHAN", SOLUONG);

            cmd.ExecuteNonQuery();

            connection.Close();

            return "";// cmd.Parameters["@p_MACHITIETPHIEUNHANVE"].Value.ToString();
        }

        public string Insert_PhieuNhanVe(string maPhieuNhanVe ,string ngayLap, string maDoiTac, string maDotPhatHanh)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"PHIEUNHANVE_INSERT";

            cmd.Parameters.Add("@p_MAPHIEUNHANVE", maPhieuNhanVe);
            cmd.Parameters.Add("@p_NGAYLAP", ngayLap);
            cmd.Parameters.Add("@p_MADOITAC", maDoiTac);
            cmd.Parameters.Add("@P_MADOTPHATHANH", maDotPhatHanh);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MAPHIEUNHANVE"].Value.ToString();
        }
    }
}
