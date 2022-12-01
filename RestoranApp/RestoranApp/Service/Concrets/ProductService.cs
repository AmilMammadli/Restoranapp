using RestoranApp.Models;
using RestoranApp.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestoranApp.Service.Concrets
{
    internal class ProductService : IProductSrvice
    {
        public void Create(String name, string nameForProduct)
        {
            foreach (var item in RestorantService.restorans)
            {
                if (item.name == name)
                {
                    Array.Resize(ref item.products, item.products.Length + 1);
                    item.products[item.products.Length - 1] = new Product { name = nameForProduct };
                }
            }
        }

        public void GetAllInRestaurant()
        {
            foreach (var item in RestorantService.restorans)
            {
                Console.WriteLine(item.name);
            }
        }

        public Restoran GetByIdInRestaurant(int id)
        {
            Console.WriteLine(RestorantService.restorans[id].name);
            return RestorantService.restorans[id];
        }
        public void Remove(int proId, int resId)
        {
            foreach(var item in RestorantService.restorans)
            {
                if(resId == item.id)
                {
                    foreach (var item2 in item.products)
                    {
                        if(proId == item2.id)
                        {
                            var last = item.products[item.products.Length-1];
                            item.products[proId] = last;
                            Array.Resize(ref item.products, item.products.Length - 1);
                        }
                    }
                }
            }
        }

        public void Update(string newname, Product product, string name)
        {
            foreach (var item in RestorantService.restorans)
            {
                if (item.name == name)
                {
                    foreach(var item2 in item.products)
                    {
                        item2.name = newname;
                    }
                }
            }
        }
    }
}
