using RestoranApp.Models;
using RestoranApp.Service.Abstraction;
using RestoranApp.Service.Concrets;

namespace RestoranApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRestorantService restoran = new RestorantService();
            IProductSrvice product = new ProductService();
           

            restoran.Create("kfc");
            restoran.Create("mc");
            restoran.Create("amil");

            //restoran.Remove(0);
           
            //restoran.GetById(1);
            restoran.Update("mc","mc2");
            restoran.GetAll();

        }
    }
}