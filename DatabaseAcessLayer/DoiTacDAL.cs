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
        public DataTable GetAll()
        {
            string query = @"SELECT * FROM DOITAC";

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
        #endregion 

        public DataTable GetDoiTacByMaDotPhatHanh(string maDotPhatHanh)
        {
            string query = @"SELECT DISTINCT  dt.MADOITAC,dt.TENDOITAC
                            FROM DOITAC dt, CHITIETDOTPHATHANH ctph
                            WHERE dt.MADOITAC = ctph.MADOITAC and ctph.MADOTPHATHANH = '" + maDotPhatHanh + @"'";

            return this.getTable(query, string.Empty);
        }

        public DataRow GetDoiTacByMaDoiTac(string maDoiTac)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"DOITAC_SEARCHBYMADOITAC";

            cmd.Parameters.Add("@p_MADOITAC", maDoiTac);

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

        public DataRow GetDoiTacByMaDoiTacMaDotPhatHanh(string maDoiTac, string maDotPhatHanh)
        {
            string query = @"SELECT *
                            FROM DOITAC dt, CHITIETDOTPHATHANH ctph
                            WHERE dt.MADOITAC = ctph.MADOITAC and ctph.MADOTPHATHANH = '" + maDotPhatHanh + "' and dt.MADOITAC = '" + maDoiTac + "'";

            DataTable dataTable = this.getTable(query, string.Empty);

            if (dataTable.Rows.Count > 0)
                return dataTable.Rows[0];
            else
                return null;
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

        public string SumaryCongNo()
        {
            string query = "SELECT SUM(CONGNO) from DOITAC";
            var sum = getSingleValueFromColumn(query, "");

            return sum.ToString();
        }
        public bool UpdateCongNo(decimal CongNo, string maDoiTac)
        {
            string query = @"UPDATE DOITAC 
                            SET CONGNO = CONGNO + '" + CongNo.ToString() + @"'
                            WHERE MADOITAC = '" + maDoiTac + "'";

            return this.ExcuteNonQueryCommand(query, string.Empty);
        }
    }
}
