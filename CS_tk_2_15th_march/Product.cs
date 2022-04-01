using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_tk_2_15th_march
{
    public class Product
    {
        public void ProductDetails()
        {
            var ProductModel = new List<ProductModel>() {
                new ProductModel(){ ProductCategory = "Biscuits", items = 4},
                new ProductModel(){ProductCategory = "Chocolates", items = 5},
                new ProductModel(){ ProductCategory = "Drinks", items = 6}

            };

            foreach (var products in ProductModel)
                Console.WriteLine(products.ProductCategory + " No of Items " + products.items);
        }

    }
}
