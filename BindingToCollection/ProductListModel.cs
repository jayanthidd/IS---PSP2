using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToCollection
{
    class ProductListModel
    {
        public ObservableCollection<Product> MyProducts { get; set; }

        public ProductListModel()
        {
            MyProducts = new ObservableCollection<Product>();
            NewProduct = new Product();
        }

        internal void FillSamples()
        {
            MyProducts.Add(new Product()
            {
                ProductId = 1,
                Price = 5,
                Description = "Eraser",
                Abbildung = "Eraser.jpg"
            });

            MyProducts.Add(new Product()
            {
                ProductId = 2,
                Price = 100,
                Description = "Phone",
                Abbildung = "Phone.jpg"
            });
        }

        internal void AddNewProduct()
        {
            Product pdt = new Product();
            pdt.Description = NewProduct.Description;
            pdt.ProductId = NewProduct.ProductId;
            pdt.Price = NewProduct.Price;
            MyProducts.Add(pdt);
        }

        private Product _ChosenProduct;
        public Product ChosenProduct
        {
            get { return _ChosenProduct; }
            set { _ChosenProduct = value; }
        }

        public Product NewProduct { get; set; }


    }
}
