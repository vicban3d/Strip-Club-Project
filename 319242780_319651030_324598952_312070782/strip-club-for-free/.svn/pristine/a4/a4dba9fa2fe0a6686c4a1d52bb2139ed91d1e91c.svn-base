using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Business;
using ConnectingData;

namespace DataAccess
{
    class DataAccessLayer
    {
        //get the connection string from the app.config file
        static string connectionString = ConnectingData.Properties.Settings.Default.CompanyConnectionString.ToString();

        //declare the db connection
        static OleDbConnection con = new OleDbConnection(connectionString);

        /// <summary>
        /// To Execute queries which returns result set (table / relation)
        /// </summary>
        /// <param name="query">the query string</param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string query)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand(query, con);
                System.Data.OleDb.OleDbDataAdapter tableAdapter = new System.Data.OleDb.OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                tableAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// To Execute update / insert / delete queries
        /// </summary>
        /// <param name="query">the query string</param>
        public static void ExecuteNonQuery(string query)
        {
            try
            {
                con.Open();
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(query, con);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// To Execute queries which return scalar value
        /// </summary>
        /// <param name="query">the query string</param>
        public static object ExecuteScalar(string query)
        {
            try
            {
                con.Open();
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(query, con);
                return command.ExecuteScalar();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
