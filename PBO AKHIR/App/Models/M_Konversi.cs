using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_Konversi
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string status { get; set; }
        public long nim { get; set; }
        public int sks_used { get; set; }
        [ForeignKey("M_Prestasi")]
        public string id_prestasi { get; set; }
        [ForeignKey("M_Nilai")]
        public int id_nilai { get; set; }   
    }
}
