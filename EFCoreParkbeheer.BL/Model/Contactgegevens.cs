using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.BL.Model
{
    public class Contactgegevens
    {
        public Contactgegevens(string email, string tel, string adres)
        {
            Email = email;
            Tel = tel;
            Adres = adres;
        }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
    }
}