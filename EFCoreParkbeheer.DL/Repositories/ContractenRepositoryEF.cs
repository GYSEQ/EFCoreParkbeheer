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
        private ParkbeheerContext ctx = new ParkbeheerContext();

        private void SaveAndClear()
        {
            ctx.SaveChanges();
            ctx.ChangeTracker.Clear();
        }

        public void AnnuleerContract(Huurcontract contract)
        {
            ctx.Huurcontracten.Remove(HuurcontractMapper.ToEF(contract, ctx));
            SaveAndClear();
        }

        public Huurcontract GeefContract(string id)
        {
            return HuurcontractMapper.ToDomain(ctx.Huurcontracten.Find(id));
        }

        public List<Huurcontract> GeefContracten(DateTime dtBegin, DateTime? dtEinde)
        {
            var query = ctx.Huurcontracten.AsQueryable();

            query = query.Where(contract => contract.StartDatum >= dtBegin);

            if (dtEinde.HasValue)
            {
                query = query.Where(contract => contract.StartDatum <= dtEinde.Value);
            }

            return query.Select(HuurcontractMapper.ToDomain).ToList();
        }

        public bool HeeftContract(DateTime startDatum, int huurderid, int huisid)
        {
            return ctx.Huurcontracten.All(contract => contract.StartDatum == startDatum && contract.HuurderId == huurderid && contract.HuisId == huisid);
        }

        public bool HeeftContract(string id)
        {
            return ctx.Huurcontracten.Any(contract => contract.HuurcontractId == id);
        }

        public void UpdateContract(Huurcontract contract)
        {
            ctx.Huurcontracten.Update(HuurcontractMapper.ToEF(contract, ctx));
        }

        public void VoegContractToe(Huurcontract contract)
        {
           ctx.Huurcontracten.Add(HuurcontractMapper.ToEF(contract, ctx));
        }
    }
}
