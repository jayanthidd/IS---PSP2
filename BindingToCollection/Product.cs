using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToCollection
{
    class Product
    {
        public int ProductId { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Abbildung { get; set; }

        public override string ToString()
        {
            return $"{ProductId} : {Description}";
        }





    }
}
