using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DongYangweb.Models
{
    public class DbBusiness
    {
        #region User
        public bool ExistUser(string username, SqlConnection cn)
        {
            bool result = false;
            try
            {
                string query = "SELECT Username, Password, Salt FROM Users WHERE Username = N'" + username + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    result = true;
            }
            catch (Exception ex) { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }

        public bool CheckAuthorization(string username, string functionName, SqlConnection cn)
        {
            bool result = false;
            try
            {
                string query = @"SELECT AuthorityGroups.Id
                                FROM 
									Users INNER JOIN 
									UserAuthorities ON Users.Id = UserAuthorities.UserId INNER JOIN 
									AuthorityGroups ON UserAuthorities.AuthorityGroupId = AuthorityGroups.Id
                                WHERE Users.Username = N'" + username + "' AND (AuthorityGroups.ID = '0' OR AuthorityGroups.ID = N'" + functionName + "')";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    result = true;
            }
            catch (Exception ex) { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }
        #endregion

        #region Production
        public bool CheckBarcode(string barcode, SqlConnection cn)
        {
            bool result = false;
            try
            {
                string query = "SELECT TOP 1 * FROM Inventories WHERE Barcode = N'" + barcode + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    result = true;
            }
            catch (Exception ex) { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }
        public DataTable GetProduction(string barcode, SqlConnection cn)
        {
            DataTable tbl = new DataTable();
            try
            {
                string query = "SELECT TOP 1 * FROM Productions WHERE Barcode = N'" + barcode + "' ORDER BY ScanDate DESC";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                adp.Fill(tbl);
                adp.Dispose();
            }
            catch (Exception ex)
            { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return tbl;
        }

        public bool SetProduction(string username, string barcode, string productionStatus, string action, string completedStatus, SqlConnection cn)
        {
            bool result = false;
            try
            {
                string query = "BEGIN TRANSACTION;";
                query += "INSERT INTO Productions(Id, Barcode, ScanDate, ProductionStatus, Action, CreatedAt, CreatedBy) VALUES(N'" +
                    Guid.NewGuid().ToString() + "', N'" +
                    barcode + "', N'" +
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', N'" +
                    productionStatus + "', N'" +
                    action + "', N'" +
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', N'" +
                    username + "');";
                if (!String.IsNullOrEmpty(completedStatus))
                {
                    query += "UPDATE Inventories SET " +
                         "CompletedStatus = N'" + completedStatus + "'," +
                         "EditedAt = N'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                         "EditedBy = N'" + username + "'" +
                         " WHERE Barcode = N'" + barcode + "';";
                }
                query += "; COMMIT;";
                SqlCommand command = new SqlCommand(query);
                command.Connection = cn;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex) { }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            return result;
        }
        #endregion
    }
}