using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Model
{
    public class ParkEF
    {
        public ParkEF(string parkId, string naam, string locatie)
        {
            ParkId = parkId;
            Naam = naam;
            Locatie = locatie;
        }

        [Key]
        [StringLength(20)]
        public string ParkId { get; set; }

        [Required]
        [StringLength(250)]
        public string Naam { get; set; }

        [StringLength(500)]
        public string Locatie { get; set; }

        public ICollection<HuisEF> Huizen { get; set; }
    }
}
