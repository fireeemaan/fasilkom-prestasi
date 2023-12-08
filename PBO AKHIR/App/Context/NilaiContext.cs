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
    internal class NilaiContext : DatabaseWrapper
    {
        private static string table = "nilai";


        public static DataTable all()
        {
            string query = $"SELECT {table}.id, region.region, tahapan.tahapan, {table}.nilai, {table}.min_sks, {table}.max_sks, {table}.\"isValid\"  FROM {table} JOIN region ON {table}.id_region = region.id JOIN tahapan ON {table}.id_tahapan = tahapan.id";

            DataTable dataNilai = queryExecutor(query);
            return dataNilai;
        }

        public static DataTable getNilai(int id_region, int id_tahapan)
        {
            string query = $"SELECT * FROM {table} WHERE id_region = @id_region AND id_tahapan = @id_tahapan AND \"isValid\" = TRUE";

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
