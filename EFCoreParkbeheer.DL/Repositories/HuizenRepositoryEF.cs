using EFCoreParkbeheer.BL.Interfaces;
using EFCoreParkbeheer.BL.Model;
using EFCoreParkbeheer.DL.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Repositories
{
    public class HuizenRepositoryEF : IHuizenRepository
    {
        private ParkbeheerContext ctx = new ParkbeheerContext();

        private void SaveAndClear()
        {
            ctx.SaveChanges();
            ctx.ChangeTracker.Clear();
        }

        public Huis GeefHuis(int id)
        {
            return HuisMapper.ToDomain(ctx.Huizen.Where(x => x.HuisId == id)
                .Include(x=>x.Park)
                .AsNoTracking()
                .FirstOrDefault());
        }

        public bool HeeftHuis(string straat, int nummer, Park park)
        {
            return ctx.Huizen.Any(h => h.Straat == straat && h.Nummer == nummer && h.Park.ParkId == park.Id);
        }

        public bool HeeftHuis(int id)
        {
            return ctx.Huizen.Any(h => h.HuisId == id);
        }

        public void UpdateHuis(Huis huis)
        {
            ctx.Huizen.Update(HuisMapper.ToEF(huis, ctx));
            SaveAndClear();
        }

        public void VoegHuisToe(Huis h)
        {
            ctx.Huizen.Add(HuisMapper.ToEF(h, ctx));
            SaveAndClear();
        }
    }
}
