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

        public static DataTable show(int idNilai)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id_nilai";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_nilai", NpgsqlDbType.Integer) {Value = idNilai}
            };
            DataTable dataNilai = queryExecutor(query, parameters);
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

        public static void store(M_Nilai dataNilai)
        {
            string query = $"INSERT INTO {table}(nilai, min_sks, max_sks, \"isValid\", id_region, id_tahapan) VALUES(@nilai, @min_sks, @max_sks, @isValid, @id_region, @id_tahapan)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nilai", NpgsqlDbType.Varchar) {Value = dataNilai.nilai},
                new NpgsqlParameter("@min_sks", NpgsqlDbType.Integer) {Value = dataNilai.min_sks},
                new NpgsqlParameter("@max_sks", NpgsqlDbType.Integer) {Value = dataNilai.max_sks},
                new NpgsqlParameter("@isValid", NpgsqlDbType.Boolean) {Value = dataNilai.isValid},
                new NpgsqlParameter("@id_region", NpgsqlDbType.Integer) {Value = dataNilai.id_region},
                new NpgsqlParameter("@id_tahapan", NpgsqlDbType.Integer) {Value = dataNilai.id_tahapan}
            };

            commandExecutor(query, parameters);
        }

        public static void update(M_Nilai dataNilai)
        {
            string query = $"UPDATE {table} SET nilai = @nilai, min_sks = @min_sks, max_sks = @max_sks, \"isValid\" = @isValid, id_region = @id_region, id_tahapan = @id_tahapan WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) {Value = dataNilai.id},
                new NpgsqlParameter("@nilai", NpgsqlDbType.Varchar) {Value = dataNilai.nilai},
                new NpgsqlParameter("@min_sks", NpgsqlDbType.Integer) {Value = dataNilai.min_sks},
                new NpgsqlParameter("@max_sks", NpgsqlDbType.Integer) {Value = dataNilai.max_sks},
                new NpgsqlParameter("@isValid", NpgsqlDbType.Boolean) {Value = dataNilai.isValid},
                new NpgsqlParameter("@id_region", NpgsqlDbType.Integer) {Value = dataNilai.id_region},
                new NpgsqlParameter("@id_tahapan", NpgsqlDbType.Integer) {Value = dataNilai.id_tahapan}
            };

            commandExecutor(query, parameters);
        }

        public static int checkDuplicate(M_Nilai dataNilai)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE id_region = @id_region AND id_tahapan = @id_tahapan AND \"isValid\" = @isValid";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_region", NpgsqlDbType.Integer) {Value = dataNilai.id_region},
                new NpgsqlParameter("@id_tahapan", NpgsqlDbType.Integer) {Value = dataNilai.id_tahapan},
                new NpgsqlParameter("@isValid", NpgsqlDbType.Boolean) {Value = true}
            };

            int rowsCount = queryExecutorInt(query, parameters);
            return rowsCount;

        }

    }


}
