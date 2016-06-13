using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class TaiKhoanDAL : DBConnection
    {
        public TaiKhoanDAL() : base() { }

        public DataTable GetAll()
        {
            string query = @"SELECT * FROM TAIKHOAN";

            return this.getTable(query, string.Empty);
        }

        public string Insert(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            switch (parameters[2])
            {
                case "Admin":
                    parameters[2] = "0";
                    break;
                case "User":
                    parameters[2] = "1";
                    break;
                default:
                    parameters[2] = "2";
                    break;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"TAIKHOAN_INSERT";

            cmd.Parameters.Add("@p_MATAIKHOAN", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MATAIKHOAN"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p_TENDANGNHAP", parameters[0]);
            cmd.Parameters.Add("@p_MATKHAU", parameters[1]);
            cmd.Parameters.Add("@p_QUYENHAN", parameters[2]);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MATAIKHOAN"].Value.ToString();
        }

        public void Update(string[] parameters)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            switch (parameters[3])
            {
                case "Admin":
                    parameters[3] = "0";
                    break;
                case "User":
                    parameters[3] = "1";
                    break;
                default:
                    parameters[3] = "2";
                    break;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"TAIKHOAN_UPDATE";

            cmd.Parameters.Add("@p_MATAIKHOAN", parameters[0]);
            cmd.Parameters.Add("@p_TENDANGNHAP", parameters[1]);
            cmd.Parameters.Add("@p_MATKHAU", parameters[2]);
            cmd.Parameters.Add("@p_QUYENHAN", parameters[3]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string maTaiKhoan)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"TAIKHOAN_DELETE";

            cmd.Parameters.Add("@p_MATAIKHOAN", maTaiKhoan);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public DataRow GetTaiKhoanByMaTaiKhoan(string maLoaiVe)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"TAIKHOAN_SEARCHBYMATAIKHOAN";

            cmd.Parameters.Add("@p_MATAIKHOAN", maLoaiVe);

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

        public DataRow GetByIDPass(string TenDangNhap, string MatKhau)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"TAIKHOAN_SEARCHBYTENDANGNHAPMATKHAU";

            cmd.Parameters.Add("@p_TENDANGNHAP", TenDangNhap);
            cmd.Parameters.Add("@p_MATKHAU", MatKhau);

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
