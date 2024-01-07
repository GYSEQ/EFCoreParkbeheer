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

            //IHuizenRepository huizenRepository = new HuizenRepositoryEF();
            //BeheerHuizen beheerHuizen = new BeheerHuizen(huizenRepository);
            //Console.WriteLine(beheerHuizen.GeefHuis(3));

            //IHuurderRepository huurderRepository = new HuurderRepositoryEF();
            //BeheerHuurders beheerHuurders = new BeheerHuurders(huurderRepository);
            //Console.WriteLine(beheerHuurders.GeefHuurder(5));

            IContractenRepository contractenRepository = new ContractenRepositoryEF();
            BeheerContracten beheerContracten = new BeheerContracten(contractenRepository);
            
        }
    }
}
