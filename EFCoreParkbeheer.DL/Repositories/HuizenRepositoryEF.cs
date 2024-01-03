using EFCoreParkbeheer.BL.Interfaces;
using EFCoreParkbeheer.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.DL.Repositories
{
    public class HuizenRepositoryEF : IHuizenRepository
    {
        public Huis GeefHuis(int id)
        {
            throw new NotImplementedException();
        }

        public bool HeeftHuis(string straat, int nummer, Park park)
        {
            throw new NotImplementedException();
        }

        public bool HeeftHuis(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateHuis(Huis huis)
        {
            throw new NotImplementedException();
        }

        public void VoegHuisToe(Huis h)
        {
            throw new NotImplementedException();
        }
    }
}
