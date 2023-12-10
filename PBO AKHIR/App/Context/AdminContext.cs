using fasilkom_prestasi.App.Core;
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
    internal class AdminContext : DatabaseWrapper
    {
        private static string table = "admin";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table} ORDER BY id ASC";
            DataTable objects = queryExecutor(query);
            return objects;
        }
        public static DataTable show(long nip)
        {
            string query = $"SELECT * FROM {table} WHERE id = @nip";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nip", NpgsqlDbType.Bigint) {Value = nip}
            };

            DataTable dataMahasiswa = queryExecutor(query, parameters);
            return dataMahasiswa;
        }
    }
}
