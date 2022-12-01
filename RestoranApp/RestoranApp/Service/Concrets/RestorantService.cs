using RestoranApp.Models;
using RestoranApp.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranApp.Service.Concrets
{
    internal class RestorantService : IRestorantService
    {
        public static Restoran[] restorans = { };

        public void Create(String name)
        {
            Restoran r = new Restoran();
            r.name = name;
            Array.Resize(ref restorans, restorans.Length + 1);
            restorans[restorans.Length - 1] = r;
        }

        public void GetAll()
        {
            foreach (var item in restorans)
            {
                Console.WriteLine(item.name);
            }
        }

        public Restoran GetById(int id)
        {
            Console.WriteLine(restorans[id].name);
            return restorans[id];
        }

        public void Remove(int index)
        {
            var last=restorans[restorans.Length-1];

            restorans[index] = last;

            Array.Resize(ref restorans, restorans.Length-1);
        }

        public void Update(string name, string newname)
        {
            foreach (var item in restorans)
            {
                if (item.name == name)
                {
                    item.name = newname;
                    return;
                }
            }
        }
    }
}
