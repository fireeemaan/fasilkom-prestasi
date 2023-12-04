using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;
using fasilkom_prestasi.App.Models;
using Npgsql;
using NpgsqlTypes;

namespace fasilkom_prestasi.App.Context
{
    internal class RegionContext : DatabaseWrapper
    {
        private static string table = "region";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable objects = queryExecutor(query);
            return objects;
        }

        public static object[] getNames()
        {
            List<string> objects = new List<string>();

            string query = $"SELECT * FROM {table}";
            DataTable dataTable = queryExecutor(query);

            foreach (DataRow row in dataTable.Rows)
            {
                objects.Add(row[$"{table}"].ToString());
            }
            return objects.ToArray();
        }

        public static void destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) {Value = id},
            };

            commandExecutor(query, parameters);
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
            };
            DataTable dataRegion = queryExecutor(query, parameters);
            return dataRegion;

        }
        public static void store(M_Region regionBaru)
        {

            string query = $"INSERT INTO {table}(region) VALUES(@region)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@region", NpgsqlDbType.Varchar){Value = regionBaru.region},

            };

            

            commandExecutor(query, parameters);
        }
    }
}
