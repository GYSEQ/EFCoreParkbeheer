using EFCoreParkbeheer.BL.Model;
using EFCoreParkbeheer.DL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Mappers
{
    public static class HuurcontractMapper
    {
        public static Huurcontract ToDomain(HuurcontractEF huurcontractEF)
        {

            Huurperiode huurperiode = new Huurperiode(huurcontractEF.StartDatum, huurcontractEF.AantalDagen);
            Huurder huurder = HuurderMapper.ToDomain(huurcontractEF.Huurder);
            Huis huis = HuisMapper.ToDomain(huurcontractEF.Huis);

            return new Huurcontract(huurcontractEF.HuurcontractId, huurperiode, huurder, huis);
        }

        public static HuurcontractEF ToEF(Huurcontract huurcontract, ParkbeheerContext ctx)
        {
            HuisEF huis = ctx.Huizen.Find(huurcontract.Huis.Id);
            if (huis == null) huis = HuisMapper.ToEF(huurcontract.Huis, ctx);
            HuurderEF huurder = ctx.Huurders.Find(huurcontract.Huurder.Id);
            if (huurder == null) huurder = HuurderMapper.ToEF(huurcontract.Huurder);
            return new HuurcontractEF(huurcontract.Id, huurcontract.Huurperiode.StartDatum, huurcontract.Huurperiode.Aantaldagen, huis.HuisId, huis, huurder.HuurderId, huurder);
        }
    }
}
