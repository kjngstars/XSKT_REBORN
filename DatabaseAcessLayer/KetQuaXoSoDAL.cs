using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class KetQuaXoSoDAL:DBConnection
    {
        public KetQuaXoSoDAL() : base() { }

        public string Insert(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"KETQUAXOSO_INSERT";

            cmd.Parameters.Add("@p_MAKETQUAXOSO", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MAKETQUAXOSO"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p_NGAYMOTHUONG", parameters[0]);
            cmd.Parameters.Add("@p_MALOAIVE", parameters[1]);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MAKETQUAXOSO"].Value.ToString();
        }
    }
}
