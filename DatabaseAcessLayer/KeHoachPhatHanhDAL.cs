using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class KeHoachPhatHanhDAL : DBConnection
    {
        public KeHoachPhatHanhDAL() : base() { }

        public DataTable GetAll()
        {
            string query = @"SELECT * FROM ChiTietDotPhatHanh";

            return this.getTable(query, string.Empty);
        }

        public string Insert(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"CHITIETDOTPHATHANH_INSERT";

            cmd.Parameters.Add("@p_MACHITIETDOTPHATHANH", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MACHITIETDOTPHATHANH"].Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("@p_MACHITIETDOTPHATHANH", parameters[0]);
            cmd.Parameters.Add("@p_MADOTPHATHANH", parameters[1]);
            cmd.Parameters.Add("@p_MADOITAC", parameters[2]);
            cmd.Parameters.Add("@p_MALOAIVE", parameters[3]);
            cmd.Parameters.Add("@p_SOVEPHATHANH", parameters[4]);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MACHITIETDOTPHATHANH"].Value.ToString();
        }

        public void Update(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"CHITIETDOTPHATHANH_UPDATE";

            cmd.Parameters.Add("@p_MACHITIETDOTPHATHANH", parameters[0]);
            cmd.Parameters.Add("@p_MaDotPhatHanh", parameters[1]);
            cmd.Parameters.Add("@p_MaDoiTac", parameters[2]);
            cmd.Parameters.Add("@p_MaLoaiVe", parameters[3]);
            cmd.Parameters.Add("@p_SoVePhatHanh", parameters[4]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string maKeHoachPhatHanh)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"CHITIETDOTPHATHANH_DELETE";

            cmd.Parameters.Add("@p_MACHITIETDOTPHATHANH", maKeHoachPhatHanh);

            cmd.ExecuteNonQuery();

            connection.Close();
        }       
    }
}
