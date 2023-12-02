using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_KonversiMatkul
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int sks { get; set; }
        public int semester { get; set; }
        [ForeignKey("M_Konversi")]
        public int id_konversi { get; set; }
        [ForeignKey("M_Matkul")]
        public string kd_matkul { get; set; }

    }
}
