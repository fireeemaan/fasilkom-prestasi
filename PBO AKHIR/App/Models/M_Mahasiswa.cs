using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_Mahasiswa
    {
        [Key, ForeignKey("M_Credentials")]
        public int id { get; set; }
        [Required]
        public string nama { get; set; }
        public string nim { get; set; }
        public int semester { get; set; }
        public string no_hp { get; set; }
        [ForeignKey("M_Prodi")]
        public string id_prodi { get; set; }

    }
}
