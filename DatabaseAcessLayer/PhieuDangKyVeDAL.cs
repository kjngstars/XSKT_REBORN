using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class PhieuDangKyVeDAL : DBConnection
    {
        public void CreateProcedure()
        {
            //dang ky ve procedure
            string spPhieuDKV = "sp_PhieuDangKyVe";
            string procedure = "CREATE PROC " + spPhieuDKV +
                                "(@id varchar(max), @date DateTime, @partnerID varchar(max),@publishID varchar(max)) AS" +
                                " BEGIN TRAN" +
                                " INSERT INTO PHIEUDANGKYVE(MAPHIEUDANGKYVE, NGAYLAP, MADOITAC, MADOTPHATHANH)" +
                                " VALUES(@id,@date,@partnerID,@publishID)" +
                                " DECLARE @pErrorCode int" +
                                " SET @pErrorCode = @@ERROR" +
                                " IF(@pErrorCode <> 0) " +
                                " BEGIN ROLLBACK TRAN RETURN -1 END" +
                                " ELSE BEGIN COMMIT TRAN RETURN 1 END";


            ExistOrCreateProcedure(spPhieuDKV, procedure);

            //chi tiet dang ky ve procedure
            string spChiTietDKV = "sp_ChiTietDKV";
            procedure = "CREATE PROC " + spChiTietDKV +
                    "(@idRegister varchar(max), @maloaive varchar(max), @quantity int) AS " +
                    "BEGIN TRAN " +
                    "INSERT INTO CHITIETPHIEUDANGKYVE(MAPHIEUDANGKYVE, MALOAIVE, SOLUONGDANGKY) " +
                    "VALUES(@idRegister,@maloaive,@quantity) " +
                    "DECLARE @pErrorCode int " +
                    "SET @pErrorCode = @@ERROR " +
                    "IF(@pErrorCode <> 0) " +
                    "BEGIN ROLLBACK TRAN RETURN -1 END " +
                    "ELSE BEGIN COMMIT TRAN RETURN 1 END";

            ExistOrCreateProcedure(spChiTietDKV, procedure);
        }
        public int RegisterTicket(string[] str)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = this.connection;
            command.CommandText = "sp_PhieuDangKyVe";

            command.Parameters.AddWithValue("@id", str[0]);
            command.Parameters.AddWithValue("@date", str[1]);
            command.Parameters.AddWithValue("@partnerID", str[2]);
            command.Parameters.AddWithValue("@publishID", str[3]);


            var result = command.Parameters.Add("@Result", SqlDbType.VarChar);
            result.Direction = ParameterDirection.ReturnValue;

            command.ExecuteNonQuery();

            connection.Close();
            return (int)result.Value;
        }
        public DataTable GetLoaiVeInfo()
        {
            string query = "SELECT LOAIVE.MALOAIVE, LOAIVE.TENLOAIVE, LOAIVE.MENHGIA, " + 
                "DOITAC.TENDOITAC, 0 AS SOLUONG "+ 
                "FROM LOAIVE LEFT JOIN DOITAC ON " +
                "LOAIVE.MADOITAC=DOITAC.MADOITAC";  
          
            return getTable(query,"");            
        }

        public int InsertDetailRegister(string[] str)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = this.connection;
            command.CommandText = "sp_ChiTietDKV";

            command.Parameters.AddWithValue("@idRegister", str[0]);
            command.Parameters.AddWithValue("@maloaive", str[1]);
            command.Parameters.AddWithValue("@quantity", str[2]);

            var result = command.Parameters.Add("@Result", SqlDbType.VarChar);
            result.Direction = ParameterDirection.ReturnValue;

            command.ExecuteNonQuery();

            connection.Close();
            return (int)result.Value;
        }
    }
}
