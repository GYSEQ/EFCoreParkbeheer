using EFCoreParkbeheer.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.BL.Interfaces
{
    public interface IHuurderRepository
    {
        void VoegHuurderToe(Huurder huurder);
        bool HeeftHuurder(string naam, Contactgegevens contact);
        bool HeeftHuurder(int id);
        void UpdateHuurder(Huurder huurder);
        Huurder GeefHuurder(int id);
        List<Huurder> GeefHuurders(string naam);
    }
}
