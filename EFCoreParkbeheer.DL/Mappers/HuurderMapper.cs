using EFCoreParkbeheer.BL.Model;
using EFCoreParkbeheer.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Mappers
{
    public static class HuurderMapper
    {
        public static Huurder ToDomain(HuurderEF huurderEF)
        {
            return new Huurder(huurderEF.HuurderId, huurderEF.Naam, new Contactgegevens(huurderEF.Email, huurderEF.Telefoon, huurderEF.Adres));
        }

        public static HuurderEF ToEF(Huurder huurder)
        {
            return new HuurderEF
            {
                HuurderId = huurder.Id,
                Naam = huurder.Naam,
                Email = huurder.Contactgegevens.Email,
                Telefoon = huurder.Contactgegevens.Tel,
                Adres = huurder.Contactgegevens.Adres
            };
        }
    }
}
