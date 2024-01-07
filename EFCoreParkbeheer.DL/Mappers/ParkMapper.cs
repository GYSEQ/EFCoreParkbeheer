using EFCoreParkbeheer.BL.Model;
using EFCoreParkbeheer.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Mappers
{
    public static class ParkMapper
    {
        public static Park ToDomain(ParkEF parkEF)
        {
            return new Park(parkEF.ParkId, parkEF.Naam, parkEF.Locatie);
        }

        public static ParkEF ToEF(Park park)
        {
            return new ParkEF(park.Id, park.Naam, park.Locatie);
        }
    }
}
