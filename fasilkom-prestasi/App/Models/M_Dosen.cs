using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_Dosen
    {
        [Key]
        public string id { get; set; }
        [Required]
        public string nama { get; set; }
        public string nidn { get; set; }
        public string nip { get; set; }
    }
}
