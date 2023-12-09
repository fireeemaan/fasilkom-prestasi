using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Models
{
    internal class M_prodiMatkul
    {
        public long id { get; set; }
        public int id_bidang { get; set; }
        [ForeignKey("M_Bidang")]
        public int id_prodi { get; set; }
        [ForeignKey("M_Prodi")]
        public string kd_matkul { get; set; }
        [ForeignKey("M_Matkul")]

        public int semester { get; set; }
        public int sks { get; set; }
    }
}
