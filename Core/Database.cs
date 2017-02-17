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
    public static class Database
    {
        private static MySqlConnection connection = new MySqlConnection("Server=10.7.167.72;Database=cookbook;UId=cookbookUser;Password=cookbookpass;");

        public static void OpenConnection()
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

        public static void CloseConnection()
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

        public static IDataReader Execute(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                OpenConnection();
                IDataReader reader = command.ExecuteReader();

                //reader.


            }
            catch (Exception e)
            {
                
            }
            finally 
            {
                CloseConnection();
            }
            return null;
        }
    }
}
