using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class DotPhatHanhDAL : DBConnection
    {
        public DotPhatHanhDAL() : base() { }

        public DataTable GetAll()
        {
            string query = @"SELECT * FROM DOTPHATHANH";

            return this.getTable(query, string.Empty);
        }

        public string Insert(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"DOTPHATHANH_INSERT";

            cmd.Parameters.Add("@p_MADOTPHATHANH", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MADOTPHATHANH"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p_TENDOTPHATHANH", parameters[0]);
            cmd.Parameters.Add("@p_NGAYLAP", parameters[1]);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MADOTPHATHANH"].Value.ToString();
        }

        public void Update(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"DOTPHATHANH_UPDATE";

            cmd.Parameters.Add("@p_MADOTPHATHANH", parameters[0]);
            cmd.Parameters.Add("@p_TENDOTPHATHANH", parameters[1]);
            cmd.Parameters.Add("@p_NGAYLAP", parameters[2]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string maDotPhatHanh)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"DOTPHATHANH_DELETE";

            cmd.Parameters.Add("@p_MADOTPHATHANH", maDotPhatHanh);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataRow GetByMaDotPhatHanh(string maDotPhatHanh)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_SEARCHBYMADOTPHATHANH";

            cmd.Parameters.Add("@p_MADOTPHATHANH", maDotPhatHanh);

            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(dataTable);

            connection.Close();

            if (dataTable.Rows.Count > 0)
                return dataTable.Rows[0];
            else
                return null;
        }
    }
}
