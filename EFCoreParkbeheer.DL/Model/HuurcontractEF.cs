using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Model
{
    public class HuurcontractEF
    {
        public HuurcontractEF(string huurcontractId, DateTime startDatum, int aantalDagen, int huisId, HuisEF huis, int huurderId, HuurderEF huurder)
        {
            HuurcontractId = huurcontractId;
            StartDatum = startDatum;
            EindDatum = startDatum.AddDays(aantalDagen);
            AantalDagen = aantalDagen;
            HuisId = huisId;
            Huis = huis;
            HuurderId = huurderId;
            Huurder = huurder;
        }

        [Key]
        [StringLength(25)]
        public string HuurcontractId { get; set; }

        [Required]
        public DateTime StartDatum { get; set; }

        [Required]
        public DateTime EindDatum { get; set; }

        [Required]
        public int AantalDagen { get; set; }

        public int HuisId { get; set; }
        public HuisEF Huis { get; set; }

        public int HuurderId { get; set; }
        public HuurderEF Huurder { get; set; }
    }
}