using EFCoreParkbeheer.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.BL.Interfaces
{
    public interface IContractenRepository
    {
        bool HeeftContract(DateTime startdatum, int huurderId, int huisId);
        void VoegContractToe(Huurcontract contract);
        void AnnuleerContract(Huurcontract contract);
        bool HeeftContract(string id);
        void UpdateContract(Huurcontract contract);
        Huurcontract GeefContract(string id);
        List<Huurcontract> GeefContracten(DateTime dtBegin, DateTime? dtEinde);
    }
}
