using EFCoreParkbeheer.BL.Interfaces;
using EFCoreParkbeheer.BL.Model;
using EFCoreParkbeheer.DL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Repositories
{
    public class HuurderRepositoryEF : IHuurderRepository
    {
        private ParkbeheerContext ctx = new ParkbeheerContext();

        private void SaveAndClear()
        {
            ctx.SaveChanges();
            ctx.ChangeTracker.Clear();
        }

        public Huurder GeefHuurder(int id)
        {
            return HuurderMapper.ToDomain(ctx.Huurders.Find(id));
        }

        public List<Huurder> GeefHuurders(string naam)
        {
            if (naam == null)
            {
                return ctx.Huurders.Select(HuurderMapper.ToDomain).ToList();
            }
            else
            {
                return ctx.Huurders.Where(h => h.Naam.StartsWith(naam)).Select(HuurderMapper.ToDomain).ToList();
            }
        }

        public bool HeeftHuurder(string naam, Contactgegevens contact)
        {
            return ctx.Huurders.Any(h => h.Naam == naam && h.Email == contact.Email && h.Telefoon == contact.Tel && h.Adres == contact.Adres);
        }

        public bool HeeftHuurder(int id)
        {
            return ctx.Huurders.Any(h => h.HuurderId == id);
        }

        public void UpdateHuurder(Huurder huurder)
        {
            ctx.Huurders.Update(HuurderMapper.ToEF(huurder));
            SaveAndClear();
        }

        public void VoegHuurderToe(Huurder h)
        {
            ctx.Huurders.Add(HuurderMapper.ToEF(h));
            SaveAndClear();
        }
    }
}
