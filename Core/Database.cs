using System;
using System.CodeDom;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal static class Database
    {
        private static MySqlConnection connection = new MySqlConnection("Server=10.7.167.72;Database=cookbook;UId=cookbookUser;Password=cookbookpass;");

        private static void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Return list of read elements
        internal static List<Dictionary<string, object>> Read(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                OpenConnection();

                List<Dictionary<string, object>> readItems = new List<Dictionary<string, object>>();
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        readItems.Add(Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue));
                }
                if (readItems.Count != 0)
                    return readItems;
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally 
            {
                CloseConnection();
            }
        }

        //Return count of affected rows
        internal static int Write(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                OpenConnection();
                return command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                CloseConnection();
            }
            return 0;
        }
    }
}
