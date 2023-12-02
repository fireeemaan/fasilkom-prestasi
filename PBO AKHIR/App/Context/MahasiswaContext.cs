using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;
using NpgsqlTypes;
using Npgsql;
using System.Data;

namespace fasilkom_prestasi.App.Context
{
    internal class MahasiswaContext : DatabaseWrapper
    {
        private static string table = "mahasiswa";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";

            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }

        public static DataTable show(long nim)
        {
            string query = $"SELECT * FROM {table} WHERE id = @nim";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nim", NpgsqlDbType.Bigint) {Value = nim}
            };

            DataTable dataMahasiswa = queryExecutor(query, parameters);
            return dataMahasiswa;
        }
    }
}
