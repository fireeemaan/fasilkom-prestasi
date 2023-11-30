using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_Bidang
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string bidang { get; set; }

    }
}
