using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_Nilai
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nilai { get; set; }
        public int min_sks { get; set; }
        public int max_sks { get; set; }
        public bool isValid { get; set; }
        [ForeignKey("M_Region")]
        public int id_region { get; set; }
        [ForeignKey("M_Tahapan")]
        public int id_tahapan { get; set; }
    }
}
