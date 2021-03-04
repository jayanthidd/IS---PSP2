using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionEvents
{
    class ProductContainer
    {
        //special delegate
        //Action is used when there is no return value from the function
        public event Action<string> OnAddingNewProduct;
        public List<Product> Products { get; set; }

        public ProductContainer()
        {
            Products = new List<Product>();
            Products.Add(new Product() { Description = "Pant", Price = 15 });
            Products.Add(new Product() { Description = "Shirt", Price = 12 });
        }

        public void addNewProduct(Product product)
        {
            Products.Add(product);
            if (OnAddingNewProduct != null)
                OnAddingNewProduct(product.Description);
        }
    }
}
