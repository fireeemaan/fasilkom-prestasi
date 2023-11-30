using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_Credentials
    {
        [Key]
        public string username { get; set; }
        [Required] 
        public string password { get; set; }
    }
}
