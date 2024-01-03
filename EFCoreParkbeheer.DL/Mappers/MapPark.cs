using EFCoreParkbeheer.BL.Model;
using EFCoreParkbeheer.DL.Exceptions;
using EFCoreParkbeheer.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Mappers
{
    public static class MapPark
    {
        public static Park MapToDomain(ParkEF ef)
        {
            try
            {
                return new Park(ef.ParkId, ef.Naam, ef.Locatie);
            }
            catch (Exception ex)
            {
                throw new MapperException("MapPark - MapToDomain", ex);
            }
        }

        public static ParkEF MapToEF(Park park)
        {
            try
            {
                return new ParkEF(park.Id, park.Naam, park.Locatie);
            }
            catch (Exception ex)
            {
                throw new MapperException("MapPark - MapToEF", ex);
            }
        }
    }
}
