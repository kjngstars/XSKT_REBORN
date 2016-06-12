using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class DoiTacDAL : DBConnection
    {
        public DoiTacDAL() : base() { }

        public DataTable GetAllCT()
        {
            string query = @"SELECT * FROM DOITAC
                            WHERE MADOITAC LIKE 'CT%'";

            return this.getTable(query, string.Empty);
        }

        #region thêm đối tác
        public int Insert(string[] str)
        {
            if (connection.State != ConnectionState.Open) 
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = this.connection;
            command.CommandText = "sp_AddDoiTac";

            command.Parameters.AddWithValue("@pMaDoiTac", str[0]);
            command.Parameters.AddWithValue("@pTenDoiTac", str[1]);
            command.Parameters.AddWithValue("@pNgayTiepNhan", str[2]);
            command.Parameters.AddWithValue("@pDiaChi", str[3]);
            command.Parameters.AddWithValue("@pDienThoai", str[4]);
            command.Parameters.AddWithValue("@pEmail", str[5]);
            int rate = int.Parse(str[6]);
            float rateInterest = (float)rate / 100;
            rateInterest = (float)(Math.Round(rateInterest, 2));
            var hoaHong = rateInterest.ToString();
            command.Parameters.AddWithValue("@pTyLeHoaHong", hoaHong);

            var result = command.Parameters.Add("@Result", SqlDbType.VarChar);
            result.Direction = ParameterDirection.ReturnValue;

            command.ExecuteNonQuery();

            connection.Close();
            return (int)result.Value;
        }

        public void CreateProcedure()
        {
            string spDoiTac = "sp_AddDoiTac";
            string procedureInsertDoiTac = "CREATE PROC " + spDoiTac +
                "(@pMaDoiTac varchar(MAX), @pTenDoiTac nvarchar(MAX), @pNgayTiepNhan DateTime, @pDiaChi nvarchar(MAX), @pDienThoai varchar(MAX), @pEmail varchar(MAX), @pTyLeHoaHong Float) AS " +
                "BEGIN TRAN " +
                "INSERT INTO DOITAC (MADOITAC,TENDOITAC,NGAYTIEPNHAN,DIACHI,DIENTHOAI,EMAIL,TYLEHOAHONG)" +
                "VALUES (@pMaDoiTac,@pTenDoiTac,@pNgayTiepNhan,@pDiaChi,@pDienThoai,@pEmail,@pTyLeHoaHong)" +
                "DECLARE @pErrorCode int " +
                "SET @pErrorCode = @@ERROR " +
                "IF(@pErrorCode <> 0) " +
                 "BEGIN ROLLBACK TRAN RETURN -1 END " +
                "ELSE BEGIN COMMIT TRAN RETURN 1 END";
                                
            ExistOrCreateProcedure(spDoiTac, procedureInsertDoiTac);

        }

        public DataTable GetCongNoDoiTac()
        {
            string query = "SELECT MADOITAC AS \"MÃ ĐỐI TÁC\" , TENDOITAC AS \"TÊN ĐỐI TÁC\" , CONGNO AS \"CÔNG NỢ\" FROM DOITAC";
            var dt = getTable(query, "");
            return dt;
        }

        #endregion 
    }
}
