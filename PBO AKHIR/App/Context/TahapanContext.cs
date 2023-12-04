using fasilkom_prestasi.App.Core;
using fasilkom_prestasi.App.Models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Context
{
    internal class TahapanContext : DatabaseWrapper
    {
        private static string table = "tahapan";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table} ORDER BY id ASC";
            DataTable objects = queryExecutor(query);
            return objects;
        }

        public static object[] getNames()
        {
            List<string> objects = new List<string>();

            string query = $"SELECT * FROM {table} ORDER BY id ASC";
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

        public static void store(M_Tahapan tahapanBaru)
        {
            string query = $"INSERT INTO {table}(tahapan) VALUES(@tahapan)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@tahapan", NpgsqlDbType.Varchar){Value = tahapanBaru.tahapan},

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
            DataTable dataTahapan = queryExecutor(query, parameters);
            return dataTahapan;

        }

        public static void update(M_Tahapan tahapanEdit)
        {
            string query = $"UPDATE {table} SET tahapan = @tahapan WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = tahapanEdit.id },
                new NpgsqlParameter("@tahapan", NpgsqlDbType.Varchar) { Value = tahapanEdit.tahapan }

            };
            commandExecutor(query, parameters);
        }
    }
}
