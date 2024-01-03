using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Model
{
    public class HuurderEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HuurderId { get; set; }

        [Required]
        [StringLength(100)]
        public string Naam { get; set; }

        [StringLength(100)]
        public string Telefoon { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Adres { get; set; }

        public ICollection<HuurcontractEF> Huurcontracten { get; set; }
    }
}
