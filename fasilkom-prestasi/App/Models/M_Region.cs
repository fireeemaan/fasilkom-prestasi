using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_Region
    {
        [Key]
        public string id { get; set; }
        [Required]
        public string region { get; set; }
    }
}
