using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Context;
using Krypton.Toolkit;
using Npgsql;

namespace fasilkom_prestasi.App.Core
{
    internal class DatabaseWrapper
    {
        private static readonly string DB_HOST = "localhost";
        private static readonly string DB_DATABASE = "fasilkom-prestasi";
        private static readonly string DB_USERNAME = "postgres";
        private static readonly string DB_PASSWORD = "1Mm4l0rd";
        private static readonly string DB_PORT = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        // Method Untuk Open & Close Koneksi Database
        public static void openConnection()
        {
            connection = new NpgsqlConnection($"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE};Port={DB_PORT}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }
        public static void closeConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        // Method Execute Query
        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                closeConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Method Command Wrapper
        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.Prepare();
                command.Parameters.Clear();
                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static long commandExecutor2(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                cmd.Parameters.AddRange(parameters);
                long result = (long)cmd.ExecuteScalar();
                return result;   
            }        
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}

