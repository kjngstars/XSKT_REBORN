using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class PhieuTraVe_DAL : DBConnection
    {
        public string Insert_chiTietPhieuTraVe(string MAPHIEUTRAVE, string MALOAIVE, int SOLUONG)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"CHITIETPHIEUTRAVE_INSERT";

            cmd.Parameters.Add("@P_MAPHIEUTRAVE", MAPHIEUTRAVE);
            cmd.Parameters.Add("@P_MALOAIVE", MALOAIVE);
            cmd.Parameters.Add("@p_SOLUONGTRA", SOLUONG);

            cmd.ExecuteNonQuery();

            connection.Close();

            return "";// cmd.Parameters["@p_MACHITIETPHIEUTRAVE"].Value.ToString();
        }

        public string Insert_PhieuTraVe(string maPhieuTraVe ,string ngayLap, string maDoiTac, string maDotPhatHanh)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"PHIEUTRAVE_INSERT";

            cmd.Parameters.Add("@p_MAPHIEUTRAVE", maPhieuTraVe);
            cmd.Parameters.Add("@p_NGAYLAP", ngayLap);
            cmd.Parameters.Add("@p_MADOITAC", maDoiTac);
            cmd.Parameters.Add("@P_MADOTPHATHANH", maDotPhatHanh);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MAPHIEUTRAVE"].Value.ToString();
        }
    }
}
