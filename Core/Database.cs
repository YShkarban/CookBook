using System;
using System.CodeDom;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
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

        internal static Dictionary<string, object> Execute(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                OpenConnection();

                using (IDataReader reader = command.ExecuteReader())
                {
                    if(reader.Read())
                        return Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue);
                    return null;
                }
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
    }
}
