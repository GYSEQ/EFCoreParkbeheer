using EFCoreParkbeheer.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.BL.Interfaces
{
    public interface IHuizenRepository
    {
        bool HeeftHuis(string straat, int nummer, Park park);
        void VoegHuisToe(Huis huis);
        bool HeeftHuis(int id);
        void UpdateHuis(Huis huis);
        Huis GeefHuis(int id);
    }
}
