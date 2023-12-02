using Npgsql;
using NpgsqlTypes;
using fasilkom_prestasi.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Model;

namespace fasilkom_prestasi.App.Context
{
    internal class PrestasiContext : DatabaseWrapper
    {
        private static string table = "prestasi";

        public static DataTable showAll(int userRole)
        {
            
            string query = "";
            if (userRole == 1)
            {
                query = $"SELECT {table}.id as id_prestasi, {table}.nama_prestasi, bidang.bidang, region.region, tahapan.tahapan, dosen.nama as nama_dosen, validated " +
                    $"FROM {table} JOIN bidang ON {table}.id_bidang = bidang.id JOIN region ON {table}.id_region = region.id JOIN tahapan ON {table}.id_tahapan = tahapan.id JOIN dosen ON {table}.id_dosen = dosen.id " +
                    $"LEFT JOIN admin ON {table}.id_admin = admin.id";

                // HARUS DITAMBAHIN WHERE

            }
            else if (userRole == 2)
            {
                query = $"SELECT  {table}.id as id_prestasi,{table}.id_mahasiswa as nim, mahasiswa.nama as nama_mahasiswa, {table}.nama_prestasi, bidang.bidang, region.region , tahapan.tahapan, {table}.sertifikat, dosen.nama as nama_dosen, {table}.surat_tugas,  validated, admin.nama as nama_admin, {table}.create_at, {table}.update_at " +
                    $"FROM {table} JOIN bidang ON {table}.id_bidang = bidang.id JOIN mahasiswa ON {table}.id_mahasiswa = mahasiswa.id JOIN region ON {table}.id_region = region.id JOIN tahapan ON {table}.id_tahapan = tahapan.id JOIN dosen ON {table}.id_dosen = dosen.id " +
                    $"LEFT JOIN admin ON {table}.id_admin = admin.id";


            }

            DataTable dataPrestasi = queryExecutor(query);
            return dataPrestasi;
        }
        public static DataTable showAll(int userRole, long nim)
        {

            string query = "";
            if (userRole == 1)
            {
                query = $"SELECT {table}.id as id_prestasi, {table}.nama_prestasi, bidang.bidang, region.region, tahapan.tahapan, dosen.nama as nama_dosen, validated " +
                    $"FROM {table} JOIN bidang ON {table}.id_bidang = bidang.id JOIN region ON {table}.id_region = region.id JOIN tahapan ON {table}.id_tahapan = tahapan.id JOIN dosen ON {table}.id_dosen = dosen.id " +
                    $"LEFT JOIN admin ON {table}.id_admin = admin.id WHERE id_mahasiswa = @id_mahasiswa";



            }


            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_Mahasiswa", NpgsqlDbType.Bigint) {Value =  nim }
            };
            

            DataTable dataPrestasi = queryExecutor(query, parameters);
            return dataPrestasi;
        }

        public static DataTable show(string id)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Varchar) { Value = id }
            };
            DataTable dataPrestasi = queryExecutor(query, parameters);
            return dataPrestasi;

        }

        public static DataTable show(int id,long nim)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id AND id_mahasiswa = @nim";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id },
                new NpgsqlParameter("@nim", NpgsqlDbType.Bigint) {Value = nim }
                
            };
            DataTable dataPrestasi = queryExecutor(query, parameters);
            return dataPrestasi;

        }


        public static void store(M_Prestasi prestasiBaru)
        {
            string query = $"INSERT INTO {table}(nama_prestasi, id_mahasiswa, sertifikat, id_bidang, id_region, id_tahapan, id_dosen) VALUES(@nama_prestasi, @id_mahasiswa, @sertifikat, @id_bidang, @id_region, @id_tahapan, @id_dosen)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_prestasi", NpgsqlDbType.Varchar){Value = prestasiBaru.nama_prestasi},
                new NpgsqlParameter("@id_mahasiswa", NpgsqlDbType.Bigint){Value = prestasiBaru.id_mahasiswa},
                new NpgsqlParameter("@sertifikat", NpgsqlDbType.Text){Value = prestasiBaru.sertifikat},
                new NpgsqlParameter("@id_bidang", NpgsqlDbType.Integer){Value = prestasiBaru.id_bidang},
                new NpgsqlParameter("@id_region", NpgsqlDbType.Integer){Value = prestasiBaru.id_region},
                new NpgsqlParameter("@id_tahapan", NpgsqlDbType.Integer){Value = prestasiBaru.id_tahapan},
                new NpgsqlParameter("@id_dosen", NpgsqlDbType.Integer){Value = prestasiBaru.id_dosen}
            };

            commandExecutor(query, parameters);
        }

        public static void destroy(string id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Varchar) {Value = id},
            };

            commandExecutor(query, parameters);
        }

        public static void update(M_Prestasi prestasiEdit)
        {
            string query = $"UPDATE {table} SET nama_prestasi = @nama_prestasi, sertifikat = @sertifikat, id_bidang = @id_bidang, id_region = @id_region, id_tahapan = @id_tahapan, id_dosen = @id_dosen WHERE id = @id";

            NpgsqlParameter[] parameters =
{
                new NpgsqlParameter("@nama_prestasi", NpgsqlDbType.Varchar){Value = prestasiEdit.nama_prestasi},
                new NpgsqlParameter("@sertifikat", NpgsqlDbType.Text){Value = prestasiEdit.sertifikat},
                new NpgsqlParameter("@id_bidang", NpgsqlDbType.Integer){Value = prestasiEdit.id_bidang},
                new NpgsqlParameter("@id_region", NpgsqlDbType.Integer){Value = prestasiEdit.id_region},
                new NpgsqlParameter("@id_tahapan", NpgsqlDbType.Integer){Value = prestasiEdit.id_tahapan},
                new NpgsqlParameter("@id_dosen", NpgsqlDbType.Integer){Value = prestasiEdit.id_dosen},
                new NpgsqlParameter("@id", NpgsqlDbType.Varchar){Value = prestasiEdit.id}

            };

            commandExecutor(query, parameters);
        }
        public static void update_admin(M_Prestasi prestasiValidasi)
        {
            string query = $"UPDATE {table} SET validated = @validated,surat_tugas = @surat_tugas WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Varchar){Value = prestasiValidasi.id},
                new NpgsqlParameter("@validated", NpgsqlDbType.Unknown){Value =  prestasiValidasi.validated},
                new NpgsqlParameter("@surat_tugas", NpgsqlDbType.Text){Value =  prestasiValidasi.surat_tugas},

            };

            commandExecutor(query, parameters);
        }
    }
}
    
    
        
           

