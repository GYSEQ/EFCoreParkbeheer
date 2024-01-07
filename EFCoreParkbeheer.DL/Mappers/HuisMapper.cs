using EFCoreParkbeheer.BL.Model;
using EFCoreParkbeheer.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Mappers
{
    public static class HuisMapper
    {
        public static Huis ToDomain(HuisEF huisEF)
        {
            Park p = ParkMapper.ToDomain(huisEF.Park);

            return new Huis(huisEF.HuisId, huisEF.Straat, huisEF.Nummer, huisEF.Actief, p);
        }

        public static HuisEF ToEF(Huis huis, ParkbeheerContext ctx)
        {
            ParkEF park = ctx.Parken.Find(huis.Park.Id);
            if (park == null) park=ParkMapper.ToEF(huis.Park);
            return new HuisEF(huis.Id, huis.Straat, huis.Nr, huis.Actief, huis.Park.Id, park);
        }
    }
}