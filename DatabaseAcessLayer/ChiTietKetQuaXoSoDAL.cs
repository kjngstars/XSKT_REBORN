using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class ChiTietKetQuaXoSoDAL : DBConnection
    {
        public ChiTietKetQuaXoSoDAL() : base() { }

        public void Insert(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"CHITIETKETQUAXOSO_INSERT";

            cmd.Parameters.Add("@p_MAKETQUAXOSO", parameters[0]);
            cmd.Parameters.Add("@p_MAGIAITHUONG", parameters[1]);
            cmd.Parameters.Add("@p_VE", parameters[2]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
