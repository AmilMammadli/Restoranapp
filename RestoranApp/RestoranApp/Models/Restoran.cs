using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranApp.Models
{
    internal class Restoran
    {
        public int id { get; set; }
        public string name { get; set; }

        public Product[] products = { };


    }
}
