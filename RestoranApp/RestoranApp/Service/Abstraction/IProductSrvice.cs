using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestoranApp.Models;

namespace RestoranApp.Service.Abstraction
{
    internal interface IProductSrvice
    {
        public void Create(String name, string nameForProduct);
        public void Remove(int proId, int resId);
        public void Update(string newname, Product product, string name);
        public void GetAllInRestaurant();
        public Restoran GetByIdInRestaurant(int id);

    }
}
