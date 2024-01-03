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
    public class ContractenRepositoryEF : IContractenRepository
    {
        private ParkbeheerContext _context = new ParkbeheerContext();

        public void AnnuleerContract(Huurcontract contract)
        {
            _context.Huurcontracten.Add(MapHuurcontract);
            _context.SaveChanges();
        }

        public Huurcontract GeefContract(string id)
        {
            return _context.Huurcontracten.FirstOrDefault(c => c.HuurcontractId == id);
        }

        public List<Huurcontract> GeefContracten(DateTime dtBegin, DateTime? dtEinde)
        {
            throw new NotImplementedException();
        }

        public bool HeeftContract(DateTime startDatum, int huurderid, int huisid)
        {
            throw new NotImplementedException();
        }

        public bool HeeftContract(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateContract(Huurcontract contract)
        {
            throw new NotImplementedException();
        }

        public void VoegContractToe(Huurcontract contract)
        {
            throw new NotImplementedException();
        }
    }
}
