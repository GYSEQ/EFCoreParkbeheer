using EFCoreParkbeheer.BL.Services;
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

            IHuizenRepository huizenRepo = new HuizenRepositoryEF();
            BeheerHuizen beheerHuizen = new BeheerHuizen(huizenRepo);

            Park p = new Park("p2", "Binnenhoeve", "Gent");
            beheerHuizen.VoegNieuwHuisToe("parklaan", 1, p);
            beheerHuizen.VoegNieuwHuisToe("parklaan", 2, p);
            beheerHuizen.VoegNieuwHuisToe("parklaan", 3, p);
            Console.WriteLine("Huizen toegevoegd");

            var x = beheerHuizen.GeefHuis(1);
            x.ZetStraat("Kerkstraat");
            x.ZetNr(11);
            beheerHuizen.UpdateHuis(x);
            beheerHuizen.ArchiveerHuis(x);
            Console.WriteLine("Huis aangepast");

            ParkEF pdb = new ParkEF("p1", "naam", "locatie");
            HuisEF hdb = new HuisEF("straat", 5, true);
            hdb.Park = pdb;
            ctx.Huizen.Add(hdb);
            ctx.SaveChanges();
            Console.WriteLine("Nieuw park en straat toegevoegd");

            IHuurderRepository rhuur = new HuurderRepositoryEF();
            BeheerHuurders bhuur = new BeheerHuurders(rhuur);
            bhuur.VoegNieuweHuurderToe("jos", new Contactgegevens("email1", "tel", "adres"));
            bhuur.VoegNieuweHuurderToe("jef", new Contactgegevens("email2", "tel", "adres"));
            Console.WriteLine("Huurders toegevoegd");

            IContractenRepository contractenRepo = new ContractenRepositoryEF();
            BeheerContracten beheerContracten = new BeheerContracten(contractenRepo);

            Huurperiode hp = new Huurperiode(DateTime.Now, 10);
            Huurder h = new Huurder(2, "Jos", new Contactgegevens("email1", "tel", "adres"));
            Park p3 = new Park("p3", "Buitenhoeve", "Deinze");
            Huis huis = new Huis(1, "Kerkstraat", 5, true, p);
            beheerContracten.MaakContract("c2", hp, h, huis);

        }
    }
}
