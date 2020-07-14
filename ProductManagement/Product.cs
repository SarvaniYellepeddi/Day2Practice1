using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class Product
    {
            int productId;
            string model;
            string brand;
            int price;

            protected void SetProductData(int productId, string model, string brand, int price, string door, string capacity, string color)
            {
                this.productId = productId;
                this.model = model;
                this.brand = brand;
                this.price = price;
            }

            protected void Display()
            {

                Console.WriteLine($"ID : {productId} Brand : {brand} Model : {model} Price : Rs.{price}");
            }
        }
    }
