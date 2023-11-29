using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_Prestasi
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama_prestasi { get; set; }
        public string surat_tugas { get; set; }
        public string validated { get; set; }
        public string sertifikat { get; set; }
        public DateTime create_at { get; set; }
        [ForeignKey("M_Mahasiswa")]
        public long id_mahasiswa { get; set; }
        [ForeignKey("M_Bidang")]
        public int id_bidang { get; set; }
        [ForeignKey("M_Region")]
        public int id_region { get; set; }
        [ForeignKey("M_Tahapan")]
        public int id_tahapan { get; set; }
        [ForeignKey("M_Dosen")]
        public long id_dosen { get; set; }
        [ForeignKey("M_Admin"), AllowNull]
        public string id_admin { get; set; }
        [AllowNull]
        public DateTime update_at { get; set; }
        

    }
}
