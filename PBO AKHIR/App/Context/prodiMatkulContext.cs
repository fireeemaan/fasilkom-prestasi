using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;
using fasilkom_prestasi.App.Core;

namespace fasilkom_prestasi.App.Context
{
    internal class prodiMatkulContext : DatabaseWrapper
    {
        private static string table = "\"prodiMatkul\"";
        public static DataTable all(int id_prodi, int id_bidang, int semester)
        {
            string query = $"SELECT *, matkul.matkul FROM {table} JOIN matkul ON {table}.kd_matkul = matkul.kode WHERE id_prodi = @id_prodi AND id_bidang = @id_bidang AND semester = @semester";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_prodi", NpgsqlDbType.Integer) {Value =  id_prodi},
                new NpgsqlParameter("@id_bidang", NpgsqlDbType.Integer) {Value =  id_bidang},
                new NpgsqlParameter("@semester", NpgsqlDbType.Integer) {Value =  semester}
            };

            DataTable dataMatkul = queryExecutor(query, parameters);
            return dataMatkul;
        }

    }
}
