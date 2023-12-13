using EFCoreParkbeheer.BL.Exceptions;
using EFCoreParkbeheer.BL.Interfaces;
using EFCoreParkbeheer.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreParkbeheer.BL.Services
{
    public class BeheerContracten
    {
        private IContractenRepository repo;

        public BeheerContracten(IContractenRepository repo)
        {
            this.repo = repo;
        }

        public void MaakContract(string id, Huurperiode huurperiode, Huurder huurder, Huis huis)
        {
            try
            {
                Huurcontract contract = new Huurcontract(id, huurperiode, huurder, huis);
                if (repo.HeeftContract(huurperiode.StartDatum, huurder.Id, huis.Id))
                    throw new BeheerderException("Maakcontract bestaat al");
                repo.VoegContractToe(contract);
            }
            catch (Exception ex)
            {
                throw new BeheerderException("", ex);
            }
        }
        public void AnnuleerContract(Huurcontract contract)
        {
            try
            {
                repo.AnnuleerContract(contract);
            }
            catch (Exception ex)
            {
                throw new BeheerderException("", ex);
            }
        }
        public void UpdateContract(Huurcontract contract)
        {
            try
            {
                if (!repo.HeeftContract(contract.Id)) throw new BeheerderException("updatecontract");
                repo.UpdateContract(contract);
            }
            catch (Exception ex)
            {
                throw new BeheerderException("", ex);
            }
        }
        public Huurcontract GeefContract(string id)
        {
            try
            {
                return repo.GeefContract(id);
            }
            catch (Exception ex)
            {
                throw new BeheerderException("", ex);
            }
        }
        public List<Huurcontract> GeefContracten(DateTime dtBegin, DateTime? dtEinde)
        {
            try
            {
                return repo.GeefContracten(dtBegin, dtEinde);
            }
            catch (Exception ex)
            {
                throw new BeheerderException("", ex);
            }
        }
    }
}
