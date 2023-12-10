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
    internal class ProdiContext : DatabaseWrapper
    {
        private static string table = "prodi";
        public static DataTable all()
        {
            string query = $"SELECT * FROM {table} ORDER BY id ASC";
            DataTable objects = queryExecutor(query);
            return objects;
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

        public static void store(M_Prodi prodiBaru)
        {
            string query = $"INSERT INTO {table}(id, prodi) SELECT COALESCE(MAX(id), 0) + 1, @prodi FROM {table}";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@prodi", NpgsqlDbType.Varchar){Value = prodiBaru.prodi},

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

        public static void update(M_Prodi prodiEdit)
        {
            string query = $"UPDATE {table} SET prodi = @prodi WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = prodiEdit.id },
                new NpgsqlParameter("@prodi", NpgsqlDbType.Varchar) { Value = prodiEdit.prodi }

            };
            commandExecutor(query, parameters);
        }
    }
}

