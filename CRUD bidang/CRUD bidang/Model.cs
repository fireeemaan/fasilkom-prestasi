using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CRUD_bidang
{
    internal class Model
    {
        [Key]
        public int? id { get; set; }
        [Required]
        public string bidang { get; set; }

    }
}
