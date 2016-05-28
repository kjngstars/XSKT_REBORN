using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class LoaiVeDAL : DBConnection
    {
        public LoaiVeDAL() : base() { }

        public DataTable GetAll()
        {
            string query = @"SELECT MALOAIVE, TENLOAIVE, NGAYLAP, MENHGIA, TENDOITAC, MACOCAUGIAITHUONG
                            FROM LOAIVE AS loaive
                            LEFT JOIN DOITAC AS doitac
                            ON loaive.MADOITAC = doitac.MADOITAC";

            return this.getTable(query, string.Empty);
        }

        public string Insert(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_INSERT";

            cmd.Parameters.Add("@p_MALOAIVE", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MALOAIVE"].Direction= ParameterDirection.Output;
            cmd.Parameters.Add("@p_TENLOAIVE", parameters[0]);
            cmd.Parameters.Add("@p_NGAYLAP", parameters[1]);
            cmd.Parameters.Add("@p_MENHGIA", parameters[2]);
            cmd.Parameters.Add("@p_MADOITAC", parameters[3]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameters[4]);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MALOAIVE"].Value.ToString();
        }

        public void Update(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_UPDATE";

            cmd.Parameters.Add("@p_MALOAIVE", parameters[0]);
            cmd.Parameters.Add("@p_TENLOAIVE", parameters[1]);
            cmd.Parameters.Add("@p_NGAYLAP", parameters[2]);
            cmd.Parameters.Add("@p_MENHGIA", parameters[3]);
            cmd.Parameters.Add("@p_MADOITAC", parameters[4]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameters[5]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string maLoaiVe)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_DELETE";

            cmd.Parameters.Add("@p_MALOAIVE", maLoaiVe);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataRow GetLoaiVeByMaLoaiVe(string maLoaiVe)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_SEARCHBYMALOAIVE";

            cmd.Parameters.Add("@p_MALOAIVE", maLoaiVe);

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

        public DataTable GetLoaiVeCT()
        {
            string query = @"SELECT *
                            FROM LOAIVE
                            WHERE MADOITAC IS NULL";

            return this.getTable(query, string.Empty);
        }
    }
}
