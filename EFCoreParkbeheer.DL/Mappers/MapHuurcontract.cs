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
    public static class MapHuurcontract
    {
        public static Huurcontract MapToDomain(HuurcontractEF ef)
        {
            try
            {
                Huurperiode huurperiode = new Huurperiode(ef.StartDatum, ef.EindDatum);
                return new Huurcontract(ef.HuurcontractId, );
            }
            catch (Exception ex)
            {
                throw new MapperException("MapPark - MapToDomain", ex);
            }
        }

        public static HuurcontractEF MapToEF(Park park)
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
