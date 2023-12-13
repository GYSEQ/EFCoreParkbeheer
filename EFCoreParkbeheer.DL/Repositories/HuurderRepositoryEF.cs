using EFCoreParkbeheer.BL.Interfaces;
using EFCoreParkbeheer.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Repositories
{
    public class HuurderRepositoryEF : IHuurderRepository
    {
        public Huurder GeefHuurder(int id)
        {
            throw new NotImplementedException();
        }

        public List<Huurder> GeefHuurders(string naam)
        {
            throw new NotImplementedException();
        }

        public bool HeeftHuurder(string naam, Contactgegevens contact)
        {
            throw new NotImplementedException();
        }

        public bool HeeftHuurder(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateHuurder(Huurder huurder)
        {
            throw new NotImplementedException();
        }

        public Huurder VoegHuurderToe(Huurder h)
        {
            throw new NotImplementedException();
        }
    }
}
