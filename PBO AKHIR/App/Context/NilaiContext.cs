using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;
using Npgsql;
using NpgsqlTypes;

namespace fasilkom_prestasi.App.Context
{
    internal class NilaiContext : DatabaseWrapper
    {
        private static string table = "nilai";


        public static DataTable getNilai(int id_region, int id_tahapan)
        {
            string query = $"SELECT * FROM {table} WHERE id_region = @id_region AND id_tahapan = @id_tahapan";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_region", NpgsqlDbType.Integer) {Value =  id_region},
                new NpgsqlParameter("@id_tahapan", NpgsqlDbType.Integer) {Value =  id_tahapan}
            };

            DataTable dataNilai = queryExecutor(query, parameters);
            return dataNilai;

        }
    }


}
