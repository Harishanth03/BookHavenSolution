using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DotNetEnv;

namespace BookHaven.Model
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString;

        static DatabaseConnection()
        {
            Env.Load();

            connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

            if(string.IsNullOrEmpty( connectionString))
            {

                throw new InvalidOperationException("Database connection string not found in .env file.");

            }
        }

        public static SqlConnection GetConnection()
        {

            return new SqlConnection(connectionString);

        }
    }
}
