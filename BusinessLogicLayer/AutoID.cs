using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class autoID
    {
        static public string getNextID(string nameTable, string nameSelectColumn, string prefixID)
        {
            string LastID = GetLastID(nameTable, nameSelectColumn);
            string nextID = NextID(LastID, prefixID);
            return nextID;
        }
        static public string GetLastID(string nameTable, string nameSelectColumn)
        {
            string LastID = "";
            DBConnection conn = new DBConnection();
            DataTable dt = new DataTable();
            string sql = "SELECT TOP 1 " + nameSelectColumn + " FROM " + nameTable + " ORDER BY " + nameSelectColumn + " DESC";
            dt = conn.getTable(sql);
            if (dt.Rows.Count != 0)
                LastID = dt.Rows[0][0].ToString().Trim();
            return LastID;
        }


        static public string NextID(string lastID, string prefixID)
        {
            if (lastID == "")
            {
                return prefixID + "0001";  // fixwidth default
            }
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = lastID.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;

        }
    }
}
