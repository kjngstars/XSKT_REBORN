using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class GiaiThuongDAL : DBConnection
    {
        public GiaiThuongDAL() : base() { }

        public string Insert(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"GIAITHUONG_INSERT";

            cmd.Parameters.Add("@p_MAGIAITHUONG", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MAGIAITHUONG"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p_TENGIAITHUONG", parameters[0]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameters[1]);
            cmd.Parameters.Add("@p_TRIGIA", parameters[2]);
            cmd.Parameters.Add("@p_SOLUONG", parameters[3]);
            cmd.Parameters.Add("@p_SOCHUSOTRUNG", parameters[4]);
            cmd.Parameters.Add("@p_SOLANQUAY", parameters[5]);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MAGIAITHUONG"].Value.ToString();
        }

        public void Update(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"GIAITHUONG_UPDATE";

            cmd.Parameters.Add("@p_MAGIAITHUONG", parameters[0]);
            cmd.Parameters.Add("@p_TENGIAITHUONG", parameters[1]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameters[2]);
            cmd.Parameters.Add("@p_TRIGIA", parameters[3]);
            cmd.Parameters.Add("@p_SOLUONG", parameters[4]);
            cmd.Parameters.Add("@p_SOCHUSOTRUNG", parameters[5]);
            cmd.Parameters.Add("@p_SOLANQUAY", parameters[6]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string maGiaiThuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"GIAITHUONG_DELETE";

            cmd.Parameters.Add("@p_MAGIAITHUONG", maGiaiThuong);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable GetByMaCoCauGiaiThuong(string maCoCauGiaiThuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"GIAITHUONG_SEARCHBYMACOCAUGIAITHUONG";

            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", maCoCauGiaiThuong);

            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(dataTable);

            connection.Close();

            return dataTable;
        }
    }
}
