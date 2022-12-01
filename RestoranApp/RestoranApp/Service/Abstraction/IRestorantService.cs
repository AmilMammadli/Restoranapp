using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestoranApp.Models;

namespace RestoranApp.Service.Abstraction
{
    internal interface IRestorantService
    {
        public void Create(String name);
        public void Remove(int index);
        public void Update(string name, string newname);
        public void GetAll();
        public Restoran GetById(int id);

    }
}
