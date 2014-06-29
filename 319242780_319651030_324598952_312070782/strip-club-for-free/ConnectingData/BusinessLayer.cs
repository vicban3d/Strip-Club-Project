using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DataAccess;
using ConnectingData;

namespace Business
{
    class BusinessLayer
    {

        public static DataTable SearchUsername(string name)
        {
            string query = "SELECT * FROM Users WHERE Username ='" + name + "'";
            DataTable dt = DataAccessLayer.ExecuteDataTable(query);
            return dt;
        }

        public static DataTable GetStorage()
        {
            try
            {
                string query = "SELECT * FROM Storage";

                DataTable dt = DataAccessLayer.ExecuteDataTable(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void UpdateStorage(string name, int quantity)
        {
            string query = "UPDATE Storage SET Quantity=" + quantity + " WHERE ProductName='" + name + "'";
            DataAccessLayer.ExecuteNonQuery(query);
        }
        public static bool Insert(string table, string fields, string values)
        {
            try{
                string query = "INSERT INTO " + table + " (" + fields + ")" + " VALUES " + "(" + values + ")";
                DataAccessLayer.ExecuteNonQuery(query);
                return true;
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public static bool Delete(string table, string where)
        {
            try
            {
                string query = "DELETE FROM " + table + " WHERE " + where + "";
                DataAccessLayer.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Update(string table, string set, string where)
        {
            try
            {
                string query = "UPDATE " + table + " SET " + set + " WHERE " + where + "";
                DataAccessLayer.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AssignShift(string id, string date)
        {
              return Insert("Shifts", "SDate, Employee_ID", "'" + date + "', " + id + "");
        }

        public static List<string> GenerateReport(string id)
        {
            try
            {
                string query = "SELECT Course FROM Apprentices WHERE ID = " + id + "";

                DataTable dt = DataAccessLayer.ExecuteDataTable(query);
                List<string> res = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    res.Add(dt.Rows[i]["Course"].ToString());
                }
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal static bool AddOrder(string data, int id, double cost)
        {
            return Insert("Orders", "ODate, Supplier_ID, Cost", "'" + data + "', " + id + ", " + cost + "");
        }

        internal static DataTable getDates()
        {
            string query = "SELECT * FROM Orders WHERE ODate < #" + DateTime.Now.ToString() + "#";
            DataTable dt = DataAccessLayer.ExecuteDataTable(query);
            return dt;
        }
    }
}
