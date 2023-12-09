using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;
using fasilkom_prestasi.App.Core;
using fasilkom_prestasi.App.Models;

namespace fasilkom_prestasi.App.Context
{
    internal class prodiMatkulContext : DatabaseWrapper
    {
        private static string table = "\"prodiMatkul\"";
        public static DataTable all()
        {
            string query = $"SELECT {table}.id as id, bidang.bidang ,prodi.prodi,{table}.kd_matkul as \"kode matkul\",matkul.matkul ,{table}.semester as semester," +
                $"{table}.sks as sks FROM {table} JOIN bidang ON {table}.id_bidang = bidang.id JOIN prodi ON {table}.id_prodi = prodi.id JOIN matkul ON {table}.kd_matkul = matkul.kode";
            DataTable objects = queryExecutor(query);
            return objects;
        }

        public static DataTable show(int idProdiMatkul)
        {
            string query = $"SELECT * FROM {table} WHERE {table}.id = @idProdiMK";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idProdiMK", NpgsqlDbType.Integer){Value = idProdiMatkul}
            };
            DataTable objects = queryExecutor(query, parameters);
            return objects;
        }

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
        public static DataTable all(int id_prodi, int id_bidang, int semester, string nama_matkul)
        {
            string query = $"SELECT *, matkul.matkul FROM {table} JOIN matkul ON {table}.kd_matkul = matkul.kode WHERE id_prodi = @id_prodi AND id_bidang = @id_bidang AND semester = @semester AND matkul.matkul = @nama_matkul ";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_prodi", NpgsqlDbType.Integer) {Value =  id_prodi},
                new NpgsqlParameter("@id_bidang", NpgsqlDbType.Integer) {Value =  id_bidang},
                new NpgsqlParameter("@semester", NpgsqlDbType.Integer) {Value =  semester},
                new NpgsqlParameter("@nama_matkul", NpgsqlDbType.Varchar) {Value =  nama_matkul},
            };

            DataTable dataMatkul = queryExecutor(query, parameters);
            return dataMatkul;
        }

        public static DataTable showsorted(string clicked)
        {
            string query = "";
            if (clicked == "Sistem Informasi")
            {
                query = $"SELECT {table}.id as id, bidang.bidang ,prodi.prodi,{table}.kd_matkul as \"kode matkul\",matkul.matkul ,{table}.semester as semester," +
                $"{table}.sks as sks FROM {table} JOIN bidang ON {table}.id_bidang = bidang.id JOIN prodi ON {table}.id_prodi = prodi.id JOIN matkul ON {table}.kd_matkul = matkul.kode WHERE prodi = 'Sistem Informasi'";

            }
            if (clicked == "Teknologi Informasi")
            {
                query = $"SELECT {table}.id as id, bidang.bidang ,prodi.prodi,{table}.kd_matkul as \"kode matkul\",matkul.matkul ,{table}.semester as semester," +
                $"{table}.sks as sks FROM {table} JOIN bidang ON {table}.id_bidang = bidang.id JOIN prodi ON {table}.id_prodi = prodi.id JOIN matkul ON {table}.kd_matkul = matkul.kode WHERE prodi = 'Teknologi Informasi'";
            }
            else if (clicked == "Informatika")
            {
                query = $"SELECT {table}.id as id, bidang.bidang ,prodi.prodi,{table}.kd_matkul as \"kode matkul\",matkul.matkul ,{table}.semester as semester," +
                $"{table}.sks as sks FROM {table} JOIN bidang ON {table}.id_bidang = bidang.id JOIN prodi ON {table}.id_prodi = prodi.id JOIN matkul ON {table}.kd_matkul = matkul.kode WHERE prodi = 'Informatika'";
            }

            DataTable dataPrestasi = queryExecutor(query);
            return dataPrestasi;
        }

        public static void store(M_prodiMatkul prodiMatkul)
        {
            string query = $"INSERT INTO {table}(id_bidang,id_prodi, kd_matkul, sks, semester) VALUES(@id_bidang ,@id_prodi,@kd_matkul, @sks, @semester)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_bidang", NpgsqlDbType.Integer) {Value = prodiMatkul.id_bidang },
                new NpgsqlParameter("@id_prodi", NpgsqlDbType.Integer){Value = prodiMatkul.id_prodi },
                new NpgsqlParameter("@kd_matkul", NpgsqlDbType.Varchar){Value = prodiMatkul.kd_matkul },
                new NpgsqlParameter("@sks", NpgsqlDbType.Integer){Value = prodiMatkul.sks},
                new NpgsqlParameter("@semester", NpgsqlDbType.Integer){Value = prodiMatkul.semester}
            };

            commandExecutor(query, parameters);
        }

        public static void update(M_prodiMatkul prodiMatkul)
        {
            string query = $"UPDATE {table} SET id_bidang = @id_bidang, id_prodi = @id_prodi, kd_matkul = @kd_matkul, sks = @sks, semester = @semester WHERE id = @idProdiMK";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_bidang", NpgsqlDbType.Integer) {Value = prodiMatkul.id_bidang },
                new NpgsqlParameter("@id_prodi", NpgsqlDbType.Integer){Value = prodiMatkul.id_prodi },
                new NpgsqlParameter("@kd_matkul", NpgsqlDbType.Varchar){Value = prodiMatkul.kd_matkul },
                new NpgsqlParameter("@sks", NpgsqlDbType.Integer){Value = prodiMatkul.sks},
                new NpgsqlParameter("@semester", NpgsqlDbType.Integer){Value = prodiMatkul.semester},
                new NpgsqlParameter("@idProdiMK", NpgsqlDbType.Integer){Value = prodiMatkul.id}
            };
            commandExecutor(query, parameters);
        }

        public static void destroy(int idProdiMatkul)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = idProdiMatkul}
            };
            commandExecutor(query, parameters);
        }

    }
}
