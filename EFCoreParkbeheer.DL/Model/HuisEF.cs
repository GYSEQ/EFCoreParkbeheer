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
        public HuisEF(string straat, int nummer, bool actief)
        {
            Straat = straat;
            Nummer = nummer;
            Actief = actief;
        }

        public HuisEF(int huisId, string straat, int nummer, bool actief, string parkId, ParkEF park)
        {
            HuisId = huisId;
            Straat = straat;
            Nummer = nummer;
            Actief = actief;
            ParkId = parkId;
            Park = park;
        }

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
