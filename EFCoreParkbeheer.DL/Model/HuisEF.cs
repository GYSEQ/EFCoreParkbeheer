using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Model
{
    public class HuisEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HuisId { get; set; }

        [StringLength(250)]
        public string Straat { get; set; }

        [Required]
        public int Nummer { get; set; }

        [Required]
        public bool Actief { get; set; }

        public string ParkId { get; set; }

        public ParkEF Park { get; set; }

        public ICollection<HuurcontractEF> Huurcontracten { get; set; }
    }
}
