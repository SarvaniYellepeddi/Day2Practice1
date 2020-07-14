using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class Refrigerator : Product
    {
        internal string door;
        internal string capacity;
        internal string color;
        internal void SetProductData(int productId, string model, string brand, int price, string door, string capacity, string color)
        {
            base.SetProductData(productId, model, brand, price, door, capacity, color);
            this.door = door;
            this.capacity = capacity;
            this.color = color;
        }
        internal new void Display()
        {
            base.Display();
            Console.WriteLine($"door : {door} capacity : {capacity} color : {color}");
        }
    }
}
