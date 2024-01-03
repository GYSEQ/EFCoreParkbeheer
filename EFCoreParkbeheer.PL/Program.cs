﻿using EFCoreParkbeheer.BL.Services;
using EFCoreParkbeheer.BL.Interfaces;
using EFCoreParkbeheer.BL.Model;
using EFCoreParkbeheer.DL;
using EFCoreParkbeheer.DL.Model;
using EFCoreParkbeheer.DL.Repositories;

namespace EFCoreParkbeheer.PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ParkbeheerContext ctx = new ParkbeheerContext();
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            IHuizenRepository hrepo = new HuizenRepositoryEF();
            BeheerHuizen bh = new BeheerHuizen(hrepo);
            Park p = new Park("p2", "Binnenhoeve", "Gent");
            bh.VoegNieuwHuisToe("parklaan", 1, p);
            bh.VoegNieuwHuisToe("parklaan", 2, p);
            bh.VoegNieuwHuisToe("parklaan", 3, p);
            var x = bh.GeefHuis(1);
            x.ZetStraat("Kerkstraat");
            x.ZetNr(11);
            bh.UpdateHuis(x);
            bh.ArchiveerHuis(x);
            //Huis h1 = new Huis();
            //ParkDB pdb = new ParkDB("p1","naam","locatie");
            //HuisDB hdb = new HuisDB("straat", 5, true);
            //hdb.Park = pdb;
            //ctx.Huizen.Add(hdb);
            //ctx.SaveChanges();
            //huurder
            IHuurderRepository rhuur = new HuurderRepositoryEF();
            BeheerHuurders bhuur = new BeheerHuurders(rhuur);
            bhuur.VoegNieuweHuurderToe("jos", new Contactgegevens("email1", "tel", "adres"));
            bhuur.VoegNieuweHuurderToe("jef", new Contactgegevens("email2", "tel", "adres"));

            IContractenRepository crepo = new ContractenRepositoryEF();
            BeheerContracten bc = new BeheerContracten(crepo);
            Huurperiode hp = new Huurperiode(DateTime.Now, 10);
            Huurder h = new Huurder(2, "Jos", new Contactgegevens("email1", "tel", "adres"));
            Park p = new Park("p1", "Buitenhoeve", "Deinze");
            Huis huis = new Huis(1, "Kerkstraat", 5, true, p);
            bc.MaakContract("c2", hp, h, huis);

            var y = bc.GeefContract("c2");
            var t = bh.GeefHuis(1);
            Console.WriteLine(t);

        }
    }
}
