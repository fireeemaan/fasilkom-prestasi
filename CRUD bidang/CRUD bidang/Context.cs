using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_bidang
{
    internal class Context : DatabaseWrapper
    {
        private static string table = "bidang";
        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataProdi = queryExecutor(query);
            return dataProdi;
        }

        public static DataTable show(string bidang)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id";
            // Siapkan parameter WHERE
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@bidang", NpgsqlTypes.NpgsqlDbType.Integer){Value = bidang}
            };
            DataTable dataProdi = queryExecutor(query, parameters);
            return dataProdi;
        }
    }
}
