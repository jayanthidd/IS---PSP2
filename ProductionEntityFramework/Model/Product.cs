using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionEntityFramework
{
    class Product
    {
        //Primärschlüssel - Klassenname + Id
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
