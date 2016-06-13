using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseAcessLayer
{
    public class PhieuThu_DAL : DBConnection
    {
        public string Insert(DateTime ngayLap, string maDoiTac, string maDotPhatHanh, decimal soTienThu)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"PHIEUTHU_INSERT";

            cmd.Parameters.Add("@p_MAPHIEUTHU", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MAPHIEUTHU"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p_NGAYLAP", ngayLap.ToString());
            cmd.Parameters.Add("@p_MADOITAC", maDoiTac);
            cmd.Parameters.Add("@p_MADOTPHATHANH",maDotPhatHanh);
            cmd.Parameters.Add("@p_SOTIENTHU", soTienThu);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MAPHIEUTHU"].Value.ToString();
        }
    }
}
